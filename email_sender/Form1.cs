using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using MailKit.Net.Smtp;
using MailKit.Security;
using MimeKit;

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

        private async void sendButton_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs())
                return;

            try
            {
                progressBar.Maximum = recipients.Count;
                progressBar.Value = 0;

                var successCount = 0;
                var errorCount = 0;

                int delayMilliseconds = recipients.Count > 50 ? delaySeconds * 1000 : 0; // Если адресов больше 50, устанавливаем задержку, иначе 0

                foreach (var recipient in recipients)
                {
                    if (delayMilliseconds > 0)
                        await Task.Delay(delayMilliseconds); // Задержка между отправкой 50 сообщений в 1 час

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

                MessageBox.Show($"Emails sent successfully: {successCount}, Failed: {errorCount}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to send emails: {ex.Message}");
            }
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
            }
        }

        private bool ValidateInputs()
        {
            if (!File.Exists(csvFileTextBox.Text))
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

        private List<string> LoadRecipients(string filePath)
        {
            var recipients = new List<string>();
            using (var reader = new StreamReader(filePath))
            {
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    if (!string.IsNullOrWhiteSpace(line))
                    {
                        recipients.Add(line.Trim());
                    }
                }
            }
            return recipients;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
