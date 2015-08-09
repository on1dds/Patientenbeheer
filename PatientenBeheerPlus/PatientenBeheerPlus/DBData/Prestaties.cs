using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patientenbeheer
{
    public class Prestaties
    {
        // Fields

        private int prestatienr;
        private int prestatiesoortid;
        private int opnamenr;
        private DateTime tijdstip;
        private int uitvoerderid;
        private int prestatiestatusid;

        // Constructor

        public Prestaties() { }
        public int Prestatienr { get { return prestatienr; } set { prestatienr = value; } }
        public int PrestatieSoortID { get { return prestatiesoortid; } set { prestatiesoortid = value; } }
        public int Opnamenr { get { return opnamenr; } set { opnamenr = value; } }
        public DateTime Tijdstip { get { return tijdstip; } set { tijdstip = value; } }
        public int UitvoerderID { get { return uitvoerderid; } set { uitvoerderid = value; } }
        public int PrestatieStatusID { get { return prestatiestatusid; } set { prestatiestatusid = value; } }
    }
}
