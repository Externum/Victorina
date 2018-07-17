namespace Client
{
    partial class GameResultsForm
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
            this.ContinueButton = new System.Windows.Forms.Button();
            this.ResultsListBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.WrightResultsTextBox = new System.Windows.Forms.TextBox();
            this.WrongResultsTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ContinueButton
            // 
            this.ContinueButton.Location = new System.Drawing.Point(13, 310);
            this.ContinueButton.Name = "ContinueButton";
            this.ContinueButton.Size = new System.Drawing.Size(259, 23);
            this.ContinueButton.TabIndex = 0;
            this.ContinueButton.Text = "Завершить";
            this.ContinueButton.UseVisualStyleBackColor = true;
            this.ContinueButton.Click += new System.EventHandler(this.ContinueButton_Click);
            // 
            // ResultsListBox
            // 
            this.ResultsListBox.FormattingEnabled = true;
            this.ResultsListBox.Location = new System.Drawing.Point(13, 13);
            this.ResultsListBox.Name = "ResultsListBox";
            this.ResultsListBox.Size = new System.Drawing.Size(259, 251);
            this.ResultsListBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 271);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Верных ответов:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(144, 271);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Не верных ответов:";
            // 
            // WrightResultsTextBox
            // 
            this.WrightResultsTextBox.Enabled = false;
            this.WrightResultsTextBox.Location = new System.Drawing.Point(16, 284);
            this.WrightResultsTextBox.Name = "WrightResultsTextBox";
            this.WrightResultsTextBox.Size = new System.Drawing.Size(122, 20);
            this.WrightResultsTextBox.TabIndex = 4;
            // 
            // WrongResultsTextBox
            // 
            this.WrongResultsTextBox.Enabled = false;
            this.WrongResultsTextBox.Location = new System.Drawing.Point(144, 284);
            this.WrongResultsTextBox.Name = "WrongResultsTextBox";
            this.WrongResultsTextBox.Size = new System.Drawing.Size(126, 20);
            this.WrongResultsTextBox.TabIndex = 5;
            // 
            // GameResultsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 345);
            this.Controls.Add(this.WrongResultsTextBox);
            this.Controls.Add(this.WrightResultsTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ResultsListBox);
            this.Controls.Add(this.ContinueButton);
            this.Name = "GameResultsForm";
            this.Text = "GameResultsForm";
            this.Load += new System.EventHandler(this.GameResultsForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ContinueButton;
        private System.Windows.Forms.ListBox ResultsListBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox WrightResultsTextBox;
        private System.Windows.Forms.TextBox WrongResultsTextBox;
    }
}