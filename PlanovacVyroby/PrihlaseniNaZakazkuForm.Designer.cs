namespace PlanovacVyroby
{
    partial class PrihlaseniNaZakazkuForm
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
            this.prihlaseniNaZakazkuDataGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.prihlasitNaZakazkuButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.prihlaseniNaZakazkuDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // prihlaseniNaZakazkuDataGridView
            // 
            this.prihlaseniNaZakazkuDataGridView.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.prihlaseniNaZakazkuDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.prihlaseniNaZakazkuDataGridView.Location = new System.Drawing.Point(12, 32);
            this.prihlaseniNaZakazkuDataGridView.Name = "prihlaseniNaZakazkuDataGridView";
            this.prihlaseniNaZakazkuDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.prihlaseniNaZakazkuDataGridView.Size = new System.Drawing.Size(628, 370);
            this.prihlaseniNaZakazkuDataGridView.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(233, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Vyber zakázku na které budeš pracovat";
            // 
            // prihlasitNaZakazkuButton
            // 
            this.prihlasitNaZakazkuButton.Location = new System.Drawing.Point(198, 408);
            this.prihlasitNaZakazkuButton.Name = "prihlasitNaZakazkuButton";
            this.prihlasitNaZakazkuButton.Size = new System.Drawing.Size(248, 42);
            this.prihlasitNaZakazkuButton.TabIndex = 2;
            this.prihlasitNaZakazkuButton.Text = "Přihlásit";
            this.prihlasitNaZakazkuButton.UseVisualStyleBackColor = true;
            this.prihlasitNaZakazkuButton.Click += new System.EventHandler(this.prihlasitNaZakazkuButton_Click);
            // 
            // PrihlaseniNaZakazkuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 455);
            this.Controls.Add(this.prihlasitNaZakazkuButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.prihlaseniNaZakazkuDataGridView);
            this.Name = "PrihlaseniNaZakazkuForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Přihlášení na zakázku";
            ((System.ComponentModel.ISupportInitialize)(this.prihlaseniNaZakazkuDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView prihlaseniNaZakazkuDataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button prihlasitNaZakazkuButton;
    }
}