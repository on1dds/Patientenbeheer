using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientenBeheerPlus
{
    public class Personeel
    {
        private int peroneelid;
        private string voornaam;
        private string achternaam;
        private string functie;

        public Personeel() { }
        public int PersoneelID { get { return peroneelid; } set { peroneelid = value; } }
        public string Voornaam { get { return voornaam; } set { voornaam = value.Substring(0, value.Length > 50 ? 50 : value.Length); } }
        public string Achternaam { get { return achternaam; } set { achternaam = value.Substring(0, value.Length > 50 ? 50 : value.Length); } }
        public string Functie { get { return functie; } set { functie = value.Substring(0, value.Length > 50 ? 50 : value.Length); } }
        public string Volledigenaam { get { return Achternaam + ", " + Voornaam; } }

    }
}
