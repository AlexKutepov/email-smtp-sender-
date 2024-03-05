using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using MailKit.Net.Smtp;
using MailKit.Security;
using MimeKit;
using System.Text.RegularExpressions;

namespace EmailSender
{
    public partial class Form1 : Form
    {
        private List<string> recipients;
        private string messageText;
        private string subject;
        private string smtpHost;
        private int smtpPort;
        private string smtpUsername;
        private string smtpPassword;

        private int delaySeconds = 3600; // 1 час

        public Form1()
        {
            InitializeComponent();
        }

        private void WriteToFile(string filePath, string text)
        {
            // Проверяем существование файла
            if (!File.Exists(filePath))
            {
                // Если файл не существует, создаем новый и записываем строку
                using (var writer = File.CreateText(filePath))
                {
                    writer.WriteLine(text);
                }
            }
            else
            {
                // Если файл существует, добавляем новую строку в конец файла
                using (var writer = new StreamWriter(filePath, true))
                {
                    writer.WriteLine(text);
                }
            }
        }


        private async Task SendEmailAsync(string recipient)
        {
            var message = new MimeMessage();
            message.From.Add(new MailboxAddress(fromNameTextBox.Text, fromAddressTextBox.Text));
            message.To.Add(MailboxAddress.Parse(recipient));
            message.Subject = subjectTextBox.Text;
            message.Body = new TextPart("plain")
            {
                Text = messageText
            };

            using (var client = new SmtpClient())
            {
                await client.ConnectAsync(smtpHost, smtpPort, SecureSocketOptions.StartTls);
                await client.AuthenticateAsync(smtpUsername, smtpPassword);

                // Добавляем задержку в 1 секунду перед отправкой сообщения
                await Task.Delay(1000);

                await client.SendAsync(message);
                await client.DisconnectAsync(true);
                // Увеличиваем счетчик успешно отправленных писем
                successCount++;

                // Обновляем текст компонента Label с текущим значением счетчика
                UpdateSuccessCountLabel();
            }
        }

        private bool ValidateInputs()
        {

            string csvFilePath = Path.Combine(Application.StartupPath, csvFileTextBox.Text);

            if (!File.Exists(csvFilePath) && !useRichTextBox)
            {
                MessageBox.Show("CSV file does not exist.");
                return false;
            }



            if (string.IsNullOrWhiteSpace(fromNameTextBox.Text) || string.IsNullOrWhiteSpace(fromAddressTextBox.Text))
            {
                MessageBox.Show("Please enter sender's name and email address.");
                return false;
            }

            if (string.IsNullOrWhiteSpace(subjectTextBox.Text))
            {
                MessageBox.Show("Please enter email subject.");
                return false;
            }

            if (string.IsNullOrWhiteSpace(messageTextBox.Text))
            {
                MessageBox.Show("Please enter email message.");
                return false;
            }

            if (string.IsNullOrWhiteSpace(smtpHostTextBox.Text) || !int.TryParse(smtpPortTextBox.Text, out _))
            {
                MessageBox.Show("Please enter valid SMTP server and port.");
                return false;
            }

            if (string.IsNullOrWhiteSpace(smtpUsernameTextBox.Text) || string.IsNullOrWhiteSpace(smtpPasswordTextBox.Text))
            {
                MessageBox.Show("Please enter SMTP username and password.");
                return false;
            }

            recipients = LoadRecipients(csvFileTextBox.Text);
            messageText = messageTextBox.Text;
            subject = subjectTextBox.Text;
            smtpHost = smtpHostTextBox.Text;
            smtpPort = int.Parse(smtpPortTextBox.Text);
            smtpUsername = smtpUsernameTextBox.Text;
            smtpPassword = smtpPasswordTextBox.Text;

            return true;
        }
        public bool useRichTextBox = false;
        public bool useRichTextBoxTxt = false;
        private List<string> LoadRecipients(string filePath)
        {
            var recipients = new List<string>();

            // Проверяем, следует ли использовать RichTextBox
            if (useRichTextBox)
            {
                // Если выбрано использование RichTextBox, читаем адреса построчно из RichTextBox
                string[] lines = messageRichTextBox.Lines;
                foreach (string line in lines)
                {
                    // Пропускаем пустые строки
                    if (!string.IsNullOrWhiteSpace(line))
                    {
                        // Используем регулярное выражение для поиска адреса электронной почты в строке
                        Match match = Regex.Match(line.Trim(), @"\b[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Z|a-z]{2,}\b", RegexOptions.IgnoreCase);
                        if (match.Success)
                        {
                            // Если найден адрес электронной почты, добавляем его в список
                            recipients.Add(match.Value);
                        }
                        else
                        {
                            // Если адрес электронной почты не найден в строке, выводим сообщение об ошибке или проигнорируем строку
                            MessageBox.Show($"Ошибка: Неверный формат адреса электронной почты в строке: {line}");
                        }
                    }
                }
             
                return recipients; 
            }

            else if (useRichTextBoxTxt)
            {
                using (var reader = new StreamReader(filePath))
                {
                    while (!reader.EndOfStream)
                    {
                        var line = reader.ReadLine();
                        if (!string.IsNullOrWhiteSpace(line))
                        {
                            try
                            {
                                // Добавляем адрес только в случае успешного парсинга
                                recipients.Add(line.Trim());
                            }
                            catch (Exception ex)
                            {
                                // Если произошла ошибка при парсинге, выводим сообщение об ошибке
                                MessageBox.Show($"Error parsing line: {line}. Skipping to the next line. Error: {ex.Message}");
                            }
                        }
                    }
                }
                return recipients; 
            }
            else
                try
                {
                    using (var reader = new StreamReader(filePath))
                    {
                        while (!reader.EndOfStream)
                        {
                            var line = reader.ReadLine();
                            if (!string.IsNullOrWhiteSpace(line))
                            {
                                var emails = line.Split(',');
                                foreach (var email in emails)
                                {
                                    try
                                    {
                                        var trimmedEmail = email.Trim();
                                        // Проверяем, является ли адрес электронной почты допустимым
                                        var addr = new System.Net.Mail.MailAddress(trimmedEmail);
                                        recipients.Add(trimmedEmail);
                                    }
                                    catch (FormatException)
                                    {
                                        // Если адрес электронной почты недопустимый, пропускаем его
                                        continue;
                                    }
                                }
                            }
                        }
                        return recipients;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error while loading recipients: {ex.Message}");
                }
            return recipients;
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void progressBar_Click(object sender, EventArgs e)
        {

        }
        private int successCount = 0;
        private void UpdateSuccessCountLabel()
        {
            // Обновляем текст компонента Label с текущим значением счетчика
            successCountLabel.Text = $"Successfully sent: {successCount}";
        }

        private async void sendButton_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show($"Lets send");
            if (!ValidateInputs())
                return;

            try
            {
                progressBar.Maximum = recipients.Count;
                progressBar.Value = 0;

                var successCount = 0;
                var errorCount = 0;

                int emailsSent = 0;
                int delayMilliseconds = delaySeconds * 1000; // Задержка в 1 час между итерациями

                while (emailsSent < recipients.Count)
                {
                    for (int i = emailsSent; i < Math.Min(emailsSent + 50, recipients.Count); i++)
                    {
                        var recipient = recipients[i];
                        try
                        {
                            await SendEmailAsync(recipient);
                            successCount++;
                            WriteToFile("good.txt", recipient);
                        }
                        catch (Exception ex)
                        {
                            errorCount++;
                            WriteToFile("bad.txt", $"{recipient}: {ex.Message}");
                        }

                        progressBar.Value++;
                    }

                    emailsSent += 50;

                    // Если не все письма отправлены, ждем 1 час перед следующей итерацией
                    if (emailsSent < recipients.Count)
                        await Task.Delay(delayMilliseconds);
                }

                MessageBox.Show($"Emails sent successfully: {successCount}, Failed: {errorCount}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to send emails: {ex.Message}");
            }
        }   

        private void messageTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            useRichTextBox = checkBox1.Checked;

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            useRichTextBoxTxt = checkBox1.Checked;
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
