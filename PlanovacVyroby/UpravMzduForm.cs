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
    public partial class UpravMzduForm : Form
    {
        private Evidence evidence;
        private Zamestnanec zamestnanec;
        public UpravMzduForm(Evidence evidence,Zamestnanec zamestnanec)
        {
            InitializeComponent();
            this.evidence = evidence;
            this.zamestnanec = zamestnanec;
        }
        private void potvrditNovouMzduButton_Click(object sender, EventArgs e)
        {
            try
            {
                evidence.UpravMzduNaHodinu(zamestnanec,novaMzdaNumericUpDown.Value);
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Chyba",MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
