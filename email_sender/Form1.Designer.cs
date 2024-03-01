
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
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.sendButton = new System.Windows.Forms.Button();
            this.fromNameTextBox = new System.Windows.Forms.TextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.fromAddressTextBox = new System.Windows.Forms.TextBox();
            this.subjectTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(33, 383);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(404, 23);
            this.progressBar.TabIndex = 0;
            // 
            // sendButton
            // 
            this.sendButton.Location = new System.Drawing.Point(175, 426);
            this.sendButton.Name = "sendButton";
            this.sendButton.Size = new System.Drawing.Size(75, 23);
            this.sendButton.TabIndex = 1;
            this.sendButton.Text = "send";
            this.sendButton.UseVisualStyleBackColor = true;
            // 
            // fromNameTextBox
            // 
            this.fromNameTextBox.Location = new System.Drawing.Point(33, 12);
            this.fromNameTextBox.Name = "fromNameTextBox";
            this.fromNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.fromNameTextBox.TabIndex = 2;
            this.fromNameTextBox.Text = "Александр";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(33, 137);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(404, 240);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = "";
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
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.subjectTextBox);
            this.Controls.Add(this.fromAddressTextBox);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.fromNameTextBox);
            this.Controls.Add(this.sendButton);
            this.Controls.Add(this.progressBar);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }



        #endregion

        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Button sendButton;
        private System.Windows.Forms.TextBox fromNameTextBox;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.TextBox fromAddressTextBox;
        private System.Windows.Forms.TextBox subjectTextBox;
    }
}

