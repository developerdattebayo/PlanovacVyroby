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
    public partial class PridejZamestnanceForm : Form
    {
        Evidence evidence;
        public PridejZamestnanceForm(Evidence evidence)
        {
            InitializeComponent();
            this.evidence = evidence;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                evidence.PridejZamestnance(zamestnanecJmenoTextBox.Text, zamestnanecPrijmeniTextBox.Text, zamestnanecDatumNarozeniDateTimePicker.Value, zamestnanecMzdaNumericUpDown.Value);
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
