using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patientenbeheer
{
    public class Prestatiesoort
    {
        // Fields
        private int prestatiesoortid;
        private string prestatienummer;
        private string omschrijving;
        private double prijs;

        // Constructor
        public Prestatiesoort() { }

        // Properties
        public int PrestatieSoortID { get { return prestatiesoortid; } set { prestatiesoortid = value; } }
        public string Gemeente { get { return prestatienummer; } set { prestatienummer = value.Substring(0, value.Length > 20 ? 20 : value.Length); } }
        public string Provincie { get { return omschrijving; } set { omschrijving = value.Substring(0, value.Length > 20 ? 20 : value.Length); } }
        public double Prijs { get { return prijs; } set { prijs = value; } }
    }
}
