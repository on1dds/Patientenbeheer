using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patientenbeheer
{
    public class Opname
    {

        private int opnamenr;
        private int patientnr;
        private DateTime opnamedatum;
        private DateTime ontslagdatum;
        private int afdelingid;

        public Opname() { }
        public int Opnamenr { get { return opnamenr; } set { opnamenr = value; } }
        public int Patientnr { get { return patientnr; } set { patientnr = value; } }
        public DateTime Opnamedatum { get { return opnamedatum; } set { opnamedatum = value; } }
        public DateTime Ontslagdatum { get { return ontslagdatum; } set { ontslagdatum = value; } }
        public int AfdelingID { get { return afdelingid; } set { afdelingid = value; } }
    }
}
