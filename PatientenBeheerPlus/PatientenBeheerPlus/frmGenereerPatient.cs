using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace PatientenBeheerPlus
{
    public partial class frmGenereerPatient : Form
    {
        static string pad = @"data\";

        static Random rnd = new Random(DateTime.Now.Millisecond);

        // enkele lijsten voor de random generator
        static List<string> achternamen = new List<string>();
        static List<voornaam> voornamen = new List<voornaam>();
        static List<straat> Straatnaam = new List<straat>();

        // de standaard lijsten
        static List<Postcode> gemeentes = new List<Postcode>();
        static List<Patient> patienten = new List<Patient>();
        static List<Opname> opnames = new List<Opname>();
        static List<Afdeling> afdelingen = new List<Afdeling>();
        static List<Prestatie> prestaties = new List<Prestatie>();
        static List<Personeel> personeel = new List<Personeel>();
        static List<Prestatiesoort> prestatiesoort = new List<Prestatiesoort>();

        public frmGenereerPatient()
        {
            InitializeComponent();
        }

        private void frmGenereerPatient_Load(object sender, EventArgs e)
        {

            // lees random data uit bestanden
            LeesAchternamen(pad + "achternamen.csv");
            LeesVoornamen(pad + "voornamen.csv");
            LeesStraten(pad + "straatnamen.csv");
            gemeentes = PostcodeDB.GetList();
            opnames = OpnameDB.GetList();

            afdelingen = AfdelingDB.GetList();
            gemeentes = PostcodeDB.GetList();
            personeel = PersoneelDB.GetList();
            prestatiesoort = PrestatiesoortDB.GetList();

            patienten = PatientDB.GetList();
            lstPatienten.DataSource = patienten;
            lstPatienten.DisplayMember = "Volledigenaam";
            lblPatienten.Text = patienten.Count.ToString() + " Patienten";

            opnames = OpnameDB.GetList();
            lblOpnames.Text = opnames.Count.ToString() + " Opnames";

            prestaties = PrestatiesDB.GetList();
            lblPrestaties.Text = prestaties.Count.ToString() + " Prestaties";
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

        public static Patient MaakPatient()
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

            // bereken geboortedatum (meer oude dan jonge mensen)
            double l = rnd.NextDouble();
            double m = rnd.NextDouble() * 20;
            if (l < 0.10) { }
            else if (l < 0.20) { m += 20; }
            else if (l < 0.35) { m += 40; }
            else if (l < 0.60) { m += 60; }
            else if (l < 0.99) { m += 80; }
            else if (l <= 1) { m = 100 + m / 3; }

            p.Geboortedatum = DateTime.Now.Subtract(TimeSpan.FromDays(m * 365));

            return p;
        }
        public static Opname MaakOpname(Patient patient)
        {
            Opname opname = new Opname();
            List<Opname> opnames = OpnameDB.GetList(patient);

            Afdeling afdeling = new Afdeling();
            TimeSpan leeftijd = new TimeSpan();
            leeftijd = DateTime.Now - patient.Geboortedatum;

            // genereer opnamedatum
            double dagen = (double)rnd.Next(0, leeftijd.Days);         // moet in zijn leven vallen
            opname.Opnamedatum = patient.Geboortedatum.AddDays(dagen);
            opname.Ontslagdatum = opname.Opnamedatum;
            opname.Opnamedatum = opname.Opnamedatum.AddHours(7 + rnd.NextDouble() * 9);

            // genereer ontslagdatum
            int r = rnd.Next(0, 11);
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
                opname.Ontslagdatum = opname.Ontslagdatum.AddHours(14 + rnd.NextDouble() * 2);
            }
            opname.Patientnr = patient.Patientnr;
            opname.AfdelingID = rnd.Next(1, afdelingen.Count);

            return opname;
        }
        public static Prestatie MaakPrestatie(Opname opname)
        {
            Prestatie prestatie = new Prestatie();

            // leg tijdstip vast
            TimeSpan duur = opname.Ontslagdatum - opname.Opnamedatum;
            if (opname.Ontslagdatum == opname.Opnamedatum)
                duur = DateTime.Now - opname.Opnamedatum;
            DateTime tijdstip = opname.Opnamedatum;
            prestatie.Tijdstip = tijdstip.AddSeconds(rnd.Next(0, (int)duur.TotalSeconds-1));         // moet tijdens de opname vallen

            // leg prestatiesoort vast
            prestatie.PrestatieSoortID = rnd.Next(0,prestatiesoort.Count);

            // leg opnamenummer vast
            prestatie.Opnamenr = opname.Opnamenr;

            // leg zorgverstrekker vast
            prestatie.UitvoerderID = rnd.Next(0, personeel.Count());

            // leg PrestatieStatus vast
            prestatie.PrestatieStatusID = rnd.Next(1,4);

            // leg opmerking vast
            prestatie.Opmerking = "";

            return prestatie;
        }


        private void UpdateData()
        {
            patienten = PatientDB.GetList();
            lstPatienten.DataSource = patienten;
            lstPatienten.DisplayMember = "Volledigenaam";
            lblPatienten.Text = patienten.Count.ToString() + " Patienten";
            lstPatienten.SelectedIndex = lstPatienten.Items.Count - 1;

            if (lstPatienten.Items.Count == 0)
            {
                lblOpnames.Text = "0  Opnames";
                lblPrestaties.Text = "0 Prestaties";
                opnames.Clear();
                lstOpnames.DataSource = opnames;
                lstOpnames.DisplayMember = "ListInfo";
                prestaties.Clear();
                lstPrestaties.DataSource = prestaties;
                lstPrestaties.DisplayMember = "ListInfo";
            }

        }

        private void btnGenereer_Click(object sender, EventArgs e)
        {
            // genereer een patient
            PatientDB.Add(MaakPatient());
            patienten = PatientDB.GetList();

            Patient p = patienten.Last();

            // genereer aantal opnames op basis van levensduur (willekeurig, max 1/6 van aantal levensjaren)
            int opnaantal = rnd.Next(0, (int)((DateTime.Now - p.Geboortedatum).TotalDays / 365)) / 10;
            if (opnaantal == 0) opnaantal = 1;
            if (opnaantal > 10) opnaantal = 10;

            for (int i = 0; i < opnaantal; i++)
            {
                Opname opn =  OpnameDB.Get(OpnameDB.Add(MaakOpname(p)));

                // genereer voor elke opname een aantal prestaties
                int d = (int)((opn.Ontslagdatum - opn.Opnamedatum).TotalHours / 10.0d);
                if (d > 20) d = 20;
                for (int j = 0; j < d; j++)
                    PrestatiesDB.Add(MaakPrestatie(opn));
            }

            // genereer een recente opname
            if (rnd.Next(0, 5) < 3)
            {
                Opname opn = MaakOpname(p);
                opn.Opnamedatum = DateTime.Now.Subtract(TimeSpan.FromHours(rnd.NextDouble()*120d));
                opn.Ontslagdatum = opn.Opnamedatum;
                opn = OpnameDB.Get(OpnameDB.Add(opn));

                for(int i=0; i<20;i++)
                    PrestatiesDB.Add(MaakPrestatie(opn));
            }

            
            UpdateData();
        }
        private void lstPatienten_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtPatientinfo.Text = ((Patient)lstPatienten.SelectedValue).ToString();
            opnames = OpnameDB.GetList();
            lblOpnames.Text = opnames.Count.ToString() + " Opnames";
            opnames =
                (
                    from opname in opnames
                    where opname.Patientnr == ((Patient)lstPatienten.SelectedValue).Patientnr
                    orderby opname.Opnamedatum descending
                    select opname
                ).ToList();

            lstOpnames.DataSource = opnames;
            lstOpnames.DisplayMember = "ListInfo";

        }
        private void lstOpnames_SelectedIndexChanged(object sender, EventArgs e)
        {
            prestaties = PrestatiesDB.GetList();
            lblPrestaties.Text = prestaties.Count.ToString() + " Prestaties";
            prestaties =
                (
                    from prestatie in prestaties
                    where prestatie.Opnamenr == ((Opname)lstOpnames.SelectedValue).Opnamenr
                    orderby prestatie.Tijdstip descending
                    select prestatie
                ).ToList();

            lstPrestaties.DataSource = prestaties;
            lstPrestaties.DisplayMember = "ListInfo";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PatientDB.Delete(((Patient)(lstPatienten.SelectedValue)).Patientnr);
            UpdateData();
        }
    }
}
