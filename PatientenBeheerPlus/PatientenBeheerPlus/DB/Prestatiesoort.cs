using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientenBeheerPlus
{
    public class Prestatiesoort
    {
        // Fields
        private int prestatiesoortid;
        private string naam;
        private string omschrijving;
        private double kostprijs;

        // Constructor
        public Prestatiesoort() { }

        // Properties
        public int PrestatieSoortID { get { return prestatiesoortid; } set { prestatiesoortid = value; } }
        public string Naam { get { return naam; } set { naam = value.Substring(0, value.Length > 50 ? 50 : value.Length); } }
        public string Omschrijving { get { return omschrijving; } set { omschrijving = value.Substring(0, value.Length > 250 ? 250 : value.Length); } }
        public double Kostprijs { get { return kostprijs; } set { kostprijs = value; } }

    }

}
