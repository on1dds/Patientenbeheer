using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patientenbeheer
{
        public class Postcode
        {
            private int postcodeid;
            private string code;
            private string gemeente;
            private string provincie;

            public Postcode() { }
            public int PostcodeID { get { return postcodeid; } set { postcodeid = value; } }
            public string Code { get { return code; } set { code = value.Substring(0, value.Length > 4 ? 4 : value.Length); } }
            public string Gemeente { get { return gemeente; } set { gemeente = value.Substring(0, value.Length > 60 ? 60 : value.Length); } }
            public string Provincie { get { return provincie; } set { provincie = value.Substring(0, value.Length > 60 ? 60 : value.Length); } }

            public override string ToString()
            {
                return code + " " + gemeente;
            }


        }

}
