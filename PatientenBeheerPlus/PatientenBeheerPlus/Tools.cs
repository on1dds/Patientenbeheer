using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientenBeheerPlus
{
    static class Tools
    {
        public static string FormatTelefoonnummer(string s)
        {

            if (s.Length == 9)
                return s.Substring(0, 3) + "-" +
                        s.Substring(3, 2) + "." +
                        s.Substring(5, 2) + "." +
                        s.Substring(7, 2);
            else if (s.Length == 10)
                return s.Substring(0, 4) + "-" +
                        s.Substring(4, 2) + "." +
                        s.Substring(6, 2) + "." +
                        s.Substring(8, 2);
            return s;
        }

  
        public static string StripGetal(string sin)
        {
            string suit = "";
            int temp;
            if (sin.Length > 0)
                for (int i = 0; i < sin.Length; i++)
                    if (int.TryParse(sin.Substring(i, 1), out temp))
                        suit += sin.Substring(i, 1);

            return suit;
        }

        public static string ReformatTelefoonnummer(string s)
        {
            return FormatTelefoonnummer(StripGetal(s));
        }
    }

}
