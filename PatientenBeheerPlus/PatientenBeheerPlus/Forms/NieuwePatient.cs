using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Patientenbeheer
{
    public partial class frmNieuwePatient : Form
    {
        public Patient patient = new Patient();
        List<Postcode> all_postcodes = new List<Postcode>();
        List<Postcode> filtered_postcodes = new List<Postcode>();

        public frmNieuwePatient()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            patient.Achternaam = txtAchternaam.Text;
            patient.Voornaam = txtVoornaam.Text;
            patient.Straat = txtStraat.Text;
            patient.Huisnummer = txtHuisnr.Text;
            patient.Telefoonnummer = txtTelefoonnummer.Text;
            patient.PostcodeID = PostcodeDB.GetPostcodeID(txtPostcode.Text, cmbGemeente.Text);

            int i = PatientDB.AddPatient(patient);
            patient = PatientDB.GetPatient(i);

            if (patient != null)
                this.DialogResult = DialogResult.OK;
        }

        private void frmNieuwePatient_Load(object sender, EventArgs e)
        {
            all_postcodes = PostcodeDB.GetPostcodeLijst();
        }

        private void txtPostcode_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPostcode_Leave(object sender, EventArgs e)
        {
            string s = (txtPostcode.Text).Trim();
            filtered_postcodes.Clear();

            foreach (Postcode pc in all_postcodes)
                if (pc.Code == s)
                    filtered_postcodes.Add(pc);

            cmbGemeente.Items.Clear();
            foreach (Postcode pc in filtered_postcodes)
                cmbGemeente.Items.Add(pc.Gemeente);
            if (cmbGemeente.Items.Count > 0)
                cmbGemeente.SelectedIndex = 0;

            // patient.PostcodeID = PostcodeDB.GetPostcodeID(txtPostcode.Text, cmbGemeente.Text);
        }
    }
}
