using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PatientenBeheerPlus
{
    public partial class frmNieuwePrestatie : Form
    {
        public Opname opname = new Opname();
        public Prestatie prestatie = new Prestatie();

        List<Prestatiesoort> SoortNamen = new List<Prestatiesoort>();
        List<Prestatiesoort> SoortDetails = new List<Prestatiesoort>();

        public frmNieuwePrestatie()
        {
            InitializeComponent();
        }
        private void frmNieuwePrestatie_Load(object sender, EventArgs e)
        {
            // Toon in de titel over welke patient de prestatie gaat
            this.Text = PatientDB.Get(opname.Patientnr).Volledigenaam + ": Prestatie toevoegen";

            // Vul Listbox met prestatienamen
            List<string> soortnamen = new List<string>();
            SoortNamen = PrestatiesoortDB.GetList();

            soortnamen.Clear();

            foreach (Prestatiesoort soort in SoortNamen)
                soortnamen.Add(soort.Naam);
            soortnamen = soortnamen.OrderBy(s => s).Distinct().ToList();        // haal de dubbels uit de lijst

            cmbPrestatieNaam.Items.Clear();
            foreach (string s in soortnamen)
                cmbPrestatieNaam.Items.Add(s);
            cmbPrestatieNaam.SelectedIndex = 0;

            // stel tijd goed in
            if (opname.Opnamedatum != opname.Ontslagdatum)
            {
                dtpPrestatieTijdstip.MinDate = opname.Opnamedatum;
                dtpPrestatieTijdstip.MaxDate = opname.Ontslagdatum;
                //dtpPrestatieTijdstip.Value = opname.Ontslagdatum;
            }

            // Koppel de lijst met prestatiedetails aan de detaillijst
            lstPrestatieDetails.DataSource = SoortDetails;
            lstPrestatieDetails.DisplayMember = "Omschrijving";

        }

        private void btnPrestatieToevoegen_Click(object sender, EventArgs e)
        {
            Prestatie p = new Prestatie();
            p.PrestatieSoortID = ((Prestatiesoort)lstPrestatieDetails.SelectedValue).PrestatieSoortID;
            p.Tijdstip = dtpPrestatieTijdstip.Value;
            p.PrestatieStatusID = DB.PRESTATIESTATUS_VERSTREKT;
            p.Opmerking = txtOpmerking.Text;
        }

        private void dtpPrestatieTijdstip_Leave(object sender, EventArgs e)
        {
            checkDatum();
        }
        private void cmbPrestatieNaam_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            // pas de lijst aan van prestatiedetails wanneer de prestatiegroep wijzigt
            SoortDetails =
                (
                from ps in SoortNamen
                where ps.Naam == cmbPrestatieNaam.Text
                orderby ps.Omschrijving
                select ps
                ).Distinct().ToList();
            lstPrestatieDetails.DataSource = SoortDetails;
            lstPrestatieDetails.DisplayMember = "Omschrijving";
        }

        private void btnPrestatieToevoegen_Click_1(object sender, EventArgs e)
        {
                prestatie.Tijdstip = dtpPrestatieTijdstip.Value;
                prestatie.Opmerking = txtOpmerking.Text;
                prestatie.PrestatieSoortID = ((Prestatiesoort)lstPrestatieDetails.SelectedValue).PrestatieSoortID;
                prestatie.Opnamenr = opname.Opnamenr;
                prestatie.PrestatieStatusID = DB.PRESTATIESTATUS_VERSTREKT;
        }

        private bool checkDatum()
        {
            if (dtpPrestatieTijdstip.Value < opname.Opnamedatum)
            {
                MessageBox.Show("Het tijdstip van een prestatie" + Environment.NewLine +
                "moet steeds binnen een opname vallen!",
                "Opgepast", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dtpPrestatieTijdstip.Value = opname.Opnamedatum;
                return false;
            }

            if (opname.Opnamedatum != opname.Ontslagdatum)
                if (dtpPrestatieTijdstip.Value > opname.Ontslagdatum)
                {
                    MessageBox.Show("Het tijdstip van een prestatie" + Environment.NewLine +
                        "moet steeds binnen een opname vallen!",
                        "Opgepast", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    dtpPrestatieTijdstip.Value = opname.Ontslagdatum;
                    return false;
                }
            return true;
        }
    }
}
