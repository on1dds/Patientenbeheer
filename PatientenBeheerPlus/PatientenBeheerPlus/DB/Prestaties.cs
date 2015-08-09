using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientenBeheerPlus
{
    public class Prestatie
    {
        // Fields

        private int prestatienr;
        private int prestatiesoortid;
        private int opnamenr;
        private DateTime tijdstip;
        private int uitvoerderid;
        private int prestatiestatusid;
        private string opmerking;

        // Constructor

        public Prestatie() { }
        public int Prestatienr { get { return prestatienr; } set { prestatienr = value; } }
        public int PrestatieSoortID { get { return prestatiesoortid; } set { prestatiesoortid = value; } }
        public int Opnamenr { get { return opnamenr; } set { opnamenr = value; } }
        public DateTime Tijdstip { get { return tijdstip; } set { tijdstip = value; } }
        public int UitvoerderID { get { return uitvoerderid; } set { uitvoerderid = value; } }
        public int PrestatieStatusID { get { return prestatiestatusid; } set { prestatiestatusid = value; } }
        public string Opmerking { get { return opmerking; } set { opmerking = value.Substring(0, value.Length > 250 ? 250 : value.Length); } }
        public string ListInfo { get { return string.Format("{0:dd/MM/yy HH:mm} {1}", Tijdstip, PrestatiesoortDB.Get(prestatiesoortid).Omschrijving); } }
        public string PrestatieStatus
        {
            get
            {
                switch (PrestatieStatusID)
                {
                    case DB.PRESTATIESTATUS_VERSTREKT:
                        return "Uitgevoerd";
                    case DB.PRESTATIESTATUS_AFGESLOTEN:
                        return "Aangeboden aan facturatie";
                    case DB.PRESTATIESTATUS_AAGEREKEND:
                        return "Aangerekend aan patient";
                    case DB.PRESTATIESTATUS_BETAALD:
                        return "Voldaan door patient";

                    default:
                        return "Verwerkt door facturatie";
                }

            }
        }


        public override string ToString()
        {
            string s = "";
            s +=
                "Tijdstip  : " + String.Format("{0:dd/MM/yyyy HH:mm}", Tijdstip) + Environment.NewLine +
                "Door      : " + PersoneelDB.Get(UitvoerderID).Volledigenaam + Environment.NewLine +
                "Prestatie : " + PrestatiesoortDB.Get(PrestatieSoortID).Naam + Environment.NewLine +
                "            " + PrestatiesoortDB.Get(PrestatieSoortID).Omschrijving + Environment.NewLine +
                "Status    : " + PrestatieStatus + Environment.NewLine +
                "Bemerking : " + Environment.NewLine +
                 Opmerking;
                 
            return s;



        }

    }
}
