namespace Client
{
    partial class StartForm
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
            this.StartGameButton = new System.Windows.Forms.Button();
            this.RatingTableButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // StartGameButton
            // 
            this.StartGameButton.Location = new System.Drawing.Point(13, 13);
            this.StartGameButton.Name = "StartGameButton";
            this.StartGameButton.Size = new System.Drawing.Size(259, 42);
            this.StartGameButton.TabIndex = 0;
            this.StartGameButton.Text = "Начать игру";
            this.StartGameButton.UseVisualStyleBackColor = true;
            this.StartGameButton.Click += new System.EventHandler(this.StartGameButton_Click);
            // 
            // RatingTableButton
            // 
            this.RatingTableButton.Location = new System.Drawing.Point(13, 79);
            this.RatingTableButton.Name = "RatingTableButton";
            this.RatingTableButton.Size = new System.Drawing.Size(259, 44);
            this.RatingTableButton.TabIndex = 1;
            this.RatingTableButton.Text = "Таблица результатов";
            this.RatingTableButton.UseVisualStyleBackColor = true;
            this.RatingTableButton.Click += new System.EventHandler(this.RatingTableButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(13, 145);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(259, 47);
            this.ExitButton.TabIndex = 2;
            this.ExitButton.Text = "Выход";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.RatingTableButton);
            this.Controls.Add(this.StartGameButton);
            this.Name = "StartForm";
            this.Text = "StartForm";
            this.Load += new System.EventHandler(this.StartForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button StartGameButton;
        private System.Windows.Forms.Button RatingTableButton;
        private System.Windows.Forms.Button ExitButton;
    }
}