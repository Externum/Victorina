namespace Client
{
    partial class AllResultsForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.ResultsTextBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // ContinueButton
            // 
            this.ContinueButton.Location = new System.Drawing.Point(13, 288);
            this.ContinueButton.Name = "ContinueButton";
            this.ContinueButton.Size = new System.Drawing.Size(259, 23);
            this.ContinueButton.TabIndex = 1;
            this.ContinueButton.Text = "Завершить";
            this.ContinueButton.UseVisualStyleBackColor = true;
            this.ContinueButton.Click += new System.EventHandler(this.ContinueButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Игрок          Посл. рез-т      Сыграно игр";
            // 
            // ResultsTextBox
            // 
            this.ResultsTextBox.Enabled = false;
            this.ResultsTextBox.Location = new System.Drawing.Point(13, 27);
            this.ResultsTextBox.Name = "ResultsTextBox";
            this.ResultsTextBox.Size = new System.Drawing.Size(256, 245);
            this.ResultsTextBox.TabIndex = 2;
            this.ResultsTextBox.Text = "";
            // 
            // AllResultsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 323);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ResultsTextBox);
            this.Controls.Add(this.ContinueButton);
            this.Name = "AllResultsForm";
            this.Text = "AllResultsForm";
            this.Load += new System.EventHandler(this.AllResultsForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button ContinueButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox ResultsTextBox;
    }
}