using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Microsoft.VisualBasic.FileIO;
using System.Diagnostics;

namespace PatientenBeheerPlus
{
    static class Generator
    {
        static List<string> achternamen = new List<string>();
        static List<voornaam> voornamen = new List<voornaam>();
        static List<straat> Straatnaam = new List<straat>();
        static List<Postcode> gemeentes = new List<Postcode>();
        static List<Opname> opnames = new List<Opname>();
        static List<Afdeling> afdelingen = new List<Afdeling>();

        static Random rnd = new Random(DateTime.Now.Millisecond);

        public static void Initialiseer()
        {
            string pad = @"C:\temp\data\";

            // rnd = new Random(DateTime.Now.Millisecond);

            // lees data
            LeesAchternamen(pad + "achternamen.csv");
            LeesVoornamen(pad + "voornamen.csv");
            LeesStraten(pad + "straatnamen.csv");
            gemeentes = PostcodeDB.GetList();
            opnames = OpnameDB.GetList();
            afdelingen = AfdelingDB.GetList();
        }



        static void LeesAchternamen(string bestand)
        {
            StreamReader sr = File.OpenText(bestand);
            string s;
            while ((s = sr.ReadLine()) != null)
                achternamen.Add(s);
            sr.Close();
        }
        static void LeesVoornamen(string bestand)
        {
            StreamReader sr = File.OpenText(bestand);

            string s;
            while ((s = sr.ReadLine()) != null)
            {
                voornaam vn = new voornaam();
                vn.Geslacht = s.Substring(0, 1);
                vn.Voornaam = s.Substring(1, s.Length - 1);
                voornamen.Add(vn);
            }
            sr.Close();
        }
        static void LeesStraten(string bestand)
        {
            StreamReader sr = File.OpenText(bestand);
            string s;
            while ((s = sr.ReadLine()) != null)
            {
                straat str = new straat();
                str.Postcode = s.Substring(0, 4);
                str.Naam = s.Substring(5, s.Length - 5);
                Straatnaam.Add(str);
            }
            sr.Close();
        }

        public static Patient NewPatient()
        {
            Patient p = new Patient();

            //genereer naam en voornaam
            p.Achternaam = achternamen[rnd.Next(0, achternamen.Count - 1)];
            p.Voornaam = voornamen[rnd.Next(0, voornamen.Count - 1)].Voornaam;
            // a.Geslacht = Voornaam[r].Geslacht;

            // adres
            int r = rnd.Next(0, Straatnaam.Count - 1);
            p.Straat = Straatnaam[r].Naam;
            p.Huisnummer = rnd.Next(1, 150).ToString();

            string pc = Straatnaam[r].Postcode;
            foreach (Postcode gem in gemeentes)
                if (gem.Code == pc) 
                    p.PostcodeID = gem.PostcodeID;

            // telefoonnummer    
            if (rnd.Next(0, 100) != 1)
            {
                p.Telefoonnummer = "0";
                if (rnd.Next(0, 3) == 0)
                {
                    for (int j = 1; j < 9; j++)
                        p.Telefoonnummer += rnd.Next(0, 9).ToString();
                }
                else
                {
                    p.Telefoonnummer += "49";
                    for (int j = 1; j < 8; j++)
                    p.Telefoonnummer += rnd.Next(0, 9).ToString();
                }

            }

            // bereken geboortedatum
            double l = rnd.NextDouble();
            double m = rnd.NextDouble()*20;
            if (l < 0.2108) { }
            else if (l < 0.4635) { m += 20; } 
            else if (l < 0.7539) { m += 40; }
            else if (l < 0.9432) { m += 60; }
            else if (l < 0.9927) { m += 80; }
            else if (l <= 1) { m = 100 + m / 3; }

            p.Geboortedatum = DateTime.Now.Subtract(TimeSpan.FromDays(m*365));

            return p;
        }

        public static Opname NewOpname(Patient patient)
        {
            Opname opname = new Opname();
            Afdeling afdeling = new Afdeling();
            TimeSpan leeftijd = new TimeSpan();
            leeftijd = DateTime.Now - patient.Geboortedatum;

            // genereer opnamedatum
            double dagen = (double)rnd.Next(0, leeftijd.Days);         // moet in zijn leven vallen
            opname.Opnamedatum = patient.Geboortedatum.AddDays(dagen);
            opname.Ontslagdatum = opname.Opnamedatum;
            opname.Opnamedatum = opname.Opnamedatum.AddHours(7 + rnd.NextDouble() * 9);

            // genereer ontslagdatum
            int r = rnd.Next(0,11);
            if (r < 4)                      // dag verblijf
                dagen = 1;
            else if (r < 7)                 // kort verblijf
                dagen = rnd.Next(1, 5);
            else if (r < 9)                 // tamelijk lang verblijf
                dagen = rnd.Next(1, 14);
            else
                dagen = rnd.Next(1, 50);    // lang verblijf

            if (opname.Opnamedatum.AddDays(dagen) > DateTime.Now)
                opname.Ontslagdatum = DateTime.Now;
            else
            {
                opname.Ontslagdatum = opname.Ontslagdatum.AddDays(dagen);
                opname.Ontslagdatum = opname.Ontslagdatum.AddHours(14+rnd.NextDouble()*2);
            }

            opname.Patientnr = patient.Patientnr;
            opname.AfdelingID = rnd.Next(1, afdelingen.Count);
            Debug.WriteLine(opname.AfdelingID.ToString());
            
                
            return opname;
        }

    }

    public class voornaam
    {
        public string Geslacht;
        public string Voornaam;
    }
    public class straat
    {
        public string Postcode;
        public string Naam;
    }
    public class gemeente
    {
        public string PostcodeID;
        public string Postcode;
        public string Naam;
        public string Provincie;
    }


}
