namespace PlanovacVyroby
{
    partial class MainForm
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
            this.zakazkyAktualniDataGrid = new System.Windows.Forms.DataGridView();
            this.NazevZakazkyColum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NazevVykresuCollum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ZbyvaDniCollum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PocetKusuCollum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zamestnanciDataGrid = new System.Windows.Forms.DataGridView();
            this.pridejZamestnanceButton = new System.Windows.Forms.Button();
            this.odeberZamestnanceButton = new System.Windows.Forms.Button();
            this.zamestnanciGroupBox = new System.Windows.Forms.GroupBox();
            this.upravMzduButton = new System.Windows.Forms.Button();
            this.odhlasitZeZakazkyButton = new System.Windows.Forms.Button();
            this.prihlasitNaZakazkuButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.zakazkyGroupBox = new System.Windows.Forms.GroupBox();
            this.zakazkaHotovaButton = new System.Windows.Forms.Button();
            this.odeberZakazkuButton = new System.Windows.Forms.Button();
            this.pridejZakazkuButton = new System.Windows.Forms.Button();
            this.hotoveZakazkyDataGridView = new System.Windows.Forms.DataGridView();
            this.zobrazIntervaOdDoButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.intervalOdDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.intervalDoDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.hledejVykresButton = new System.Windows.Forms.Button();
            this.hledejZakazkuButton = new System.Windows.Forms.Button();
            this.zrusitIntervalFiltrButton = new System.Windows.Forms.Button();
            this.celkemZiskLabel = new System.Windows.Forms.Label();
            this.ziskLabel2 = new System.Windows.Forms.Label();
            this.celkemZakazekLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.pravePracujeListBox = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.zakazkyAktualniDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zamestnanciDataGrid)).BeginInit();
            this.zamestnanciGroupBox.SuspendLayout();
            this.zakazkyGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hotoveZakazkyDataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // zakazkyAktualniDataGrid
            // 
            this.zakazkyAktualniDataGrid.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.zakazkyAktualniDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NazevZakazkyColum,
            this.NazevVykresuCollum,
            this.ZbyvaDniCollum,
            this.PocetKusuCollum});
            this.zakazkyAktualniDataGrid.Location = new System.Drawing.Point(962, 35);
            this.zakazkyAktualniDataGrid.MultiSelect = false;
            this.zakazkyAktualniDataGrid.Name = "zakazkyAktualniDataGrid";
            this.zakazkyAktualniDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.zakazkyAktualniDataGrid.Size = new System.Drawing.Size(913, 851);
            this.zakazkyAktualniDataGrid.TabIndex = 0;
            // 
            // NazevZakazkyColum
            // 
            this.NazevZakazkyColum.DataPropertyName = "NazevZakazky";
            this.NazevZakazkyColum.HeaderText = "Název Zakázky";
            this.NazevZakazkyColum.Name = "NazevZakazkyColum";
            // 
            // NazevVykresuCollum
            // 
            this.NazevVykresuCollum.DataPropertyName = "NazevVykresu";
            this.NazevVykresuCollum.HeaderText = "Název Výkresu";
            this.NazevVykresuCollum.Name = "NazevVykresuCollum";
            // 
            // ZbyvaDniCollum
            // 
            this.ZbyvaDniCollum.DataPropertyName = "ZbyvaDni";
            this.ZbyvaDniCollum.HeaderText = "Zbývá dní";
            this.ZbyvaDniCollum.Name = "ZbyvaDniCollum";
            // 
            // PocetKusuCollum
            // 
            this.PocetKusuCollum.DataPropertyName = "PocetKusu";
            this.PocetKusuCollum.HeaderText = "Počet kusů";
            this.PocetKusuCollum.Name = "PocetKusuCollum";
            // 
            // zamestnanciDataGrid
            // 
            this.zamestnanciDataGrid.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.zamestnanciDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.zamestnanciDataGrid.Location = new System.Drawing.Point(12, 35);
            this.zamestnanciDataGrid.Name = "zamestnanciDataGrid";
            this.zamestnanciDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.zamestnanciDataGrid.Size = new System.Drawing.Size(326, 321);
            this.zamestnanciDataGrid.TabIndex = 1;
            // 
            // pridejZamestnanceButton
            // 
            this.pridejZamestnanceButton.Location = new System.Drawing.Point(6, 19);
            this.pridejZamestnanceButton.Name = "pridejZamestnanceButton";
            this.pridejZamestnanceButton.Size = new System.Drawing.Size(127, 23);
            this.pridejZamestnanceButton.TabIndex = 2;
            this.pridejZamestnanceButton.Text = "Přidej Zaměstnace";
            this.pridejZamestnanceButton.UseVisualStyleBackColor = true;
            this.pridejZamestnanceButton.Click += new System.EventHandler(this.pridejZamestnanceButton_Click);
            // 
            // odeberZamestnanceButton
            // 
            this.odeberZamestnanceButton.Location = new System.Drawing.Point(6, 48);
            this.odeberZamestnanceButton.Name = "odeberZamestnanceButton";
            this.odeberZamestnanceButton.Size = new System.Drawing.Size(127, 23);
            this.odeberZamestnanceButton.TabIndex = 3;
            this.odeberZamestnanceButton.Text = "Odeber Zaměstnance";
            this.odeberZamestnanceButton.UseVisualStyleBackColor = true;
            this.odeberZamestnanceButton.Click += new System.EventHandler(this.odeberZamestnanceButton_Click);
            // 
            // zamestnanciGroupBox
            // 
            this.zamestnanciGroupBox.Controls.Add(this.upravMzduButton);
            this.zamestnanciGroupBox.Controls.Add(this.odhlasitZeZakazkyButton);
            this.zamestnanciGroupBox.Controls.Add(this.prihlasitNaZakazkuButton);
            this.zamestnanciGroupBox.Controls.Add(this.pridejZamestnanceButton);
            this.zamestnanciGroupBox.Controls.Add(this.odeberZamestnanceButton);
            this.zamestnanciGroupBox.Location = new System.Drawing.Point(344, 36);
            this.zamestnanciGroupBox.Name = "zamestnanciGroupBox";
            this.zamestnanciGroupBox.Size = new System.Drawing.Size(139, 321);
            this.zamestnanciGroupBox.TabIndex = 4;
            this.zamestnanciGroupBox.TabStop = false;
            this.zamestnanciGroupBox.Text = "Obsluha Zaměstnanců";
            // 
            // upravMzduButton
            // 
            this.upravMzduButton.Location = new System.Drawing.Point(6, 137);
            this.upravMzduButton.Name = "upravMzduButton";
            this.upravMzduButton.Size = new System.Drawing.Size(126, 23);
            this.upravMzduButton.TabIndex = 6;
            this.upravMzduButton.Text = "Upravit Mzdu";
            this.upravMzduButton.UseVisualStyleBackColor = true;
            this.upravMzduButton.Click += new System.EventHandler(this.upravMzduButton_Click);
            // 
            // odhlasitZeZakazkyButton
            // 
            this.odhlasitZeZakazkyButton.Location = new System.Drawing.Point(7, 108);
            this.odhlasitZeZakazkyButton.Name = "odhlasitZeZakazkyButton";
            this.odhlasitZeZakazkyButton.Size = new System.Drawing.Size(126, 23);
            this.odhlasitZeZakazkyButton.TabIndex = 5;
            this.odhlasitZeZakazkyButton.Text = "Odhlásit ze Zakázky";
            this.odhlasitZeZakazkyButton.UseVisualStyleBackColor = true;
            this.odhlasitZeZakazkyButton.Click += new System.EventHandler(this.odhlasitZeZakazkyButton_Click);
            // 
            // prihlasitNaZakazkuButton
            // 
            this.prihlasitNaZakazkuButton.Location = new System.Drawing.Point(6, 78);
            this.prihlasitNaZakazkuButton.Name = "prihlasitNaZakazkuButton";
            this.prihlasitNaZakazkuButton.Size = new System.Drawing.Size(127, 23);
            this.prihlasitNaZakazkuButton.TabIndex = 4;
            this.prihlasitNaZakazkuButton.Text = "Příhlásit na Zakázku";
            this.prihlasitNaZakazkuButton.UseVisualStyleBackColor = true;
            this.prihlasitNaZakazkuButton.Click += new System.EventHandler(this.prihlasitNaZakazkuButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(959, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Aktuální Zakázky";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(12, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Zaměstnanci";
            // 
            // zakazkyGroupBox
            // 
            this.zakazkyGroupBox.Controls.Add(this.zakazkaHotovaButton);
            this.zakazkyGroupBox.Controls.Add(this.odeberZakazkuButton);
            this.zakazkyGroupBox.Controls.Add(this.pridejZakazkuButton);
            this.zakazkyGroupBox.Location = new System.Drawing.Point(816, 36);
            this.zakazkyGroupBox.Name = "zakazkyGroupBox";
            this.zakazkyGroupBox.Size = new System.Drawing.Size(140, 321);
            this.zakazkyGroupBox.TabIndex = 7;
            this.zakazkyGroupBox.TabStop = false;
            this.zakazkyGroupBox.Text = "Obsluha Zakázek";
            // 
            // zakazkaHotovaButton
            // 
            this.zakazkaHotovaButton.Location = new System.Drawing.Point(7, 79);
            this.zakazkaHotovaButton.Name = "zakazkaHotovaButton";
            this.zakazkaHotovaButton.Size = new System.Drawing.Size(126, 23);
            this.zakazkaHotovaButton.TabIndex = 2;
            this.zakazkaHotovaButton.Text = "Zakázka Hotová";
            this.zakazkaHotovaButton.UseVisualStyleBackColor = true;
            this.zakazkaHotovaButton.Click += new System.EventHandler(this.zakazkaHotovaButton_Click);
            // 
            // odeberZakazkuButton
            // 
            this.odeberZakazkuButton.Location = new System.Drawing.Point(7, 49);
            this.odeberZakazkuButton.Name = "odeberZakazkuButton";
            this.odeberZakazkuButton.Size = new System.Drawing.Size(126, 23);
            this.odeberZakazkuButton.TabIndex = 1;
            this.odeberZakazkuButton.Text = "Odeber Zakázku";
            this.odeberZakazkuButton.UseVisualStyleBackColor = true;
            this.odeberZakazkuButton.Click += new System.EventHandler(this.odeberZakazkuButton_Click);
            // 
            // pridejZakazkuButton
            // 
            this.pridejZakazkuButton.Location = new System.Drawing.Point(6, 19);
            this.pridejZakazkuButton.Name = "pridejZakazkuButton";
            this.pridejZakazkuButton.Size = new System.Drawing.Size(127, 23);
            this.pridejZakazkuButton.TabIndex = 0;
            this.pridejZakazkuButton.Text = "Přidej Zakázku";
            this.pridejZakazkuButton.UseVisualStyleBackColor = true;
            this.pridejZakazkuButton.Click += new System.EventHandler(this.pridejZakazkuButton_Click);
            // 
            // hotoveZakazkyDataGridView
            // 
            this.hotoveZakazkyDataGridView.AllowUserToDeleteRows = false;
            this.hotoveZakazkyDataGridView.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.hotoveZakazkyDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.hotoveZakazkyDataGridView.Location = new System.Drawing.Point(9, 85);
            this.hotoveZakazkyDataGridView.Name = "hotoveZakazkyDataGridView";
            this.hotoveZakazkyDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.hotoveZakazkyDataGridView.Size = new System.Drawing.Size(928, 432);
            this.hotoveZakazkyDataGridView.TabIndex = 8;
            // 
            // zobrazIntervaOdDoButton
            // 
            this.zobrazIntervaOdDoButton.Location = new System.Drawing.Point(472, 28);
            this.zobrazIntervaOdDoButton.Name = "zobrazIntervaOdDoButton";
            this.zobrazIntervaOdDoButton.Size = new System.Drawing.Size(122, 23);
            this.zobrazIntervaOdDoButton.TabIndex = 9;
            this.zobrazIntervaOdDoButton.Text = "Zobraz interval";
            this.zobrazIntervaOdDoButton.UseVisualStyleBackColor = true;
            this.zobrazIntervaOdDoButton.Click += new System.EventHandler(this.zobrazIntervaOdDoButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Od";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(239, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Do";
            // 
            // intervalOdDateTimePicker
            // 
            this.intervalOdDateTimePicker.Location = new System.Drawing.Point(33, 29);
            this.intervalOdDateTimePicker.Name = "intervalOdDateTimePicker";
            this.intervalOdDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.intervalOdDateTimePicker.TabIndex = 12;
            // 
            // intervalDoDateTimePicker
            // 
            this.intervalDoDateTimePicker.Location = new System.Drawing.Point(266, 29);
            this.intervalDoDateTimePicker.Name = "intervalDoDateTimePicker";
            this.intervalDoDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.intervalDoDateTimePicker.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(6, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 17);
            this.label5.TabIndex = 14;
            this.label5.Text = "Hotové Zakázky";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.hledejVykresButton);
            this.groupBox1.Controls.Add(this.hledejZakazkuButton);
            this.groupBox1.Controls.Add(this.zrusitIntervalFiltrButton);
            this.groupBox1.Controls.Add(this.celkemZiskLabel);
            this.groupBox1.Controls.Add(this.ziskLabel2);
            this.groupBox1.Controls.Add(this.celkemZakazekLabel);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.intervalOdDateTimePicker);
            this.groupBox1.Controls.Add(this.hotoveZakazkyDataGridView);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.zobrazIntervaOdDoButton);
            this.groupBox1.Controls.Add(this.intervalDoDateTimePicker);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(12, 361);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(944, 525);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Obsluha Dokončených Zakázek";
            // 
            // hledejVykresButton
            // 
            this.hledejVykresButton.Location = new System.Drawing.Point(728, 26);
            this.hledejVykresButton.Name = "hledejVykresButton";
            this.hledejVykresButton.Size = new System.Drawing.Size(122, 23);
            this.hledejVykresButton.TabIndex = 21;
            this.hledejVykresButton.Text = "Hledej výkres";
            this.hledejVykresButton.UseVisualStyleBackColor = true;
            this.hledejVykresButton.Click += new System.EventHandler(this.hledejVykresButton_Click);
            // 
            // hledejZakazkuButton
            // 
            this.hledejZakazkuButton.Location = new System.Drawing.Point(728, 53);
            this.hledejZakazkuButton.Name = "hledejZakazkuButton";
            this.hledejZakazkuButton.Size = new System.Drawing.Size(122, 23);
            this.hledejZakazkuButton.TabIndex = 20;
            this.hledejZakazkuButton.Text = "Hledej zakázku";
            this.hledejZakazkuButton.UseVisualStyleBackColor = true;
            this.hledejZakazkuButton.Click += new System.EventHandler(this.hledejZakazkuButton_Click);
            // 
            // zrusitIntervalFiltrButton
            // 
            this.zrusitIntervalFiltrButton.Location = new System.Drawing.Point(600, 27);
            this.zrusitIntervalFiltrButton.Name = "zrusitIntervalFiltrButton";
            this.zrusitIntervalFiltrButton.Size = new System.Drawing.Size(122, 23);
            this.zrusitIntervalFiltrButton.TabIndex = 19;
            this.zrusitIntervalFiltrButton.Text = "Zrušit Filtr";
            this.zrusitIntervalFiltrButton.UseVisualStyleBackColor = true;
            this.zrusitIntervalFiltrButton.Click += new System.EventHandler(this.zrusitIntervalFiltrButton_Click);
            // 
            // celkemZiskLabel
            // 
            this.celkemZiskLabel.AutoSize = true;
            this.celkemZiskLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.celkemZiskLabel.Location = new System.Drawing.Point(332, 63);
            this.celkemZiskLabel.Name = "celkemZiskLabel";
            this.celkemZiskLabel.Size = new System.Drawing.Size(14, 13);
            this.celkemZiskLabel.TabIndex = 18;
            this.celkemZiskLabel.Text = "0";
            // 
            // ziskLabel2
            // 
            this.ziskLabel2.AutoSize = true;
            this.ziskLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ziskLabel2.Location = new System.Drawing.Point(296, 63);
            this.ziskLabel2.Name = "ziskLabel2";
            this.ziskLabel2.Size = new System.Drawing.Size(30, 13);
            this.ziskLabel2.TabIndex = 17;
            this.ziskLabel2.Text = "Zisk:";
            // 
            // celkemZakazekLabel
            // 
            this.celkemZakazekLabel.AutoSize = true;
            this.celkemZakazekLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.celkemZakazekLabel.Location = new System.Drawing.Point(239, 63);
            this.celkemZakazekLabel.Name = "celkemZakazekLabel";
            this.celkemZakazekLabel.Size = new System.Drawing.Size(14, 13);
            this.celkemZakazekLabel.TabIndex = 16;
            this.celkemZakazekLabel.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(146, 63);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Celkem Zakázek:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(486, 19);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Právě pracuje";
            // 
            // pravePracujeListBox
            // 
            this.pravePracujeListBox.FormattingEnabled = true;
            this.pravePracujeListBox.HorizontalScrollbar = true;
            this.pravePracujeListBox.Location = new System.Drawing.Point(489, 41);
            this.pravePracujeListBox.Name = "pravePracujeListBox";
            this.pravePracujeListBox.Size = new System.Drawing.Size(321, 316);
            this.pravePracujeListBox.TabIndex = 17;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1882, 898);
            this.Controls.Add(this.pravePracujeListBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.zakazkyGroupBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.zamestnanciGroupBox);
            this.Controls.Add(this.zamestnanciDataGrid);
            this.Controls.Add(this.zakazkyAktualniDataGrid);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Plánovač Výroby";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.zakazkyAktualniDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zamestnanciDataGrid)).EndInit();
            this.zamestnanciGroupBox.ResumeLayout(false);
            this.zakazkyGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.hotoveZakazkyDataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView zakazkyAktualniDataGrid;
        private System.Windows.Forms.DataGridView zamestnanciDataGrid;
        private System.Windows.Forms.Button pridejZamestnanceButton;
        private System.Windows.Forms.Button odeberZamestnanceButton;
        private System.Windows.Forms.GroupBox zamestnanciGroupBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox zakazkyGroupBox;
        private System.Windows.Forms.Button zakazkaHotovaButton;
        private System.Windows.Forms.Button odeberZakazkuButton;
        private System.Windows.Forms.Button pridejZakazkuButton;
        private System.Windows.Forms.DataGridView hotoveZakazkyDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn NazevZakazkyColum;
        private System.Windows.Forms.DataGridViewTextBoxColumn NazevVykresuCollum;
        private System.Windows.Forms.DataGridViewTextBoxColumn ZbyvaDniCollum;
        private System.Windows.Forms.DataGridViewTextBoxColumn PocetKusuCollum;
        private System.Windows.Forms.Button odhlasitZeZakazkyButton;
        private System.Windows.Forms.Button prihlasitNaZakazkuButton;
        private System.Windows.Forms.Button zobrazIntervaOdDoButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker intervalOdDateTimePicker;
        private System.Windows.Forms.DateTimePicker intervalDoDateTimePicker;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label celkemZiskLabel;
        private System.Windows.Forms.Label ziskLabel2;
        private System.Windows.Forms.Label celkemZakazekLabel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button zrusitIntervalFiltrButton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox pravePracujeListBox;
        private System.Windows.Forms.Button hledejVykresButton;
        private System.Windows.Forms.Button hledejZakazkuButton;
        private System.Windows.Forms.Button upravMzduButton;
    }
}

