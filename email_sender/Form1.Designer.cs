
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
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(8, 432);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(443, 23);
            this.progressBar.TabIndex = 12;
            this.progressBar.Click += new System.EventHandler(this.progressBar_Click);
            // 
            // sendButton
            // 
            this.sendButton.Location = new System.Drawing.Point(33, 403);
            this.sendButton.Name = "sendButton";
            this.sendButton.Size = new System.Drawing.Size(75, 23);
            this.sendButton.TabIndex = 11;
            this.sendButton.Text = "send";
            this.sendButton.Click += new System.EventHandler(this.sendButton_Click_1);
            // 
            // fromNameTextBox
            // 
            this.fromNameTextBox.Location = new System.Drawing.Point(33, 12);
            this.fromNameTextBox.Name = "fromNameTextBox";
            this.fromNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.fromNameTextBox.TabIndex = 2;
            this.fromNameTextBox.Text = "Александр";
            // 
            // messageTextBox
            // 
            this.messageTextBox.Location = new System.Drawing.Point(33, 137);
            this.messageTextBox.Name = "messageTextBox";
            this.messageTextBox.Size = new System.Drawing.Size(404, 240);
            this.messageTextBox.TabIndex = 3;
            this.messageTextBox.Text = resources.GetString("messageTextBox.Text");
            this.messageTextBox.TextChanged += new System.EventHandler(this.messageTextBox_TextChanged);
            // 
            // fromAddressTextBox
            // 
            this.fromAddressTextBox.Location = new System.Drawing.Point(33, 38);
            this.fromAddressTextBox.Name = "fromAddressTextBox";
            this.fromAddressTextBox.Size = new System.Drawing.Size(100, 20);
            this.fromAddressTextBox.TabIndex = 4;
            this.fromAddressTextBox.Text = "Contact@astar-it.com";
            // 
            // subjectTextBox
            // 
            this.subjectTextBox.Location = new System.Drawing.Point(33, 65);
            this.subjectTextBox.Name = "subjectTextBox";
            this.subjectTextBox.Size = new System.Drawing.Size(100, 20);
            this.subjectTextBox.TabIndex = 5;
            this.subjectTextBox.Text = "Добрый день";
            this.subjectTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // csvFileTextBox
            // 
            this.csvFileTextBox.Location = new System.Drawing.Point(33, 92);
            this.csvFileTextBox.Name = "csvFileTextBox";
            this.csvFileTextBox.Size = new System.Drawing.Size(160, 20);
            this.csvFileTextBox.TabIndex = 6;
            this.csvFileTextBox.Text = "example_base (1).csv";
            // 
            // smtpHostTextBox
            // 
            this.smtpHostTextBox.Location = new System.Drawing.Point(193, 11);
            this.smtpHostTextBox.Name = "smtpHostTextBox";
            this.smtpHostTextBox.Size = new System.Drawing.Size(100, 20);
            this.smtpHostTextBox.TabIndex = 7;
            this.smtpHostTextBox.Text = "smtp-pulse.com";
            // 
            // smtpPortTextBox
            // 
            this.smtpPortTextBox.Location = new System.Drawing.Point(193, 37);
            this.smtpPortTextBox.Name = "smtpPortTextBox";
            this.smtpPortTextBox.Size = new System.Drawing.Size(100, 20);
            this.smtpPortTextBox.TabIndex = 8;
            this.smtpPortTextBox.Text = "2525";
            // 
            // smtpUsernameTextBox
            // 
            this.smtpUsernameTextBox.Location = new System.Drawing.Point(193, 64);
            this.smtpUsernameTextBox.Name = "smtpUsernameTextBox";
            this.smtpUsernameTextBox.Size = new System.Drawing.Size(100, 20);
            this.smtpUsernameTextBox.TabIndex = 9;
            this.smtpUsernameTextBox.Text = "contact@astar-it.com";
            // 
            // smtpPasswordTextBox
            // 
            this.smtpPasswordTextBox.Location = new System.Drawing.Point(200, 91);
            this.smtpPasswordTextBox.Name = "smtpPasswordTextBox";
            this.smtpPasswordTextBox.Size = new System.Drawing.Size(100, 20);
            this.smtpPasswordTextBox.TabIndex = 10;
            // 
            // successCountLabel
            // 
            this.successCountLabel.AutoSize = true;
            this.successCountLabel.Location = new System.Drawing.Point(314, 12);
            this.successCountLabel.Name = "successCountLabel";
            this.successCountLabel.Size = new System.Drawing.Size(13, 13);
            this.successCountLabel.TabIndex = 13;
            this.successCountLabel.Text = "0";
            // 
            // messageRichTextBox
            // 
            this.messageRichTextBox.Location = new System.Drawing.Point(455, 31);
            this.messageRichTextBox.Name = "messageRichTextBox";
            this.messageRichTextBox.Size = new System.Drawing.Size(317, 418);
            this.messageRichTextBox.TabIndex = 14;
            this.messageRichTextBox.Text = "";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(455, 8);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(175, 17);
            this.checkBox1.TabIndex = 15;
            this.checkBox1.Text = "Пиьсма из листа, а не из cvs";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(33, 118);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(147, 17);
            this.checkBox2.TabIndex = 16;
            this.checkBox2.Text = "Пиьсма из Txt,а не CVS";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(784, 461);
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
    }
}

