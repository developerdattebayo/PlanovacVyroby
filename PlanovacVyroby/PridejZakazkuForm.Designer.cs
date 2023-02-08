namespace PlanovacVyroby
{
    partial class PridejZakazkuForm
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
            this.nazevZakazkyTextBox = new System.Windows.Forms.TextBox();
            this.nazevVykresuTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pocetKusuNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.pridejZakazkuButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cenaZaKusNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.Label = new System.Windows.Forms.Label();
            this.datumDodaniDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.nakladyNaMaterialNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pocetKusuNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cenaZaKusNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nakladyNaMaterialNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // nazevZakazkyTextBox
            // 
            this.nazevZakazkyTextBox.Location = new System.Drawing.Point(12, 25);
            this.nazevZakazkyTextBox.Name = "nazevZakazkyTextBox";
            this.nazevZakazkyTextBox.Size = new System.Drawing.Size(223, 20);
            this.nazevZakazkyTextBox.TabIndex = 0;
            // 
            // nazevVykresuTextBox
            // 
            this.nazevVykresuTextBox.Location = new System.Drawing.Point(12, 73);
            this.nazevVykresuTextBox.Name = "nazevVykresuTextBox";
            this.nazevVykresuTextBox.Size = new System.Drawing.Size(223, 20);
            this.nazevVykresuTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Název Zakázky";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Název Výkresu";
            // 
            // pocetKusuNumericUpDown
            // 
            this.pocetKusuNumericUpDown.Location = new System.Drawing.Point(309, 26);
            this.pocetKusuNumericUpDown.Name = "pocetKusuNumericUpDown";
            this.pocetKusuNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.pocetKusuNumericUpDown.TabIndex = 4;
            // 
            // pridejZakazkuButton
            // 
            this.pridejZakazkuButton.Location = new System.Drawing.Point(301, 167);
            this.pridejZakazkuButton.Name = "pridejZakazkuButton";
            this.pridejZakazkuButton.Size = new System.Drawing.Size(128, 39);
            this.pridejZakazkuButton.TabIndex = 5;
            this.pridejZakazkuButton.Text = "Přidej Zakázku";
            this.pridejZakazkuButton.UseVisualStyleBackColor = true;
            this.pridejZakazkuButton.Click += new System.EventHandler(this.pridejZakazkuButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(306, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Počet Kusů";
            // 
            // cenaZaKusNumericUpDown
            // 
            this.cenaZaKusNumericUpDown.DecimalPlaces = 2;
            this.cenaZaKusNumericUpDown.Location = new System.Drawing.Point(309, 75);
            this.cenaZaKusNumericUpDown.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.cenaZaKusNumericUpDown.Name = "cenaZaKusNumericUpDown";
            this.cenaZaKusNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.cenaZaKusNumericUpDown.TabIndex = 7;
            // 
            // Label
            // 
            this.Label.AutoSize = true;
            this.Label.Location = new System.Drawing.Point(306, 59);
            this.Label.Name = "Label";
            this.Label.Size = new System.Drawing.Size(67, 13);
            this.Label.TabIndex = 8;
            this.Label.Text = "Cena za Kus";
            // 
            // datumDodaniDateTimePicker
            // 
            this.datumDodaniDateTimePicker.Location = new System.Drawing.Point(12, 124);
            this.datumDodaniDateTimePicker.Name = "datumDodaniDateTimePicker";
            this.datumDodaniDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.datumDodaniDateTimePicker.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Datum Dodání";
            // 
            // nakladyNaMaterialNumericUpDown
            // 
            this.nakladyNaMaterialNumericUpDown.DecimalPlaces = 2;
            this.nakladyNaMaterialNumericUpDown.Location = new System.Drawing.Point(309, 124);
            this.nakladyNaMaterialNumericUpDown.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.nakladyNaMaterialNumericUpDown.Name = "nakladyNaMaterialNumericUpDown";
            this.nakladyNaMaterialNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.nakladyNaMaterialNumericUpDown.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(306, 108);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Náklady na materiál";
            // 
            // PridejZakazkuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 218);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.nakladyNaMaterialNumericUpDown);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.datumDodaniDateTimePicker);
            this.Controls.Add(this.Label);
            this.Controls.Add(this.cenaZaKusNumericUpDown);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pridejZakazkuButton);
            this.Controls.Add(this.pocetKusuNumericUpDown);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nazevVykresuTextBox);
            this.Controls.Add(this.nazevZakazkyTextBox);
            this.Name = "PridejZakazkuForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Přidej Zakázku";
            ((System.ComponentModel.ISupportInitialize)(this.pocetKusuNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cenaZaKusNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nakladyNaMaterialNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nazevZakazkyTextBox;
        private System.Windows.Forms.TextBox nazevVykresuTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown pocetKusuNumericUpDown;
        private System.Windows.Forms.Button pridejZakazkuButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown cenaZaKusNumericUpDown;
        private System.Windows.Forms.Label Label;
        private System.Windows.Forms.DateTimePicker datumDodaniDateTimePicker;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nakladyNaMaterialNumericUpDown;
        private System.Windows.Forms.Label label5;
    }
}