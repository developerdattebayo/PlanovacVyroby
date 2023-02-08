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
    public partial class PrihlaseniNaZakazkuForm : Form
    {
        public Zamestnanec zamestananec;
        public Evidence evidence;
        public PrihlaseniNaZakazkuForm(Zamestnanec zamestananec, Evidence evidence)
        {
            InitializeComponent();
            this.zamestananec = zamestananec;
            this.evidence = evidence;
            prihlaseniNaZakazkuDataGridView.DataSource = evidence.EvidenceZakazek;
        }

        private void prihlasitNaZakazkuButton_Click(object sender, EventArgs e)
        {
            if (prihlaseniNaZakazkuDataGridView.Rows.Count > 0)
            {
                DialogResult dr = MessageBox.Show("Povrďte vybranou zakázku", "Potvrzení", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (dr == DialogResult.OK)
                {
                    Zakazka zakazka = (Zakazka)prihlaseniNaZakazkuDataGridView.SelectedRows[0].DataBoundItem;
                    zamestananec.praceNaZakazce = zakazka;
                    MessageBox.Show("Přihlášení proběhlo úspěšně", "Přihlášení", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }          
            }
            Close();
        }
    }
}
