using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientenBeheerPlus
{
    public class Opname
    {

        private int opnamenr;
        private int patientnr;
        private DateTime opnamedatum;
        private DateTime ontslagdatum;
        private int afdelingid;
        private string opmerking;

        public Opname() { }
        public int Opnamenr { get { return opnamenr; } set { opnamenr = value; } }
        public int Patientnr { get { return patientnr; } set { patientnr = value; } }
        public DateTime Opnamedatum { get { return opnamedatum; } set { opnamedatum = value; } }
        public DateTime Ontslagdatum { get { return ontslagdatum; } set { ontslagdatum = value; } }
        public int AfdelingID { get { return afdelingid; } set { afdelingid = value; } }
        public string Opmerking { get { return opmerking; } set { opmerking = value.Substring(0, value.Length > 250 ? 250 : value.Length); } }
        public string ListInfo 
        { 
            get 
            {
                if(opnamedatum != ontslagdatum)
                    return string.Format("{0:dd/MM/yy} - {1:dd/MM/yy} ({2})",  Opnamedatum, Ontslagdatum, AfdelingDB.Get(afdelingid).Afdelingnaam); 
                else
                    return string.Format("{0:dd/MM/yy} -          ({1})",  Opnamedatum, AfdelingDB.Get(afdelingid).Afdelingnaam); 
            } 
        }

        public override string ToString()
        {
            string s ="";
            s += "Opnamenr :" + opnamenr.ToString() + Environment.NewLine;
            s += "Afdeling :" + afdelingid.ToString() + Environment.NewLine; ;
            s += "Opname   :" + opnamedatum.ToShortDateString() + " " + opnamedatum.ToLongTimeString() + Environment.NewLine; ;
            s += "Ontslag  :" + ontslagdatum.ToShortDateString() + " " + ontslagdatum.ToShortTimeString();
            return s;
        }
    }
}
