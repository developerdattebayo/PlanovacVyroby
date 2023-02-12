namespace PlanovacVyroby
{
    partial class UpravMzduForm
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
            this.potvrditNovouMzduButton = new System.Windows.Forms.Button();
            this.novaMzdaNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.novaMzdaNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // potvrditNovouMzduButton
            // 
            this.potvrditNovouMzduButton.Location = new System.Drawing.Point(79, 66);
            this.potvrditNovouMzduButton.Name = "potvrditNovouMzduButton";
            this.potvrditNovouMzduButton.Size = new System.Drawing.Size(143, 23);
            this.potvrditNovouMzduButton.TabIndex = 0;
            this.potvrditNovouMzduButton.Text = "Povrdit novou mzdu";
            this.potvrditNovouMzduButton.UseVisualStyleBackColor = true;
            this.potvrditNovouMzduButton.Click += new System.EventHandler(this.potvrditNovouMzduButton_Click);
            // 
            // novaMzdaNumericUpDown
            // 
            this.novaMzdaNumericUpDown.Location = new System.Drawing.Point(90, 40);
            this.novaMzdaNumericUpDown.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.novaMzdaNumericUpDown.Name = "novaMzdaNumericUpDown";
            this.novaMzdaNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.novaMzdaNumericUpDown.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(95, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Zadej novou mzdu ";
            // 
            // UpravMzduForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(306, 118);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.novaMzdaNumericUpDown);
            this.Controls.Add(this.potvrditNovouMzduButton);
            this.Name = "UpravMzduForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Uprav mzdu";
            ((System.ComponentModel.ISupportInitialize)(this.novaMzdaNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button potvrditNovouMzduButton;
        private System.Windows.Forms.NumericUpDown novaMzdaNumericUpDown;
        private System.Windows.Forms.Label label1;
    }
}