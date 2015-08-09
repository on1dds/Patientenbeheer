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
    public partial class frmPrestaties : Form
    {

        List<Patient> AllePatienten = new List<Patient>();
        List<Opname> AlleOpnames = new List<Opname>();
        List<Prestatie> AllePrestaties = new List<Prestatie>();

        List<Personeel> Personeel = new List<Personeel>();
        List<Afdeling> Afdelingen = new List<Afdeling>();
        List<Patient> Patienten = new List<Patient>();
        List<Opname> Opnames = new List<Opname>();
        List<Prestatie> Prestaties = new List<Prestatie>();

        public frmPrestaties()
        {
            InitializeComponent();
        }
        private void frmPrestaties_Load(object sender, EventArgs e)
        {
            AllePrestaties = PrestatiesDB.GetList();
            AlleOpnames = OpnameDB.GetList();
            AllePatienten = PatientDB.GetList();

            // Vul lijst met personeelsleden
            Personeel = PersoneelDB.GetList();
            cmbPersoneel.DataSource = Personeel;
            cmbPersoneel.DisplayMember = "Volledigenaam";

            //Vul lijst met Afdelingen
            Afdelingen = AfdelingDB.GetList();
            cmbAfdeling.DataSource = Afdelingen;
            cmbAfdeling.DisplayMember = "Afdelingnaam";

            UpdatePatienten();
        }

        #region -- Methods
        private void UpdatePatienten()
        {
            // laad benodigde tabellen uit de database
            Patienten.Clear();
            foreach (Patient p in AllePatienten)
                Patienten.Add(p);

            Opnames.Clear();
            foreach (Opname o in AlleOpnames)
                Opnames.Add(o);

            // sorteer de patientlijst
            Patienten =
                (
                    from patient in Patienten
                    orderby patient.Achternaam, patient.Voornaam
                    select patient
                ).Distinct().ToList();

            // filter enkel de patienten die nu binnen zijn
            if (chkAlleOpnames.Checked == false)
            {
                Opnames = (from opname in Opnames where opname.Opnamedatum == opname.Ontslagdatum select opname).Distinct().ToList();
                Patienten =
                (
                    from patient in Patienten
                    join opname in Opnames on patient.Patientnr equals opname.Patientnr 
                    orderby patient.Achternaam, patient.Voornaam
                    select patient
                ).Distinct().ToList();
            }

            // filter enkel de patienten van een bepaalde afdeling
            if (chkAlleAfdelingen.Checked == false)
            {
                Patienten =
                (
                    from patient in Patienten
                    join opname in Opnames on patient.Patientnr equals opname.Patientnr
                    where opname.AfdelingID == ((Afdeling)cmbAfdeling.SelectedValue).AfdelingID
                    select patient
                ).Distinct().ToList();
            }

            // update de combobox
            cmbPatienten.DataSource = Patienten;
            cmbPatienten.DisplayMember = "ListInfo";

            UpdateOpnames();
        }
        private void UpdateOpnames()
        {
            Opnames.Clear();
            foreach (Opname o in AlleOpnames)
                Opnames.Add(o);

            if (Patienten.Count > 0)
            {
                // toon enkel opnames van de geselecteerde patient
                Opnames =
                (
                    from opname in Opnames
                    where opname.Patientnr == ((Patient)cmbPatienten.SelectedValue).Patientnr
                    orderby opname.Opnamedatum descending
                    select opname
                ).Distinct().ToList();

                // toon enkel opnames van de geselecteerde afdeling
                if (chkAlleAfdelingen.Checked == false)
                {
                    Opnames =
                    (
                        from opname in Opnames
                        where opname.AfdelingID == ((Afdeling)cmbAfdeling.SelectedValue).AfdelingID
                        orderby opname.Opnamedatum descending
                        select opname
                    ).Distinct().ToList();
                }

                // toon enkel opnames die open staan
                if (chkAlleOpnames.Checked == false)
                {
                    Opnames =
                    (
                        from opname in Opnames
                        where opname.Ontslagdatum == opname.Opnamedatum
                        orderby opname.Opnamedatum descending
                        select opname
                    ).Distinct().ToList();
                }
            }
            else
            {
                Opnames.Clear();
                cmbOpnames.Update();
            }


            // update de combobox
            cmbOpnames.DataSource = Opnames;
            cmbOpnames.DisplayMember = "ListInfo";

            UpdatePrestaties();

        }
        private void UpdatePrestaties()
        {
            // selecteer alle prestaties
            Prestaties.Clear();
            foreach (Prestatie p in AllePrestaties)
                Prestaties.Add(p);

            if (Opnames.Count > 0)
            {


                // toon enkel prestaties van de geselecteerde opname
                Prestaties =
                (
                    from prestaties in Prestaties
                    where prestaties.Opnamenr == ((Opname)cmbOpnames.SelectedValue).Opnamenr
                    orderby prestaties.Tijdstip descending
                    select prestaties
                ).Distinct().ToList();

                // toon enkel prestaties van de geselecteerde datum
                if (dtpPrestatiedatum.Checked == true)
                {
                    Prestaties =
                    (
                        from prestaties in Prestaties
                        where prestaties.Opnamenr == ((Opname)cmbOpnames.SelectedValue).Opnamenr &&
                              prestaties.Tijdstip.ToShortDateString() == dtpPrestatiedatum.Value.ToShortDateString()
                        orderby prestaties.Tijdstip descending
                        select prestaties
                    ).Distinct().ToList();
                }

                // toon enkel prestaties met de status relevant voor de zorgverstrekker
                if (chkNegeerPrestatieStatus.Checked == false)
                {
                    Prestaties =
                    (
                        from prestaties in Prestaties
                        where prestaties.Opnamenr == ((Opname)cmbOpnames.SelectedValue).Opnamenr &&
                              prestaties.PrestatieStatusID == DB.PRESTATIESTATUS_VERSTREKT
                        orderby prestaties.Tijdstip descending
                        select prestaties
                    ).Distinct().ToList();
                }

                // update de combobox
                lstPrestaties.DataSource = Prestaties;
                lstPrestaties.DisplayMember = "ListInfo";

                if (Prestaties.Count == 0)
                    txtPrestatieView.Text = "";
            }
            else
            {
                Prestaties.Clear();
                lstPrestaties.DataSource = null;
                txtPrestatieView.Text = "";
            }
        }


        private void PrestatiesNaarTekstBestand()
        {
            if ((Patient)cmbPatienten.SelectedItem != null)
            {
                if ((Opname)cmbOpnames.SelectedItem != null)
                {
                    // bepaal bestandsnaam met geldige karakters uit datum en tijd van dit ogenblik
                    string fn = Tools.StripGetal(DateTime.Now.ToShortDateString()) + " " + Tools.StripGetal(DateTime.Now.ToShortTimeString()) + " " +
                    ((Patient)cmbPatienten.SelectedValue).Volledigenaam;

                    // open Opslaan Als venster
                    saveTextRapport.FileName = fn + ".txt";
                    saveTextRapport.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";

                    if (saveTextRapport.ShowDialog() == DialogResult.OK)
                        // print rapport af van alle prestaties van de huidige opname van een patient

                        // maak rapporthoofding met de nodige details
                        using (StreamWriter sw = new StreamWriter(saveTextRapport.FileName))
                        {
                            sw.WriteLine("Patient    : " + ((Patient)cmbPatienten.SelectedValue).Volledigenaam);
                            sw.WriteLine("Afdeling   : " + ((Afdeling)cmbAfdeling.SelectedValue).Afdelingnaam);
                            sw.WriteLine("Opnamedatum: " + ((Opname)cmbOpnames.SelectedValue).Opnamedatum.ToLongDateString() + " om " + ((Opname)cmbOpnames.SelectedValue).Opnamedatum.ToShortTimeString());
                            sw.WriteLine("Opnamenr   : " + ((Opname)cmbOpnames.SelectedValue).Opnamenr);
                            sw.WriteLine("------------------------------------------------------------------");

                            // druk de details af van elke prestatie.
                            foreach (Prestatie prestatie in Prestaties)
                                sw.Write(prestatie.ToString() + Environment.NewLine + Environment.NewLine);
                        }
                }
                else
                {
                    MessageBox.Show("Gelieve een opname te selecteren");
                }
            }
            else
            {
                MessageBox.Show("Gelieve een patient te selecteren");
            }
        }

        #endregion

        #region -- Events

        // events onder een button
        private void btnNieuwePrestatie_Click(object sender, EventArgs e)
        {
            frmNieuwePrestatie np = new frmNieuwePrestatie();

            this.Hide();
            np.opname = (Opname)cmbOpnames.SelectedValue;
            this.Show();
            if (np.ShowDialog() == DialogResult.OK)
            {
                np.prestatie.UitvoerderID = ((Personeel)cmbPersoneel.SelectedValue).PersoneelID;
                np.prestatie.Opnamenr = ((Opname)cmbOpnames.SelectedValue).Opnamenr;
                np.prestatie.PrestatieStatusID = DB.PRESTATIESTATUS_VERSTREKT;
                PrestatiesDB.Add(np.prestatie);
                AllePrestaties = PrestatiesDB.GetList();

                UpdatePrestaties();
            }

        }
        private void btnMaakPrestatieRapport_Click(object sender, EventArgs e)
        {
            frmPrestatieRapport r = new frmPrestatieRapport();
            r.Show();
        }
        private void btnPrestatieVerwijderen_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bent u zeker dat u deze prestatie wil verwijderen?",
                            "Opgepast", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                PrestatiesDB.Delete(((Prestatie)lstPrestaties.SelectedValue).Prestatienr);
                AllePrestaties = PrestatiesDB.GetList();
                UpdatePrestaties();
            }
        }
        private void btnSluitPrestatie_Click(object sender, EventArgs e)
        {
            Prestatie prestatie = (Prestatie)lstPrestaties.SelectedValue;
            prestatie.PrestatieStatusID = DB.PRESTATIESTATUS_AFGESLOTEN;
            PrestatiesDB.Update(prestatie);
            AllePrestaties = PrestatiesDB.GetList();
            UpdatePrestaties();
        }
        private void btnPrestatiesNaarTekst_Click(object sender, EventArgs e)
        {
            PrestatiesNaarTekstBestand();
        }

        // events bij wijzigingen van selecties
        private void cmbAfdeling_SelectedIndexChanged(object sender, EventArgs e)
        {

            if ((Patient)cmbPatienten.SelectedValue == null)
            {
                Opnames.Clear();
                cmbOpnames.DataSource = Opnames;
                cmbOpnames.DisplayMember = "ListInfo";
                Prestaties.Clear();
                lstPrestaties.DataSource = Prestaties;
                lstPrestaties.DisplayMember = "ListInfo";
            }
            UpdatePatienten();
            UpdateOpnames();
        }
        private void lstPrestaties_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstPrestaties.DataSource == null)
                txtPrestatieView.Text = "";
            else
                txtPrestatieView.Text = ((Prestatie)lstPrestaties.SelectedValue).ToString();

        }
        private void PrestatieVeld_Gewijzigd(object sender, EventArgs e)
        {
            UpdatePrestaties();
        }
        private void PatientenVeld_Gewijzigd(object sender, EventArgs e)
        {
            UpdatePatienten();
            if (cmbPatienten.Items.Count == 0)
            {
                Opnames.Clear();
                cmbOpnames.DataSource = Opnames;
                cmbOpnames.DisplayMember = "ListInfo";
                Prestaties.Clear();
                lstPrestaties.DataSource = Prestaties;
                lstPrestaties.DisplayMember = "ListInfo";
            }
        }
        private void OpnameVeld_Gewijzigd(object sender, EventArgs e)
        {
            UpdateOpnames();
            //UpdatePatienten();
            if ((Patient)cmbPatienten.SelectedValue == null)
            {
                Opnames.Clear();
                cmbOpnames.DataSource = Opnames;
                cmbOpnames.DisplayMember = "ListInfo";
                Prestaties.Clear();
                lstPrestaties.DataSource = Prestaties;
                lstPrestaties.DisplayMember = "ListInfo";
            }

        }

        #endregion

    }

    
}
