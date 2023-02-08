using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace PlanovacVyroby
{
    public class Evidence:INotifyPropertyChanged
    {
        public BindingList<Zamestnanec> EvidenceZamestnancu;
        public BindingList<Zakazka> EvidenceZakazek;
        public BindingList<Zakazka> EvidenceHotovychZakazek;

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }

        public Evidence()
        {
            EvidenceZamestnancu = new BindingList<Zamestnanec>();
            EvidenceZakazek = new BindingList<Zakazka>();
            EvidenceHotovychZakazek = new BindingList<Zakazka>();

            EvidenceZamestnancu.Add(new Zamestnanec("Jarda","Blažek",new DateTime(2000,2,1),140));
            EvidenceZamestnancu.Add(new Zamestnanec("Milan", "Plachý", new DateTime(1986, 3, 2), 160));
            EvidenceZamestnancu.Add(new Zamestnanec("Jíří", "Nový", new DateTime(1996, 2, 11), 180));
            EvidenceZamestnancu.Add(new Zamestnanec("Václav", "Starý", new DateTime(2001, 6, 16), 190));

        }
        public void PridejZamestnance(string jmeno, string prijmeni, DateTime datumNarozeni, decimal mzdaNaHodinu)
        {
            if (datumNarozeni == null)
                throw new ArgumentException("Nebyl zadán datum narození");
            if (mzdaNaHodinu == 0)
                throw new ArgumentException("Nebyla zadána mzda na hodinu");
            if (datumNarozeni > DateTime.Today.AddYears(-18))
                throw new ArgumentException("Zaměstnec není plnoletý");
            if (string.IsNullOrEmpty(jmeno))
                throw new ArgumentException("Zadejte jméno zaměstnance");
            if (string.IsNullOrEmpty(prijmeni))
                throw new ArgumentException("Zadejte příjmení zaměstnace");
            EvidenceZamestnancu.Add(new Zamestnanec(jmeno, prijmeni, datumNarozeni, mzdaNaHodinu));
        }
        public void OdeberZamestnance(Zamestnanec zamestnanec)
        {
            EvidenceZamestnancu.Remove(zamestnanec);
        }
        public void PridejZakazku(string nazevVykresu, string nazevZakazky, decimal cenaZaKus, int pocetKusu, DateTime terminDodani, decimal nakladyMaterial)
        {
            if (terminDodani == null) throw new ArgumentException("Nebyl zadán termín dodání!");
            if (terminDodani <= DateTime.Now) throw new ArgumentException("Termín dodání už uběhl");
            if (string.IsNullOrEmpty(nazevVykresu)) throw new ArgumentException("Zadejte název výkresu");
            if (string.IsNullOrEmpty(nazevZakazky)) throw new ArgumentException("Zadejte název zakázky");
            if (cenaZaKus == 0) throw new ArgumentException("Zadejte cenu za kus");
            if (pocetKusu == 0) throw new ArgumentException("Zadejte počet kusů");
            if (nakladyMaterial == 0) throw new ArgumentException("Zadejte náklady na materiál");
            EvidenceZakazek.Add(new Zakazka(nazevVykresu, nazevZakazky, cenaZaKus, pocetKusu, terminDodani, nakladyMaterial));
        }
        public void PridejZakazku(Zakazka zakazka)
        {
            EvidenceZakazek.Add(zakazka);
        }
        public void OdeberZakazku(Zakazka zakazka)
        {
            EvidenceZakazek.Remove(zakazka);
        }
        public void UpravMzduNaHodinu(Zamestnanec zamestnanec,int novaMzda)
        {
            zamestnanec.UpravitMzduNaHodinu(novaMzda);
        }
        public void UlozDataZakazek()
        {
            XmlWriterSettings settings = new XmlWriterSettings();
            settings.Indent = true;
            using (XmlWriter writer = XmlWriter.Create(@"C:\\Programy\\trenink\\PlanovacVyroby\\PlanovacVyroby\\zakazky.xml",settings))
            {
                writer.WriteStartDocument();
                writer.WriteStartElement("zakazky");

                foreach (var zakazka in EvidenceZakazek)
                {
                    writer.WriteStartElement("zakazka");
                    writer.WriteElementString("nazevVykresu", zakazka.NazevVykresu);
                    writer.WriteElementString("nazevZakazky", zakazka.NazevZakazky);
                    writer.WriteElementString("cenaZaKus", zakazka.CenaZaKus.ToString());
                    writer.WriteElementString("pocetKusu", zakazka.PocetKusu.ToString());
                    writer.WriteElementString("terminDodani", zakazka.TerminDodani.ToShortDateString());
                    writer.WriteElementString("nakladyNaMaterial",zakazka.NakladyMaterial.ToString());
                    writer.WriteElementString("nakladyNaVyrobu", zakazka.NakladyNaVyrobu.ToString());
                    writer.WriteEndElement();
                }

                writer.WriteEndElement();
                writer.WriteEndDocument();
                writer.Flush();
            }
        }
        public void NactiDataZakazek()
        {
            using (XmlReader reader = XmlReader.Create("C:\\Programy\\trenink\\PlanovacVyroby\\PlanovacVyroby\\zakazky.xml"))
            {
                string nazevVykresu = "";
                string nazevZakazky = "";
                decimal cenaZaKus = 0;
                int pocetKusu = 0;
                DateTime terminDodani = DateTime.Now;
                decimal nakladyNaMaterial = 0;
                decimal nakladyNaVyrobu = 0;
                string element = "";

                while (reader.Read())
                {
                    if (reader.NodeType == XmlNodeType.Element)
                    {
                        element = reader.Name;
                    }
                    else if(reader.NodeType == XmlNodeType.Text)
                    { 
                        switch (element)
                        {
                            case "nazevVykresu":
                                    nazevVykresu = reader.Value;
                                    break;
                            case "nazevZakazky":
                                    nazevZakazky = reader.Value;
                                    break;
                            case "cenaZaKus":
                                    cenaZaKus = decimal.Parse(reader.Value);
                                    break;
                            case "pocetKusu":
                                    pocetKusu = int.Parse(reader.Value);
                                    break;
                            case "terminDodani":
                                    terminDodani = DateTime.Parse(reader.Value);
                                    break;
                            case "nakladyNaMaterial":
                                    nakladyNaMaterial = decimal.Parse(reader.Value);
                                    break;
                            case "nakladyNaVyrobu":
                                    nakladyNaVyrobu = decimal.Parse(reader.Value);
                                    break;
                        }
                    }

                    else if ((reader.NodeType == XmlNodeType.EndElement) && (reader.Name == "zakazka"))
                    {
                        Zakazka nactenaZakazka = new Zakazka(nazevVykresu, nazevZakazky, cenaZaKus, pocetKusu, terminDodani, nakladyNaMaterial);
                        nactenaZakazka.NakladyNaVyrobu = nakladyNaVyrobu;
                        PridejZakazku(nactenaZakazka);
                    }
                }
            }
        }
        public bool JeZakazkaRozpracovana(Zakazka zakazka)
        {
            foreach (var item in EvidenceZamestnancu)
            {
                if (item.praceNaZakazce == zakazka)
                {
                    return true;
                }
            }
            return false;
        }

        public BindingList<Zakazka> ZobrazIntervalZakazek(DateTime odkdy,DateTime dokdy)
        {
            if (odkdy == null) throw new ArgumentNullException("Zadejte interval odkdy");
            if (dokdy == null) throw new ArgumentNullException("Zadejte interval dokdy");
            if (odkdy > dokdy) throw new ArgumentException("Špatně zadaný interval");
            var zakazkyIntevalu = new BindingList<Zakazka>();
            foreach (var item in EvidenceHotovychZakazek)
            {
                if ((item.DatumDokonceni >= odkdy.Date) && (item.DatumDokonceni <= dokdy.Date))
                    zakazkyIntevalu.Add(item);
            }
            var serazenyInterval = zakazkyIntevalu.OrderBy(a => a.TerminDodani).ToList();
            var list = new BindingList<Zakazka>(serazenyInterval);
            return list;
        }

        public decimal CelkemZisk(BindingList<Zakazka> list)
        {
            decimal vysledek = 0;
            foreach (var item in list)
            {
                vysledek += item.Vyteznost;
            }
            return vysledek;
        }
    }
}
