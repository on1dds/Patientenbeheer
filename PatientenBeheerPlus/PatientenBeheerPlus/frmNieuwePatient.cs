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
    public partial class frmNieuwePatient : Form
    {
        public Patient patient = new Patient();
        List<Postcode> all_postcodes = new List<Postcode>();
        List<Postcode> filtered_postcodes = new List<Postcode>();

        public frmNieuwePatient()
        {
            InitializeComponent();
        }

        private void NieuwePatient_Load(object sender, EventArgs e)
        {
            all_postcodes = PostcodeDB.GetList();
            Testvelden();
        }
        private void btnOK_Click(object sender, EventArgs e)
        {
            patient.Achternaam = txtAchternaam.Text;
            patient.Voornaam = txtVoornaam.Text;
            patient.Straat = txtStraat.Text;
            patient.Huisnummer = txtHuisnr.Text;
            patient.Telefoonnummer = Tools.StripGetal(txtTelefoonnummer.Text);
            patient.Geboortedatum = dtGeboortedatum.Value;
            patient.PostcodeID = PostcodeDB.GetPostcodeID(txtPostcode.Text, cmbGemeente.Text);
            if (patient.PostcodeID == -1)
            {
                MessageBox.Show("Fouten in de ingegeven patient");
            }
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

            patient.PostcodeID = PostcodeDB.GetPostcodeID(txtPostcode.Text, cmbGemeente.Text);
            Testvelden();
        }
        private void txtVeld_Leave(object sender, EventArgs e)
        {
            Testvelden();
        }

        bool Testvelden()
        {
            if (txtAchternaam.Text != "" && txtVoornaam.Text != "" &&
                txtStraat.Text != "" && txtHuisnr.Text != "" &&
                PostcodeDB.GetPostcodeID(txtPostcode.Text, cmbGemeente.Text) != -1 &&
                (Tools.StripGetal(txtTelefoonnummer.Text).Length == 0 ||
                Tools.StripGetal(txtTelefoonnummer.Text).Length == 9 ||
                Tools.StripGetal(txtTelefoonnummer.Text).Length == 10)
                )
            {
                btnOK.Enabled = true;
                return true;
            }
            btnOK.Enabled = false;
            return false;

        }

        private void txtTelefoonnummer_Leave(object sender, EventArgs e)
        {
            txtTelefoonnummer.Text = Tools.ReformatTelefoonnummer(txtTelefoonnummer.Text);
        }
    }
}
