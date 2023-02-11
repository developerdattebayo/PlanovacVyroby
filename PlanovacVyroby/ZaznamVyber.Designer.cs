namespace PlanovacVyroby
{
    partial class ZaznamVyber
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
            this.infoTextBox = new System.Windows.Forms.TextBox();
            this.infoLabel = new System.Windows.Forms.Label();
            this.vyhledatButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // infoTextBox
            // 
            this.infoTextBox.Location = new System.Drawing.Point(12, 25);
            this.infoTextBox.Name = "infoTextBox";
            this.infoTextBox.Size = new System.Drawing.Size(272, 20);
            this.infoTextBox.TabIndex = 0;
            // 
            // infoLabel
            // 
            this.infoLabel.AutoSize = true;
            this.infoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.infoLabel.Location = new System.Drawing.Point(12, 9);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(127, 13);
            this.infoLabel.TabIndex = 1;
            this.infoLabel.Text = "Zadej název zakázky";
            // 
            // vyhledatButton
            // 
            this.vyhledatButton.Location = new System.Drawing.Point(88, 51);
            this.vyhledatButton.Name = "vyhledatButton";
            this.vyhledatButton.Size = new System.Drawing.Size(117, 23);
            this.vyhledatButton.TabIndex = 2;
            this.vyhledatButton.Text = "Vyhledat Zakázky";
            this.vyhledatButton.UseVisualStyleBackColor = true;
            this.vyhledatButton.Click += new System.EventHandler(this.vyhledatButton_Click);
            // 
            // ZaznamVyber
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(296, 80);
            this.Controls.Add(this.vyhledatButton);
            this.Controls.Add(this.infoLabel);
            this.Controls.Add(this.infoTextBox);
            this.Name = "ZaznamVyber";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ZaznamVyber";
            this.Load += new System.EventHandler(this.ZaznamVyber_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox infoTextBox;
        private System.Windows.Forms.Label infoLabel;
        private System.Windows.Forms.Button vyhledatButton;
    }
}