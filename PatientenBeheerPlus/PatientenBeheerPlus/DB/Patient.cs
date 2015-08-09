using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientenBeheerPlus
{
    public class Patient
    {
        // fields
        private int patientnr;
        private string voornaam;
        private string achternaam;
        private string straat;
        private string huisnummer;
        private int postcodeid;
        private string telefoonnummer;
        private DateTime geboortedatum;
        private string opmerking;

        // constructor

        public Patient()
        {
            patientnr = 0;
            voornaam = "";
            achternaam = "";
            straat = "";
            huisnummer = "";
            postcodeid = 0;
            telefoonnummer = "";
            geboortedatum = DateTime.Now;
        }

        // attributes

        public int Patientnr { get { return patientnr; } set { patientnr = value; } }
        public string Voornaam { get { return voornaam; } set { voornaam = value.Substring(0, value.Length > 50 ? 50 : value.Length); } }
        public string Achternaam { get { return achternaam; } set { achternaam = value.Substring(0, value.Length > 50 ? 50 : value.Length); } }
        public string Straat { get { return straat; } set { straat = value.Substring(0, value.Length > 50 ? 50 : value.Length); } }
        public string Huisnummer { get { return huisnummer; } set { huisnummer = value.Substring(0, value.Length > 50 ? 50 : value.Length); } }
        public int PostcodeID { get { return postcodeid; } set { postcodeid = value; } }
        public string Telefoonnummer { get { return telefoonnummer; } set { telefoonnummer = value.Substring(0, value.Length > 10 ? 10 : value.Length); } }
        public DateTime Geboortedatum { get { return geboortedatum; } set { geboortedatum = value; } }
        public string Opmerking { get { return opmerking; } set { opmerking = value.Substring(0, value.Length > 250 ? 250 : value.Length); } }

        public string ListInfo { get { return string.Format("{0:0000} {1:dd/MM/yyyy} - {2},{3}",Patientnr, Geboortedatum, Achternaam, Voornaam); } }
        public string Volledigenaam { get { return Achternaam + ", " + Voornaam; } }


        // overrides

        public override string ToString()
        {
            string s = "";
            Postcode pc = new Postcode();
            pc = PostcodeDB.Get(PostcodeID);
            s += "Naam, Voornaam: " + Achternaam + ", " + Voornaam + Environment.NewLine;           
            s += "Adres         : " + Straat + " " + Huisnummer + ", " +  pc.Code + " " + pc.Gemeente + Environment.NewLine;
            s += "Geboortedatum : " + Geboortedatum.ToShortDateString() + Environment.NewLine; 
            s += "Telefoonnummer: " + Tools.FormatTelefoonnummer(Telefoonnummer) + Environment.NewLine;
            ;

            return s;
        }
    }

}
