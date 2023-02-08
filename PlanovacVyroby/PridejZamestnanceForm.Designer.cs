namespace PlanovacVyroby
{
    partial class PridejZamestnanceForm
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
            this.zamestnanecJmenoTextBox = new System.Windows.Forms.TextBox();
            this.zamestnanecPrijmeniTextBox = new System.Windows.Forms.TextBox();
            this.zamestnanecDatumNarozeniDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.zamestnanecMzdaNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.zamestnanecMzdaNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // zamestnanecJmenoTextBox
            // 
            this.zamestnanecJmenoTextBox.Location = new System.Drawing.Point(15, 70);
            this.zamestnanecJmenoTextBox.Name = "zamestnanecJmenoTextBox";
            this.zamestnanecJmenoTextBox.Size = new System.Drawing.Size(200, 20);
            this.zamestnanecJmenoTextBox.TabIndex = 0;
            // 
            // zamestnanecPrijmeniTextBox
            // 
            this.zamestnanecPrijmeniTextBox.Location = new System.Drawing.Point(15, 25);
            this.zamestnanecPrijmeniTextBox.Name = "zamestnanecPrijmeniTextBox";
            this.zamestnanecPrijmeniTextBox.Size = new System.Drawing.Size(200, 20);
            this.zamestnanecPrijmeniTextBox.TabIndex = 1;
            // 
            // zamestnanecDatumNarozeniDateTimePicker
            // 
            this.zamestnanecDatumNarozeniDateTimePicker.Location = new System.Drawing.Point(15, 118);
            this.zamestnanecDatumNarozeniDateTimePicker.Name = "zamestnanecDatumNarozeniDateTimePicker";
            this.zamestnanecDatumNarozeniDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.zamestnanecDatumNarozeniDateTimePicker.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(229, 70);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 68);
            this.button1.TabIndex = 3;
            this.button1.Text = "Přídej Zaměstnance";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Datum Narození";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Jméno Zaměstnance";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Příjmení Zaměstnance";
            // 
            // zamestnanecMzdaNumericUpDown
            // 
            this.zamestnanecMzdaNumericUpDown.Location = new System.Drawing.Point(229, 25);
            this.zamestnanecMzdaNumericUpDown.Name = "zamestnanecMzdaNumericUpDown";
            this.zamestnanecMzdaNumericUpDown.Size = new System.Drawing.Size(115, 20);
            this.zamestnanecMzdaNumericUpDown.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(226, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Mzda na hodinu";
            // 
            // PridejZamestnanceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 152);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.zamestnanecMzdaNumericUpDown);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.zamestnanecDatumNarozeniDateTimePicker);
            this.Controls.Add(this.zamestnanecPrijmeniTextBox);
            this.Controls.Add(this.zamestnanecJmenoTextBox);
            this.Name = "PridejZamestnanceForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Přidej Zaměstnance";
            ((System.ComponentModel.ISupportInitialize)(this.zamestnanecMzdaNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox zamestnanecJmenoTextBox;
        private System.Windows.Forms.TextBox zamestnanecPrijmeniTextBox;
        private System.Windows.Forms.DateTimePicker zamestnanecDatumNarozeniDateTimePicker;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown zamestnanecMzdaNumericUpDown;
        private System.Windows.Forms.Label label4;
    }
}