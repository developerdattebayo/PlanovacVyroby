using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlanovacVyroby
{
    public partial class PridejZakazkuForm : Form
    {
        public Evidence evidence;
        
        public PridejZakazkuForm(Evidence evidence)
        {
            InitializeComponent();
            this.evidence = evidence;
        }

        private void pridejZakazkuButton_Click(object sender, EventArgs e)
        {
            try
            {
                evidence.PridejZakazku(nazevVykresuTextBox.Text,nazevZakazkyTextBox.Text,cenaZaKusNumericUpDown.Value,(int)pocetKusuNumericUpDown.Value,datumDodaniDateTimePicker.Value,nakladyNaMaterialNumericUpDown.Value);
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
