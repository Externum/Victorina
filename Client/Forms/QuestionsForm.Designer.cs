namespace Client
{
    partial class QuestionsForm
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
            this.QuestionTextBox = new System.Windows.Forms.RichTextBox();
            this.Answer1Button = new System.Windows.Forms.Button();
            this.Answer2Button = new System.Windows.Forms.Button();
            this.Answer3Button = new System.Windows.Forms.Button();
            this.Answer4Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // QuestionTextBox
            // 
            this.QuestionTextBox.Enabled = false;
            this.QuestionTextBox.Location = new System.Drawing.Point(12, 12);
            this.QuestionTextBox.Name = "QuestionTextBox";
            this.QuestionTextBox.Size = new System.Drawing.Size(398, 156);
            this.QuestionTextBox.TabIndex = 0;
            this.QuestionTextBox.Text = "";
            this.QuestionTextBox.TextChanged += new System.EventHandler(this.QuestionTextBox_TextChanged);
            // 
            // Answer1Button
            // 
            this.Answer1Button.Location = new System.Drawing.Point(13, 175);
            this.Answer1Button.Name = "Answer1Button";
            this.Answer1Button.Size = new System.Drawing.Size(191, 44);
            this.Answer1Button.TabIndex = 1;
            this.Answer1Button.Text = "Ответ1";
            this.Answer1Button.UseVisualStyleBackColor = true;
            this.Answer1Button.Click += new System.EventHandler(this.Answer1Button_Click);
            // 
            // Answer2Button
            // 
            this.Answer2Button.Location = new System.Drawing.Point(219, 175);
            this.Answer2Button.Name = "Answer2Button";
            this.Answer2Button.Size = new System.Drawing.Size(191, 44);
            this.Answer2Button.TabIndex = 2;
            this.Answer2Button.Text = "Ответ2";
            this.Answer2Button.UseVisualStyleBackColor = true;
            this.Answer2Button.Click += new System.EventHandler(this.Answer2Button_Click);
            // 
            // Answer3Button
            // 
            this.Answer3Button.Location = new System.Drawing.Point(13, 225);
            this.Answer3Button.Name = "Answer3Button";
            this.Answer3Button.Size = new System.Drawing.Size(191, 44);
            this.Answer3Button.TabIndex = 3;
            this.Answer3Button.Text = "Ответ3";
            this.Answer3Button.UseVisualStyleBackColor = true;
            this.Answer3Button.Click += new System.EventHandler(this.Answer3Button_Click);
            // 
            // Answer4Button
            // 
            this.Answer4Button.Location = new System.Drawing.Point(219, 226);
            this.Answer4Button.Name = "Answer4Button";
            this.Answer4Button.Size = new System.Drawing.Size(191, 43);
            this.Answer4Button.TabIndex = 4;
            this.Answer4Button.Text = "Ответ4";
            this.Answer4Button.UseVisualStyleBackColor = true;
            this.Answer4Button.Click += new System.EventHandler(this.Answer4Button_Click);
            // 
            // QuestionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 334);
            this.Controls.Add(this.Answer4Button);
            this.Controls.Add(this.Answer3Button);
            this.Controls.Add(this.Answer2Button);
            this.Controls.Add(this.Answer1Button);
            this.Controls.Add(this.QuestionTextBox);
            this.Name = "QuestionsForm";
            this.Text = "QuestionsForm";
            this.Load += new System.EventHandler(this.QuestionsForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox QuestionTextBox;
        private System.Windows.Forms.Button Answer1Button;
        private System.Windows.Forms.Button Answer2Button;
        private System.Windows.Forms.Button Answer3Button;
        private System.Windows.Forms.Button Answer4Button;
    }
}