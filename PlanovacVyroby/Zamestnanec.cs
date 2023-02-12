using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace PlanovacVyroby
{
    public class Zamestnanec : INotifyPropertyChanged
    {
        public Zakazka praceNaZakazce;
        public Zamestnanec(string jmeno,string prijmeni,DateTime datumNarozeni,decimal mzdaNaHodinu) 
        { 
            Jmeno= jmeno;
            Prijmeni = prijmeni;
            DatumNarozeni= datumNarozeni.Date;
            MzdaNaHodinu= mzdaNaHodinu;
            Vek = SpoctiVek();
        }
        public string Jmeno { get;private set; }
        public string Prijmeni { get;private set; }
        public DateTime DatumNarozeni { get; private set; }
        public int Vek { get; private set; }
        private decimal mzdaNaHodinu;
        public decimal MzdaNaHodinu 
        {
            get
            {
                return mzdaNaHodinu;
            }
            set
            { 
                mzdaNaHodinu= value;
                OnPropertyChanged();
            }
        }
        public DateTime ZacatekPrace { get;private set; }
        public void UpravitMzduNaHodinu(decimal novaMzda)
        {
            MzdaNaHodinu = novaMzda;
        }
        public void ZacatekPraceNaPolozce()
        {
            ZacatekPrace= DateTime.Now;
        }
        public void KonecPraceNaPolozce()
        {
            TimeSpan odpracovaneHodiny = DateTime.Now - ZacatekPrace;
            decimal nakladycelkem = ((decimal)odpracovaneHodiny.TotalMinutes / 60) * mzdaNaHodinu;
            praceNaZakazce.NakladyNaVyrobu += nakladycelkem;
            praceNaZakazce = null;
        }
        public int SpoctiVek()
        {
            int vek = DateTime.Today.Year - DatumNarozeni.Year;
            if (DateTime.Today < DatumNarozeni.Date)
                vek--;
            return vek;
     
        }
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
        public override string ToString()
        {
            return string.Format("{0} {1} pracuje na zakázce: {2} položka: {3}",Jmeno,Prijmeni,praceNaZakazce.NazevZakazky,praceNaZakazce.NazevVykresu);
        }
    }
}
