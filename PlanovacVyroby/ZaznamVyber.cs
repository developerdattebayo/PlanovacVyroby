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
    public partial class ZaznamVyber : Form
    {
        private Evidence evidence;
        private string coHledam;
        public ZaznamVyber(Evidence evidence,string coHledam)
        {
            InitializeComponent();
            this.evidence = evidence;
            this.coHledam = coHledam;
            if (coHledam == "vykres")
            {
                infoLabel.Text = "Zadej název výkresu";
                vyhledatButton.Text = "Vyhledat výkresy";
            }
  
        }

        private void ZaznamVyber_Load(object sender, EventArgs e)
        {

        }

        private void vyhledatButton_Click(object sender, EventArgs e)
        {
            try
            {
                if(coHledam == "vykres")
                    evidence.FiltrovaneZakazky = evidence.ZobrazCisloVykresu(infoTextBox.Text);
                else
                    evidence.FiltrovaneZakazky = evidence.ZobrazCisloZakazky(infoTextBox.Text);
                Close();
            }
            catch (Exception x)
            {

                MessageBox.Show(x.Message,"Chyba",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
    }
}
