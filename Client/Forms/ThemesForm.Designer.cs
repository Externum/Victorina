namespace Client
{
    partial class ThemesForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Theme1Button = new System.Windows.Forms.Button();
            this.Theme2Button = new System.Windows.Forms.Button();
            this.Theme3Button = new System.Windows.Forms.Button();
            this.Theme4Button = new System.Windows.Forms.Button();
            this.Theme5Button = new System.Windows.Forms.Button();
            this.Theme6Button = new System.Windows.Forms.Button();
            this.Theme7Button = new System.Windows.Forms.Button();
            this.Theme8Button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.NotificationTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Theme1Button
            // 
            this.Theme1Button.Location = new System.Drawing.Point(13, 39);
            this.Theme1Button.Name = "Theme1Button";
            this.Theme1Button.Size = new System.Drawing.Size(121, 42);
            this.Theme1Button.TabIndex = 0;
            this.Theme1Button.Text = "Тема1";
            this.Theme1Button.UseVisualStyleBackColor = true;
            this.Theme1Button.Click += new System.EventHandler(this.Theme1Button_Click);
            // 
            // Theme2Button
            // 
            this.Theme2Button.Location = new System.Drawing.Point(150, 39);
            this.Theme2Button.Name = "Theme2Button";
            this.Theme2Button.Size = new System.Drawing.Size(122, 42);
            this.Theme2Button.TabIndex = 1;
            this.Theme2Button.Text = "Тема2";
            this.Theme2Button.UseVisualStyleBackColor = true;
            this.Theme2Button.Click += new System.EventHandler(this.Theme2Button_Click);
            // 
            // Theme3Button
            // 
            this.Theme3Button.Location = new System.Drawing.Point(12, 97);
            this.Theme3Button.Name = "Theme3Button";
            this.Theme3Button.Size = new System.Drawing.Size(121, 42);
            this.Theme3Button.TabIndex = 2;
            this.Theme3Button.Text = "Тема3";
            this.Theme3Button.UseVisualStyleBackColor = true;
            this.Theme3Button.Click += new System.EventHandler(this.Theme3Button_Click);
            // 
            // Theme4Button
            // 
            this.Theme4Button.Location = new System.Drawing.Point(150, 97);
            this.Theme4Button.Name = "Theme4Button";
            this.Theme4Button.Size = new System.Drawing.Size(122, 42);
            this.Theme4Button.TabIndex = 3;
            this.Theme4Button.Text = "Тема4";
            this.Theme4Button.UseVisualStyleBackColor = true;
            this.Theme4Button.Click += new System.EventHandler(this.Theme4Button_Click);
            // 
            // Theme5Button
            // 
            this.Theme5Button.Location = new System.Drawing.Point(11, 154);
            this.Theme5Button.Name = "Theme5Button";
            this.Theme5Button.Size = new System.Drawing.Size(122, 42);
            this.Theme5Button.TabIndex = 4;
            this.Theme5Button.Text = "Тема5";
            this.Theme5Button.UseVisualStyleBackColor = true;
            this.Theme5Button.Click += new System.EventHandler(this.Theme5Button_Click);
            // 
            // Theme6Button
            // 
            this.Theme6Button.Location = new System.Drawing.Point(150, 154);
            this.Theme6Button.Name = "Theme6Button";
            this.Theme6Button.Size = new System.Drawing.Size(122, 42);
            this.Theme6Button.TabIndex = 5;
            this.Theme6Button.Text = "Тема6";
            this.Theme6Button.UseVisualStyleBackColor = true;
            this.Theme6Button.Click += new System.EventHandler(this.Theme6Button_Click);
            // 
            // Theme7Button
            // 
            this.Theme7Button.Location = new System.Drawing.Point(13, 207);
            this.Theme7Button.Name = "Theme7Button";
            this.Theme7Button.Size = new System.Drawing.Size(122, 42);
            this.Theme7Button.TabIndex = 6;
            this.Theme7Button.Text = "Тема7";
            this.Theme7Button.UseVisualStyleBackColor = true;
            this.Theme7Button.Click += new System.EventHandler(this.Theme7Button_Click);
            // 
            // Theme8Button
            // 
            this.Theme8Button.Location = new System.Drawing.Point(150, 207);
            this.Theme8Button.Name = "Theme8Button";
            this.Theme8Button.Size = new System.Drawing.Size(122, 42);
            this.Theme8Button.TabIndex = 7;
            this.Theme8Button.Text = "Тема8";
            this.Theme8Button.UseVisualStyleBackColor = true;
            this.Theme8Button.Click += new System.EventHandler(this.Theme8Button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Выберите 4 темы, чтобы удалить";
            // 
            // NotificationTextBox
            // 
            this.NotificationTextBox.Enabled = false;
            this.NotificationTextBox.Location = new System.Drawing.Point(13, 264);
            this.NotificationTextBox.Name = "NotificationTextBox";
            this.NotificationTextBox.Size = new System.Drawing.Size(259, 20);
            this.NotificationTextBox.TabIndex = 9;
            this.NotificationTextBox.TextChanged += new System.EventHandler(this.NotificationTextBox_TextChanged);
            // 
            // ThemesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 296);
            this.Controls.Add(this.NotificationTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Theme8Button);
            this.Controls.Add(this.Theme7Button);
            this.Controls.Add(this.Theme6Button);
            this.Controls.Add(this.Theme5Button);
            this.Controls.Add(this.Theme4Button);
            this.Controls.Add(this.Theme3Button);
            this.Controls.Add(this.Theme2Button);
            this.Controls.Add(this.Theme1Button);
            this.Name = "ThemesForm";
            this.Text = "Themes";
            this.Load += new System.EventHandler(this.Themes_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Theme1Button;
        private System.Windows.Forms.Button Theme2Button;
        private System.Windows.Forms.Button Theme3Button;
        private System.Windows.Forms.Button Theme4Button;
        private System.Windows.Forms.Button Theme5Button;
        private System.Windows.Forms.Button Theme6Button;
        private System.Windows.Forms.Button Theme7Button;
        private System.Windows.Forms.Button Theme8Button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NotificationTextBox;
    }
}