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
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;

namespace PlanovacVyroby
{
    public class Evidence:INotifyPropertyChanged
    {
        public BindingList<Zamestnanec> EvidenceZamestnancu;
        public BindingList<Zakazka> EvidenceZakazek;
        public BindingList<Zakazka> EvidenceHotovychZakazek;
        public BindingList<Zakazka> FiltrovaneZakazky;
        const string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Programy\trenink\PlanovacVyroby\PlanovacVyroby\Databaze.mdf;Integrated Security = True";

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

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string prikaz = "INSERT INTO Zamestnanec (FirstName,LastName,Birth,Pay) VALUES (@jmeno,@prijmeni,@datumNarozeni,@mzda)";
                using (SqlCommand cmd = new SqlCommand(prikaz, con))
                {
                    con.Open();
                    cmd.Parameters.AddWithValue("@jmeno", jmeno);
                    cmd.Parameters.AddWithValue("@prijmeni", prijmeni);
                    cmd.Parameters.AddWithValue("@datumNarozeni", datumNarozeni);
                    cmd.Parameters.AddWithValue("@mzda", mzdaNaHodinu);
                    cmd.ExecuteNonQuery();
                }
            }
            EvidenceZamestnancu.Add(new Zamestnanec(jmeno, prijmeni, datumNarozeni, mzdaNaHodinu));
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

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string prikaz = "INSERT INTO Zakazka (ItemName,OrderName,PriceForPiece,ItemCount,ExpirationDate,MaterialCost) Values (@nazevVykresu,@nazevZakazky,@cenaZaKus,@pocetKusu,@terminDodani,@nakladyMaterial)";
                using (SqlCommand cmd = new SqlCommand(prikaz,con))
                {
                    con.Open();
                    cmd.Parameters.AddWithValue("@nazevVykresu", nazevVykresu);
                    cmd.Parameters.AddWithValue("@nazevZakazky", nazevZakazky);
                    cmd.Parameters.AddWithValue("@cenaZaKus", cenaZaKus);
                    cmd.Parameters.AddWithValue("@pocetKusu", pocetKusu);
                    cmd.Parameters.AddWithValue("@terminDodani", terminDodani);
                    cmd.Parameters.AddWithValue("@nakladyMaterial", nakladyMaterial);
                    cmd.ExecuteNonQuery();
                }
            }

            EvidenceZakazek.Add(new Zakazka(nazevVykresu, nazevZakazky, cenaZaKus, pocetKusu, terminDodani, nakladyMaterial));
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
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string prikaz = "UPDATE Zamestnanec SET Pay=@mzda WHERE Birth=@datumNarozeni AND LastName=@prijmeni";
                using (SqlCommand cmd = new SqlCommand(prikaz,con))
                {
                    con.Open();
                    cmd.Parameters.AddWithValue("@datumNarozeni", zamestnanec.DatumNarozeni);
                    cmd.Parameters.AddWithValue("@prijmeni", zamestnanec.Prijmeni);
                    cmd.Parameters.AddWithValue("@mzda", zamestnanec.MzdaNaHodinu);
                    cmd.ExecuteNonQuery();
                }
            }
        }
        public bool JeZamestnanecPrihlaseniNaPolozce(Zamestnanec zamestnanec)
        {
            if (zamestnanec.praceNaZakazce != null)
                return true;
            return false;
            
        }
        //Původní ukládání a načítání dat do a z XML souboru
        //public void UlozDataZakazek()
        //{
        //    XmlWriterSettings settings = new XmlWriterSettings();
        //    settings.Indent = true;
        //    using (XmlWriter writer = XmlWriter.Create(@"zakazky.xml",settings))
        //    {
        //        writer.WriteStartDocument();
        //        writer.WriteStartElement("zakazky");

        //        foreach (var zakazka in EvidenceZakazek)
        //        {
        //            writer.WriteStartElement("zakazka");
        //            writer.WriteElementString("nazevVykresu", zakazka.NazevVykresu);
        //            writer.WriteElementString("nazevZakazky", zakazka.NazevZakazky);
        //            writer.WriteElementString("cenaZaKus", zakazka.CenaZaKus.ToString());
        //            writer.WriteElementString("pocetKusu", zakazka.PocetKusu.ToString());
        //            writer.WriteElementString("terminDodani", zakazka.TerminDodani.ToShortDateString());
        //            writer.WriteElementString("nakladyNaMaterial",zakazka.NakladyMaterial.ToString());
        //            writer.WriteElementString("nakladyNaVyrobu", zakazka.NakladyNaVyrobu.ToString());
        //            writer.WriteEndElement();
        //        }
        //        foreach (var zakazka in EvidenceHotovychZakazek)
        //        {
        //            writer.WriteStartElement("zakazkaHotova");
        //            writer.WriteElementString("nazevVykresu", zakazka.NazevVykresu);
        //            writer.WriteElementString("nazevZakazky", zakazka.NazevZakazky);
        //            writer.WriteElementString("cenaZaKus", zakazka.CenaZaKus.ToString());
        //            writer.WriteElementString("pocetKusu", zakazka.PocetKusu.ToString());
        //            writer.WriteElementString("terminDodani", zakazka.TerminDodani.ToShortDateString());
        //            writer.WriteElementString("nakladyNaMaterial", zakazka.NakladyMaterial.ToString());
        //            writer.WriteElementString("nakladyNaVyrobu", zakazka.NakladyNaVyrobu.ToString());
        //            writer.WriteElementString("datumDokonceni", zakazka.DatumDokonceni.ToShortDateString());
        //            writer.WriteEndElement();
        //        }
        //        foreach (var zamestnanec in EvidenceZamestnancu)
        //        {
        //            writer.WriteStartElement("zamestnanec");
        //            writer.WriteElementString("jmeno", zamestnanec.Jmeno);
        //            writer.WriteElementString("prijmeni", zamestnanec.Prijmeni);
        //            writer.WriteElementString("datumNarozeni", zamestnanec.DatumNarozeni.ToShortDateString());
        //            writer.WriteElementString("mzdaNaHodinu", zamestnanec.MzdaNaHodinu.ToString());
        //            writer.WriteEndElement();
        //        }


        //        writer.WriteEndElement();
        //        writer.WriteEndDocument();
        //        writer.Flush();
        //    }
        //}
        //public void NactiDataZakazek()
        //{
        //    using (XmlReader reader = XmlReader.Create("zakazky.xml"))
        //    {
        //        string nazevVykresu = "";
        //        string nazevZakazky = "";
        //        decimal cenaZaKus = 0;
        //        int pocetKusu = 0;
        //        DateTime terminDodani = DateTime.Now;
        //        decimal nakladyNaMaterial = 0;
        //        decimal nakladyNaVyrobu = 0;
        //        string element = "";
        //        DateTime datumDokonceni = DateTime.Now;
        //        //Zamestnanec
        //        string jmeno = "";
        //        string prijmeni = "";
        //        DateTime datumNarozeni = DateTime.Today;
        //        decimal mzdaNaHodinu = 0;

        //        while (reader.Read())
        //        {
        //            if (reader.NodeType == XmlNodeType.Element)
        //            {
        //                element = reader.Name;
        //            }
        //            else if (reader.NodeType == XmlNodeType.Text)
        //            {
        //                switch (element)
        //                {
        //                    case "nazevVykresu":
        //                        nazevVykresu = reader.Value;
        //                        break;
        //                    case "nazevZakazky":
        //                        nazevZakazky = reader.Value;
        //                        break;
        //                    case "cenaZaKus":
        //                        cenaZaKus = decimal.Parse(reader.Value);
        //                        break;
        //                    case "pocetKusu":
        //                        pocetKusu = int.Parse(reader.Value);
        //                        break;
        //                    case "terminDodani":
        //                        terminDodani = DateTime.Parse(reader.Value);
        //                        break;
        //                    case "nakladyNaMaterial":
        //                        nakladyNaMaterial = decimal.Parse(reader.Value);
        //                        break;
        //                    case "nakladyNaVyrobu":
        //                        nakladyNaVyrobu = decimal.Parse(reader.Value);
        //                        break;
        //                    case "datumDokonceni":
        //                        datumDokonceni = DateTime.Parse(reader.Value);
        //                        break;
        //                    case "jmeno":
        //                        jmeno = reader.Value;
        //                        break;
        //                    case "prijmeni":
        //                        prijmeni = reader.Value;
        //                        break;
        //                    case "datumNarozeni":
        //                        datumNarozeni = DateTime.Parse(reader.Value);
        //                        break;
        //                    case "mzdaNaHodinu":
        //                        mzdaNaHodinu = decimal.Parse(reader.Value);
        //                        break;
        //                }
        //            }

        //            else if ((reader.NodeType == XmlNodeType.EndElement) && (reader.Name == "zakazka"))
        //            {
        //                Zakazka nactenaZakazka = new Zakazka(nazevVykresu, nazevZakazky, cenaZaKus, pocetKusu, terminDodani, nakladyNaMaterial);
        //                nactenaZakazka.NakladyNaVyrobu = nakladyNaVyrobu;
        //                PridejZakazku(nactenaZakazka);
        //            }
        //            else if ((reader.NodeType == XmlNodeType.EndElement) && (reader.Name == "zakazkaHotova"))
        //            {
        //                Zakazka nactenaZakazka = new Zakazka(nazevVykresu, nazevZakazky, cenaZaKus, pocetKusu, terminDodani, nakladyNaMaterial);
        //                nactenaZakazka.NakladyNaVyrobu = nakladyNaVyrobu;
        //                nactenaZakazka.DatumDokonceni = datumDokonceni;
        //                EvidenceHotovychZakazek.Add(nactenaZakazka);
        //            }
        //            else if ((reader.NodeType == XmlNodeType.EndElement) && (reader.Name == "zamestnanec"))
        //            {
        //                Zamestnanec zamestnanec = new Zamestnanec(jmeno, prijmeni, datumNarozeni, mzdaNaHodinu);
        //                EvidenceZamestnancu.Add(zamestnanec);
        //            }
        //        }
        //    }
        //}
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
            foreach (Zamestnanec zamestnanec in EvidenceZamestnancu)
            {
                if (zamestnanec.praceNaZakazce != null)
                {
                    Zakazka zakazka = zamestnanec.praceNaZakazce;
                    zamestnanec.KonecPraceNaPolozce();
                    UlozDoDBNakladyNaVyrobu(zakazka);
                }
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
        public decimal CelkemZisk(BindingList<Zakazka> list)
        {
            decimal vysledek = 0;
            foreach (var item in list)
            {
                vysledek += item.Vyteznost;
            }
            return vysledek;
        }
        public void UlozDoDBHotovouZakazku(DateTime datumDokonceni,Zakazka hotovaZakazka)
        {
            using (SqlConnection con = new SqlConnection(connectionString)) 
            {
                string prikaz = "UPDATE Zakazka SET FinishDate=@datumDokonceni WHERE ItemName=@nazevVykresu AND OrderName=@nazevZakazky AND ExpirationDate=@terminDodani";
                using (SqlCommand cmd = new SqlCommand(prikaz,con))
                {
                    con.Open();
                    cmd.Parameters.AddWithValue("@datumDokonceni", datumDokonceni);
                    cmd.Parameters.AddWithValue("nazevVykresu",hotovaZakazka.NazevVykresu);
                    cmd.Parameters.AddWithValue("nazevZakazky", hotovaZakazka.NazevZakazky);
                    cmd.Parameters.AddWithValue("terminDodani", hotovaZakazka.TerminDodani);
                    cmd.ExecuteNonQuery();
                }
            }
        }
        public void NactiData()
        {
            //Nacčtení zaměstnanců
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Zamestnanec",con);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    EvidenceZamestnancu.Add(new Zamestnanec((string)reader["FirstName"], (string)reader["LastName"], (DateTime)reader["Birth"], (decimal)reader["Pay"]));
                }
            }
            //Načtení zakázek
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                SqlCommand cmdZakazky = new SqlCommand("SELECT * FROM Zakazka", con);
                SqlDataReader readerZakazek = cmdZakazky.ExecuteReader();
                while (readerZakazek.Read())
                {
                    var datumDokonceni = readerZakazek["FinishDate"] as DateTime?;
                    if (datumDokonceni.HasValue)
                    {
                        Zakazka nactenaZakazka = new Zakazka((string)readerZakazek["ItemName"], (string)readerZakazek["OrderName"], (decimal)readerZakazek["PriceForPiece"], (int)readerZakazek["ItemCount"], (DateTime)readerZakazek["ExpirationDate"], (decimal)readerZakazek["MaterialCost"]);
                        nactenaZakazka.DatumDokonceni = (DateTime)readerZakazek["FinishDate"];
                        if (readerZakazek["WorkCost"] != System.DBNull.Value)
                            nactenaZakazka.NakladyNaVyrobu = (decimal)readerZakazek["WorkCost"];
                        else
                            nactenaZakazka.NakladyNaVyrobu = 0;
                        EvidenceHotovychZakazek.Add(nactenaZakazka);
                    }
                    else
                    {
                        Zakazka nactenaZakazka = new Zakazka((string)readerZakazek["ItemName"], (string)readerZakazek["OrderName"], (decimal)readerZakazek["PriceForPiece"], (int)readerZakazek["ItemCount"], (DateTime)readerZakazek["ExpirationDate"], (decimal)readerZakazek["MaterialCost"]);
                        if (readerZakazek["WorkCost"] != System.DBNull.Value)
                            nactenaZakazka.NakladyNaVyrobu = (decimal)readerZakazek["WorkCost"];
                        else
                            nactenaZakazka.NakladyNaVyrobu = 0;
                        EvidenceZakazek.Add(nactenaZakazka);
                    }
                }
            }
        }
        public void UlozDoDBNakladyNaVyrobu(Zakazka zakazka)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string prikaz = "UPDATE Zakazka SET WorkCost=@nakladyNaVyrobu WHERE ItemName=@nazevVykresu AND OrderName=@nazevZakazky AND ExpirationDate=@terminDodani";
                using (SqlCommand cmd = new SqlCommand(prikaz,con))
                {
                    //string terminDodani = zakazka.TerminDodani.ToString("yyyy,MM,dd");
                    con.Open();
                    cmd.Parameters.AddWithValue("@nakladyNaVyrobu", zakazka.NakladyNaVyrobu);
                    cmd.Parameters.AddWithValue("nazevVykresu", zakazka.NazevVykresu);
                    cmd.Parameters.AddWithValue("nazevZakazky", zakazka.NazevZakazky);
                    cmd.Parameters.AddWithValue("terminDodani", zakazka.TerminDodani);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
