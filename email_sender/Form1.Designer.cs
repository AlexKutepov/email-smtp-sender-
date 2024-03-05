
namespace EmailSender
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.sendButton = new System.Windows.Forms.Button();
            this.fromNameTextBox = new System.Windows.Forms.TextBox();
            this.messageTextBox = new System.Windows.Forms.RichTextBox();
            this.fromAddressTextBox = new System.Windows.Forms.TextBox();
            this.subjectTextBox = new System.Windows.Forms.TextBox();
            this.csvFileTextBox = new System.Windows.Forms.TextBox();
            this.smtpHostTextBox = new System.Windows.Forms.TextBox();
            this.smtpPortTextBox = new System.Windows.Forms.TextBox();
            this.smtpUsernameTextBox = new System.Windows.Forms.TextBox();
            this.smtpPasswordTextBox = new System.Windows.Forms.TextBox();
            this.successCountLabel = new System.Windows.Forms.Label();
            this.messageRichTextBox = new System.Windows.Forms.RichTextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.MailsForTime = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.minutes = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(27, 656);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(782, 23);
            this.progressBar.TabIndex = 12;
            this.progressBar.Click += new System.EventHandler(this.progressBar_Click);
            // 
            // sendButton
            // 
            this.sendButton.Location = new System.Drawing.Point(27, 607);
            this.sendButton.Name = "sendButton";
            this.sendButton.Size = new System.Drawing.Size(170, 43);
            this.sendButton.TabIndex = 11;
            this.sendButton.Text = "send";
            this.sendButton.Click += new System.EventHandler(this.sendButton_Click_1);
            // 
            // fromNameTextBox
            // 
            this.fromNameTextBox.Location = new System.Drawing.Point(485, 36);
            this.fromNameTextBox.Name = "fromNameTextBox";
            this.fromNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.fromNameTextBox.TabIndex = 2;
            this.fromNameTextBox.Text = "Александр";
            // 
            // messageTextBox
            // 
            this.messageTextBox.Location = new System.Drawing.Point(27, 24);
            this.messageTextBox.Name = "messageTextBox";
            this.messageTextBox.Size = new System.Drawing.Size(395, 577);
            this.messageTextBox.TabIndex = 3;
            this.messageTextBox.Text = resources.GetString("messageTextBox.Text");
            this.messageTextBox.TextChanged += new System.EventHandler(this.messageTextBox_TextChanged);
            // 
            // fromAddressTextBox
            // 
            this.fromAddressTextBox.Location = new System.Drawing.Point(485, 75);
            this.fromAddressTextBox.Name = "fromAddressTextBox";
            this.fromAddressTextBox.Size = new System.Drawing.Size(100, 20);
            this.fromAddressTextBox.TabIndex = 4;
            this.fromAddressTextBox.Text = "Contact@astar-it.com";
            // 
            // subjectTextBox
            // 
            this.subjectTextBox.Location = new System.Drawing.Point(485, 113);
            this.subjectTextBox.Name = "subjectTextBox";
            this.subjectTextBox.Size = new System.Drawing.Size(100, 20);
            this.subjectTextBox.TabIndex = 5;
            this.subjectTextBox.Text = "Добрый день";
            this.subjectTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // csvFileTextBox
            // 
            this.csvFileTextBox.Location = new System.Drawing.Point(485, 155);
            this.csvFileTextBox.Name = "csvFileTextBox";
            this.csvFileTextBox.Size = new System.Drawing.Size(111, 20);
            this.csvFileTextBox.TabIndex = 6;
            this.csvFileTextBox.Text = "example_base (1).csv";
            // 
            // smtpHostTextBox
            // 
            this.smtpHostTextBox.Location = new System.Drawing.Point(663, 36);
            this.smtpHostTextBox.Name = "smtpHostTextBox";
            this.smtpHostTextBox.Size = new System.Drawing.Size(146, 20);
            this.smtpHostTextBox.TabIndex = 7;
            this.smtpHostTextBox.Text = "smtp-pulse.com";
            // 
            // smtpPortTextBox
            // 
            this.smtpPortTextBox.Location = new System.Drawing.Point(663, 75);
            this.smtpPortTextBox.Name = "smtpPortTextBox";
            this.smtpPortTextBox.Size = new System.Drawing.Size(146, 20);
            this.smtpPortTextBox.TabIndex = 8;
            this.smtpPortTextBox.Text = "2525";
            // 
            // smtpUsernameTextBox
            // 
            this.smtpUsernameTextBox.Location = new System.Drawing.Point(663, 113);
            this.smtpUsernameTextBox.Name = "smtpUsernameTextBox";
            this.smtpUsernameTextBox.Size = new System.Drawing.Size(146, 20);
            this.smtpUsernameTextBox.TabIndex = 9;
            this.smtpUsernameTextBox.Text = "contact@astar-it.com";
            // 
            // smtpPasswordTextBox
            // 
            this.smtpPasswordTextBox.Location = new System.Drawing.Point(663, 155);
            this.smtpPasswordTextBox.Name = "smtpPasswordTextBox";
            this.smtpPasswordTextBox.Size = new System.Drawing.Size(146, 20);
            this.smtpPasswordTextBox.TabIndex = 10;
            this.smtpPasswordTextBox.Text = "79krmkNPKp";
            // 
            // successCountLabel
            // 
            this.successCountLabel.AutoSize = true;
            this.successCountLabel.Location = new System.Drawing.Point(259, 607);
            this.successCountLabel.Name = "successCountLabel";
            this.successCountLabel.Size = new System.Drawing.Size(13, 13);
            this.successCountLabel.TabIndex = 13;
            this.successCountLabel.Text = "0";
            // 
            // messageRichTextBox
            // 
            this.messageRichTextBox.Location = new System.Drawing.Point(428, 232);
            this.messageRichTextBox.Name = "messageRichTextBox";
            this.messageRichTextBox.Size = new System.Drawing.Size(381, 418);
            this.messageRichTextBox.TabIndex = 14;
            this.messageRichTextBox.Text = "";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(428, 208);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(161, 17);
            this.checkBox1.TabIndex = 15;
            this.checkBox1.Text = "Mails from form,not from CVS";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(428, 185);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(136, 17);
            this.checkBox2.TabIndex = 16;
            this.checkBox2.Text = "Mails from Txt, not CVS";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(612, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Settings";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(444, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(453, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Mail";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(436, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Subject";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(615, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Smtp";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(620, 75);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "Port";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(604, 113);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 13);
            this.label7.TabIndex = 23;
            this.label7.Text = "Mail Smtp";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(428, 158);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 13);
            this.label8.TabIndex = 24;
            this.label8.Text = "csv/txt";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(604, 158);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 13);
            this.label9.TabIndex = 25;
            this.label9.Text = "psw smtp";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(197, 8);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(26, 13);
            this.label10.TabIndex = 26;
            this.label10.Text = "Mail";
            // 
            // MailsForTime
            // 
            this.MailsForTime.Location = new System.Drawing.Point(678, 185);
            this.MailsForTime.Name = "MailsForTime";
            this.MailsForTime.Size = new System.Drawing.Size(131, 20);
            this.MailsForTime.TabIndex = 27;
            this.MailsForTime.Text = "50";
            this.MailsForTime.TextChanged += new System.EventHandler(this.MailsForTime_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(604, 189);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(68, 13);
            this.label11.TabIndex = 28;
            this.label11.Text = "Mails for time";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(678, 208);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(131, 20);
            this.textBox2.TabIndex = 29;
            this.textBox2.Text = "60";
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // minutes
            // 
            this.minutes.AutoSize = true;
            this.minutes.Location = new System.Drawing.Point(592, 211);
            this.minutes.Name = "minutes";
            this.minutes.Size = new System.Drawing.Size(80, 13);
            this.minutes.TabIndex = 30;
            this.minutes.Text = "minutes for wait";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 681);
            this.Controls.Add(this.minutes);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.MailsForTime);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.messageRichTextBox);
            this.Controls.Add(this.successCountLabel);
            this.Controls.Add(this.smtpPasswordTextBox);
            this.Controls.Add(this.smtpUsernameTextBox);
            this.Controls.Add(this.smtpPortTextBox);
            this.Controls.Add(this.smtpHostTextBox);
            this.Controls.Add(this.csvFileTextBox);
            this.Controls.Add(this.subjectTextBox);
            this.Controls.Add(this.fromAddressTextBox);
            this.Controls.Add(this.messageTextBox);
            this.Controls.Add(this.fromNameTextBox);
            this.Controls.Add(this.sendButton);
            this.Controls.Add(this.progressBar);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }



        #endregion

        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Button sendButton;
        private System.Windows.Forms.TextBox fromNameTextBox;
        private System.Windows.Forms.RichTextBox messageTextBox;
        private System.Windows.Forms.TextBox fromAddressTextBox;
        private System.Windows.Forms.TextBox subjectTextBox;
        private System.Windows.Forms.TextBox csvFileTextBox;
        private System.Windows.Forms.TextBox smtpHostTextBox;
        private System.Windows.Forms.TextBox smtpPortTextBox;
        private System.Windows.Forms.TextBox smtpUsernameTextBox;
        private System.Windows.Forms.TextBox smtpPasswordTextBox;
        private System.Windows.Forms.Label successCountLabel;
        private System.Windows.Forms.RichTextBox messageRichTextBox;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox MailsForTime;
        private System.Windows.Forms.Label minutes;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label11;
    }
}

