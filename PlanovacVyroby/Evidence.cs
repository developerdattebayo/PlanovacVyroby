using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;

namespace PlanovacVyroby
{
    public class Evidence:INotifyPropertyChanged
    {
        public BindingList<Zamestnanec> EvidenceZamestnancu;
        public BindingList<Zakazka> EvidenceZakazek;
        public BindingList<Zakazka> EvidenceHotovychZakazek;
        public BindingList<Zakazka> FiltrovaneZakazky;

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
            FiltrovaneZakazky = new BindingList<Zakazka>();

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
        public void UpravMzduNaHodinu(Zamestnanec zamestnanec,decimal novaMzda)
        {
            if (novaMzda <= 0)
                throw new ArgumentException("Nová mzda musí být víc než 0");
            zamestnanec.UpravitMzduNaHodinu(novaMzda);
        }
        public bool JeZamestnanecPrihlaseniNaPolozce(Zamestnanec zamestnanec)
        {
            if (zamestnanec.praceNaZakazce != null)
                return true;
            return false;
            
        }
        public void UlozDataZakazek()
        {
            XmlWriterSettings settings = new XmlWriterSettings();
            settings.Indent = true;
            using (XmlWriter writer = XmlWriter.Create(@"zakazky.xml",settings))
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
                foreach (var zakazka in EvidenceHotovychZakazek)
                {
                    writer.WriteStartElement("zakazkaHotova");
                    writer.WriteElementString("nazevVykresu", zakazka.NazevVykresu);
                    writer.WriteElementString("nazevZakazky", zakazka.NazevZakazky);
                    writer.WriteElementString("cenaZaKus", zakazka.CenaZaKus.ToString());
                    writer.WriteElementString("pocetKusu", zakazka.PocetKusu.ToString());
                    writer.WriteElementString("terminDodani", zakazka.TerminDodani.ToShortDateString());
                    writer.WriteElementString("nakladyNaMaterial", zakazka.NakladyMaterial.ToString());
                    writer.WriteElementString("nakladyNaVyrobu", zakazka.NakladyNaVyrobu.ToString());
                    writer.WriteElementString("datumDokonceni", zakazka.DatumDokonceni.ToShortDateString());
                    writer.WriteEndElement();
                }
                foreach (var zamestnanec in EvidenceZamestnancu)
                {
                    writer.WriteStartElement("zamestnanec");
                    writer.WriteElementString("jmeno", zamestnanec.Jmeno);
                    writer.WriteElementString("prijmeni", zamestnanec.Prijmeni);
                    writer.WriteElementString("datumNarozeni", zamestnanec.DatumNarozeni.ToShortDateString());
                    writer.WriteElementString("mzdaNaHodinu", zamestnanec.MzdaNaHodinu.ToString());
                    writer.WriteEndElement();
                }


                writer.WriteEndElement();
                writer.WriteEndDocument();
                writer.Flush();
            }
        }
        public void NactiDataZakazek()
        {
            using (XmlReader reader = XmlReader.Create("zakazky.xml"))
            {
                string nazevVykresu = "";
                string nazevZakazky = "";
                decimal cenaZaKus = 0;
                int pocetKusu = 0;
                DateTime terminDodani = DateTime.Now;
                decimal nakladyNaMaterial = 0;
                decimal nakladyNaVyrobu = 0;
                string element = "";
                DateTime datumDokonceni = DateTime.Now;
                //Zamestnanec
                string jmeno = "";
                string prijmeni = "";
                DateTime datumNarozeni = DateTime.Today;
                decimal mzdaNaHodinu = 0;

                while (reader.Read())
                {
                    if (reader.NodeType == XmlNodeType.Element)
                    {
                        element = reader.Name;
                    }
                    else if (reader.NodeType == XmlNodeType.Text)
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
                            case "datumDokonceni":
                                datumDokonceni = DateTime.Parse(reader.Value);
                                break;
                            case "jmeno":
                                jmeno = reader.Value;
                                break;
                            case "prijmeni":
                                prijmeni = reader.Value;
                                break;
                            case "datumNarozeni":
                                datumNarozeni = DateTime.Parse(reader.Value);
                                break;
                            case "mzdaNaHodinu":
                                mzdaNaHodinu = decimal.Parse(reader.Value);
                                break;
                        }
                    }

                    else if ((reader.NodeType == XmlNodeType.EndElement) && (reader.Name == "zakazka"))
                    {
                        Zakazka nactenaZakazka = new Zakazka(nazevVykresu, nazevZakazky, cenaZaKus, pocetKusu, terminDodani, nakladyNaMaterial);
                        nactenaZakazka.NakladyNaVyrobu = nakladyNaVyrobu;
                        PridejZakazku(nactenaZakazka);
                    }
                    else if ((reader.NodeType == XmlNodeType.EndElement) && (reader.Name == "zakazkaHotova"))
                    {
                        Zakazka nactenaZakazka = new Zakazka(nazevVykresu, nazevZakazky, cenaZaKus, pocetKusu, terminDodani, nakladyNaMaterial);
                        nactenaZakazka.NakladyNaVyrobu = nakladyNaVyrobu;
                        nactenaZakazka.DatumDokonceni = datumDokonceni;
                        EvidenceHotovychZakazek.Add(nactenaZakazka);
                    }
                    else if ((reader.NodeType == XmlNodeType.EndElement) && (reader.Name == "zamestnanec"))
                    {
                        Zamestnanec zamestnanec = new Zamestnanec(jmeno, prijmeni, datumNarozeni, mzdaNaHodinu);
                        EvidenceZamestnancu.Add(zamestnanec);
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
        public void OdhlasVsechnyZamestnance()
        {
            foreach (var zamestnanec in EvidenceZamestnancu)
            {
                if(zamestnanec.praceNaZakazce != null)
                zamestnanec.KonecPraceNaPolozce();
            }
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
        public BindingList<Zakazka> ZobrazCisloZakazky(string zakazka)
        {
            if (string.IsNullOrWhiteSpace(zakazka))
                throw new ArgumentException("Zadejte zakázku");
            else
            {
                var vykresy = EvidenceHotovychZakazek.Where(v => v.NazevZakazky == zakazka).Select(v => v).ToList();
                return new BindingList<Zakazka>(vykresy);
            }
        }
        public BindingList<Zakazka> ZobrazCisloVykresu(string vykres)
        {
            if (string.IsNullOrWhiteSpace(vykres))
                throw new ArgumentException("Zadejte výkres");
            else
            { 
               var vykresy = EvidenceHotovychZakazek.Where(v => v.NazevVykresu == vykres).Select(v => v).ToList();
                return new BindingList<Zakazka>(vykresy);
            }
        }
        //public void SerializujZamestnance()
        //{
        //    try
        //    {
        //        XmlSerializer serializer = new XmlSerializer(EvidenceZamestnancu.GetType());
        //        using (StreamWriter writer = new StreamWriter("zamestnanci.xml"))
        //        {
        //            serializer.Serialize(writer,EvidenceZamestnancu);
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message,"Chyba",MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}
        //public void DeserializujZamestnance()
        //{
        //    try
        //    {
        //        if (File.Exists("zamestnanci.xml"))
        //        {
        //            XmlSerializer serializer = new XmlSerializer(EvidenceZamestnancu.GetType());
        //            using (StreamReader reader = new StreamReader("zamestnanci.xml"))
        //            {
        //                EvidenceZamestnancu = (BindingList<Zamestnanec>)serializer.Deserialize(reader);

        //            }
        //        }

        //        else 
        //        throw new FileNotFoundException("Soubor nebyl nalezen");
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message, "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}
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
