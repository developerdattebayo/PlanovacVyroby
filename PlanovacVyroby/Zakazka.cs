using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace PlanovacVyroby
{
    public class Zakazka:INotifyPropertyChanged
    {
        public DateTime TerminDodani { get;private set; }
        public string NazevVykresu { get; private set; }
        public string NazevZakazky { get;private set; }
        public double ZbyvaDni =>(TerminDodani - DateTime.Today).TotalDays;
        public decimal CenaZaKus { get;private set; }
        public int PocetKusu { get;private set; }
        public DateTime DatumDokonceni { get; set; }
        public decimal CenaCelkem => PocetKusu * CenaZaKus;
        private decimal nakladyNaVyrobu;
        public decimal NakladyNaVyrobu 
        {
            get { return nakladyNaVyrobu; } 
            set {
                nakladyNaVyrobu = value;
                OnPropertyChanged();
                SpoctiVyteznost();
            } 
        }
        public decimal NakladyMaterial { get;private set; }
        public decimal Vyteznost { get;private set; }
        public Zakazka(string nazevVykresu, string nazevZakazky, decimal cenaZaKus, int pocetKusu, DateTime terminDodani, decimal nakladyMaterial)
        {
            NazevVykresu = nazevVykresu;
            NazevZakazky = nazevZakazky;
            CenaZaKus = cenaZaKus;
            PocetKusu = pocetKusu;
            TerminDodani = terminDodani.Date;
            NakladyMaterial = nakladyMaterial;
            SpoctiVyteznost();
        }
        public void SpoctiVyteznost()
        {
            Vyteznost = ((CenaCelkem - NakladyNaVyrobu) - NakladyMaterial);
            OnPropertyChanged();
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
