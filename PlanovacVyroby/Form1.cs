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
    public partial class MainForm : Form
    {
        public Evidence evidence;
        public BindingList<Zakazka> intervaloveZakazky; // zobrazí se při fitrování v hotových zakázkách
        public MainForm()
        {
            InitializeComponent();
            evidence = new Evidence();
            evidence.NactiDataZakazek();
            intervaloveZakazky= new BindingList<Zakazka>();          
            //zakazkyAktualniDataGrid.AutoGenerateColumns = false;
            zakazkyAktualniDataGrid.DataSource = evidence.EvidenceZakazek;
            zamestnanciDataGrid.DataSource = evidence.EvidenceZamestnancu;
            hotoveZakazkyDataGridView.DataSource = evidence.EvidenceHotovychZakazek;
        }

        private void pridejZakazkuButton_Click(object sender, EventArgs e)
        {
            PridejZakazkuForm pridejZakazkuForm = new PridejZakazkuForm(evidence);
            pridejZakazkuForm.ShowDialog();
        }

        private void odeberZakazkuButton_Click(object sender, EventArgs e)
        {
            if(zakazkyAktualniDataGrid.SelectedRows.Count > 0)
            {
                Zakazka zakazka = (Zakazka)zakazkyAktualniDataGrid.SelectedRows[0].DataBoundItem;
                DialogResult dr = MessageBox.Show("Opravdu chcete zakázku smazat?", "Potvrzení", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if ((dr == DialogResult.OK) && (!evidence.JeZakazkaRozpracovana(zakazka)))
                {
                    evidence.OdeberZakazku(zakazka);
                }
                else
                    MessageBox.Show("Zakázka je rozdělaná", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void pridejZamestnanceButton_Click(object sender, EventArgs e)
        {
            PridejZamestnanceForm pridejZamestnanceForm = new PridejZamestnanceForm(evidence);
            pridejZamestnanceForm.ShowDialog();
        }
        private void odeberZamestnanceButton_Click(object sender, EventArgs e)
        {
            if (zamestnanciDataGrid.SelectedRows.Count > 0)
            {
                Zamestnanec zamestnanec = (Zamestnanec)zamestnanciDataGrid.SelectedRows[0].DataBoundItem;
                DialogResult dr = MessageBox.Show("Opravdu chcete zaměstnance smazat?", "Potvrzení", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if ((dr == DialogResult.OK) && (zamestnanec.praceNaZakazce == null))
                {
                    evidence.EvidenceZamestnancu.Remove(zamestnanec);
                }
                else
                    MessageBox.Show("Zaměstnanec je přihlášen na zakázce!", "Chyba",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
                
        }
        private void zakazkaHotovaButton_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Opravdu je zakázka hotová?","Potvrzení",MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            
                if ((zakazkyAktualniDataGrid.SelectedRows.Count > 0) && (dr == DialogResult.OK))
                {
                    Zakazka vybranaZakazka = (Zakazka)zakazkyAktualniDataGrid.SelectedRows[0].DataBoundItem;
                    if(!evidence.JeZakazkaRozpracovana(vybranaZakazka)) //Evidence zkontroluje kolekci zamestnancu jestli nema nekdo referenci na zakazku
                    { 
                        vybranaZakazka.DatumDokonceni = DateTime.Today;
                        evidence.EvidenceHotovychZakazek.Add(vybranaZakazka);
                        evidence.EvidenceZakazek.Remove(vybranaZakazka);
                    }
                    else
                        MessageBox.Show("Zakázka je rozpracovaná, nelze odhlásit","Chyba",MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            
        }

        private void zobrazIntervaOdDoButton_Click(object sender, EventArgs e)
        {
            intervaloveZakazky = null;
                try
                {
                    intervaloveZakazky = evidence.ZobrazIntervalZakazek(intervalOdDateTimePicker.Value, intervalDoDateTimePicker.Value);
                    hotoveZakazkyDataGridView.DataSource = intervaloveZakazky;
                    celkemZakazekLabel.Text = intervaloveZakazky.Count.ToString();
                    celkemZiskLabel.Text = evidence.CelkemZisk(intervaloveZakazky).ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
        }

        private void zrusitIntervalFiltrButton_Click(object sender, EventArgs e)
        {
            hotoveZakazkyDataGridView.DataSource = evidence.EvidenceHotovychZakazek;
            intervaloveZakazky = null;
            celkemZakazekLabel.Text = "0";
            celkemZiskLabel.Text = "0";
        }

        private void prihlasitNaZakazkuButton_Click(object sender, EventArgs e)
        {
            if(zamestnanciDataGrid.Rows.Count > 0)
            {
                Zamestnanec zamestnanec = (Zamestnanec)zamestnanciDataGrid.SelectedRows[0].DataBoundItem;
                if (zamestnanec.praceNaZakazce != null)
                {
                    MessageBox.Show("Zaměstnanec je přihlášen na zakázce", "Přihlášení", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    PrihlaseniNaZakazkuForm prihlaseniNaZakazkuForm = new PrihlaseniNaZakazkuForm(zamestnanec, evidence);
                    prihlaseniNaZakazkuForm.ShowDialog();
                    pravePracujeListBox.Items.Add(zamestnanec);
                    zamestnanec.ZacatekPraceNaPolozce();
                }
            }
            
        }

        private void odhlasitZeZakazkyButton_Click(object sender, EventArgs e)
        {
            if(zamestnanciDataGrid.Rows.Count > 0)
            {
                Zamestnanec zamestnanec = (Zamestnanec)zamestnanciDataGrid.SelectedRows[0].DataBoundItem;
                if(zamestnanec.praceNaZakazce != null)
                {
                    zamestnanec.KonecPraceNaPolozce(); // přičtění náladů do zakázky
                    MessageBox.Show("Zaměstnanec byl odhlášen ze zakázky", "Odhlášení", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    pravePracujeListBox.Items.Remove(zamestnanec);
                }
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            evidence.UlozDataZakazek();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
        }

        
    }
}
