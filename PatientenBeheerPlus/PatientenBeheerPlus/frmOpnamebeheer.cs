using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PatientenBeheerPlus
{
    public partial class frmOpnamebeheer : Form
    {
        public frmOpnamebeheer()
        {
            InitializeComponent();
        }
        private void frmOpnamebeheer_Load(object sender, EventArgs e)
        {
            // voorbereiden picturebox voor totaaloverzicht opnames
            papier = picOpnames.CreateGraphics();

            // voorbereiden combobox voor weergave afdelingen
            all_afdelingen = AfdelingDB.GetList();
            cmbAfdeling.DataSource = all_afdelingen;
            cmbAfdeling.DisplayMember = "Afdelingnaam";
            cmbAfdeling.ValueMember = "AfdelingID";

            RefreshPatientenLijst();
        }
        
        #region -- Patienten

        // fields
        List<Patient> all_patients = new List<Patient>();
        List<Patient> filtered_patients = new List<Patient>();
        public Patient selectedpatient;

        // events
        private void lvLijstPatienten_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvLijstPatienten.SelectedItems.Count > 0)
            {
                int i = lvLijstPatienten.SelectedItems[0].Index;
                selectedpatient = filtered_patients[i];
                selectedopname = null;
                patient_opnames.Clear();
                RefreshPatientDetails();
                btnGenereerOpname.Enabled = true;
            }
            if (patient_opnames != null && patient_opnames.Count > 0)
                selectedopname = patient_opnames.Last();

        }

        private void btnNieuwePatient_Click(object sender, EventArgs e)
        {
            frmNieuwePatient np = new frmNieuwePatient();
            this.Hide();
            np.ShowDialog();
            if (np.DialogResult == DialogResult.OK)
            {
                int i = PatientDB.Add(np.patient);
                all_patients = PatientDB.GetList();
                foreach (Patient p in all_patients)
                    if (i == p.Patientnr)
                        selectedpatient = p;
                RefreshPatientenLijst();
                txtPatientDetail.Text = selectedpatient.ToString();
            }
            this.Show();

        }
        private void btnVerwijderPatient_Click(object sender, EventArgs e)
        {
            if (lvLijstPatienten.SelectedItems.Count > 0)
            {
                int i = lvLijstPatienten.SelectedItems[0].Index;
                selectedpatient = filtered_patients[i];
                PatientDB.Delete(selectedpatient.Patientnr);
                selectedpatient = null;
                RefreshPatientenLijst();
            }
        }
        private void btnGenereerPatient_Click(object sender, EventArgs e)
        {
            PatientDB.Add(Generator.NewPatient());
            RefreshPatientenLijst();
        }
        private void chkZoekPatient_CheckedChanged(object sender, EventArgs e)
        {
            RefreshPatientenLijst();
        }

        private void chkVoorOntslag_CheckedChanged(object sender, EventArgs e)
        {
            RefreshPatientenLijst();
        }

        // routines
        private void RefreshPatientenLijst()
        {
            ToonPatientLijst();

            // haal alle patienten uit de database
            all_patients = PatientDB.GetList();

            if (all_patients != null)
            {
                // kopieer alle patienten naar een gefilterde lijst
                filtered_patients.Clear();
                foreach (Patient p in all_patients)
                {
                    if (chkVoorOntslag.Checked)
                    {
                        List<Opname> opnamelijst = OpnameDB.GetList(p);
                        foreach (Opname opname in opnamelijst)
                        {
                            // enkel de patienten met opnames zonder einddatum
                            if (opname.Opnamedatum == opname.Ontslagdatum)
                            {
                                filtered_patients.Add(p);
                                break;
                            }
                        }
                    }
                    else
                        filtered_patients.Add(p);
                }

                // geef de gefilterde patienten weer in een listview
                lvLijstPatienten.Items.Clear();
                if (filtered_patients.Count != 0)
                {
                    for (int i = 0; i < filtered_patients.Count; i++)
                    {
                        lvLijstPatienten.Items.Add(filtered_patients[i].Patientnr.ToString());
                        lvLijstPatienten.Items[i].SubItems.Add(filtered_patients[i].Voornaam.ToString());
                        lvLijstPatienten.Items[i].SubItems.Add(filtered_patients[i].Achternaam.ToString());
                        lvLijstPatienten.Items[i].SubItems.Add(filtered_patients[i].Straat.ToString() + " " + filtered_patients[i].Huisnummer.ToString());
                        lvLijstPatienten.Items[i].SubItems.Add(PostcodeDB.Get(filtered_patients[i].PostcodeID).Code + " " + PostcodeDB.Get(filtered_patients[i].PostcodeID).Gemeente);
                        lvLijstPatienten.Items[i].SubItems.Add(filtered_patients[i].Geboortedatum.ToShortDateString());
                        lvLijstPatienten.Items[i].SubItems.Add(Tools.FormatTelefoonnummer(filtered_patients[i].Telefoonnummer));
                    }
                    // verschaal kolommen van de patientenlijst op maat van de data
                    lvLijstPatienten.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
                }
            }

            // toon de geseleteerde patient
            RefreshPatientDetails();
        }
        private void RefreshPatientDetails()
        {
            if (selectedpatient != null)
            {
                txtPatientDetail.Text = selectedpatient.ToString();
                // grpOpnameDetails.Show();
            }
            else
            {
                txtPatientDetail.Text = "";
                // grpOpnameDetails.Hide();
            }

            RefreshOpnameLijst();
        }

        private void ToonPatientLijst()
        {
            if (chkZoeken.Checked == true)
            {
                txtZoekPatient.Show();
                chkVoorOntslag.Show();
                btnNieuwePatient.Enabled = true;
                btnVerwijderPatient.Enabled = true;
                btnGenereerPatient.Enabled = true;
                lvLijstPatienten.Enabled = true;
                this.Height = btnNieuwePatient.Top + btnNieuwePatient.Height + (this.Height - this.ClientSize.Height) + 10;
            }
            else
            {
                // schakel de benodigde velden uit
                txtZoekPatient.Hide();
                chkVoorOntslag.Hide();
                btnNieuwePatient.Enabled = false;
                btnVerwijderPatient.Enabled = false;
                btnGenereerPatient.Enabled = false;
                lvLijstPatienten.Enabled = false;
                this.Height = lvLijstPatienten.Top + (this.Height - this.ClientSize.Height);
            }
        }

        #endregion

        #region -- Opnames

        // fields
        Graphics papier;
        SolidBrush brush;

        List<Opname> patient_opnames = new List<Opname>();
        public Opname selectedopname;

        List<Afdeling> all_afdelingen = new List<Afdeling>();

        // events (opnames)
        private void btnNieuweOpname_Click(object sender, EventArgs e)
        {
            if (selectedpatient != null)
            {
                Opname opn = new Opname();
                opn.Patientnr = selectedpatient.Patientnr;
                opn.AfdelingID = 1;
                opn.Opnamedatum = DateTime.Now;
                opn.Ontslagdatum = opn.Opnamedatum;

                OpnameDB.Add(opn);
                selectedopname = opn;
                RefreshOpnameLijst();
            }
        }
        private void btnVerwijderOpname_Click(object sender, EventArgs e)
        {
            if (selectedpatient != null && selectedopname != null)
            {
                OpnameDB.Delete(selectedopname.Opnamenr);
                patient_opnames = OpnameDB.GetList();
                if (patient_opnames.Count > 0)
                {
                    selectedopname = patient_opnames.Last();
                }
                RefreshOpnameLijst();
            }
        }
        private void btnGenereerOpname_Click(object sender, EventArgs e)
        {

            // generereer een nieuwe patient en selecteer die uit de database;
            Opname o = Generator.NewOpname(selectedpatient);
            selectedopname = OpnameDB.Get(OpnameDB.Add(o));
            RefreshOpnameLijst();

        }
        private void picOpnames_MouseClick(object sender, MouseEventArgs e)
        {
            if (selectedpatient != null && patient_opnames.Count > 0)
            {
                int xpos;
                MouseEventArgs mousex = e as MouseEventArgs;
                if (mousex != null)
                {
                    xpos = mousex.X;
                    int punt_kortstebij = 10000;
                    Opname opn_kortstebij = new Opname();

                    foreach (Opname op in patient_opnames)
                    {
                        int x = BerekenOpnamePositie(op);
                        int d = Math.Abs(xpos - x);
                        if (d < punt_kortstebij)
                        {
                            punt_kortstebij = d;
                            opn_kortstebij = op;
                        }
                    }
                    selectedopname = opn_kortstebij;
                    RefreshOpnameLijst();
                }
            }
        }
        private void btnVorigeOpname_Click(object sender, EventArgs e)
        {
            int j = 0;
            for (int i = 0; patient_opnames.Count > i; i++)
                if (patient_opnames[i].Opnamenr == selectedopname.Opnamenr)
                {
                    j = i - 1;
                    i = patient_opnames.Count;
                }
            j = j < 0 ? j = 0 : j;
            selectedopname = patient_opnames[j];

            RefreshOpnameLijst();
            RefreshOpnameDetails();
        }
        private void btnVolgendeOpname_Click(object sender, EventArgs e)
        {
            int j = 0;
            for (int i = 0; patient_opnames.Count > i; i++)
                if (patient_opnames[i].Opnamenr == selectedopname.Opnamenr)
                {
                    j = i + 1;
                    i = patient_opnames.Count;
                }
            j = j > (patient_opnames.Count - 1) ? j = patient_opnames.Count - 1 : j;
            selectedopname = patient_opnames[j];
            RefreshOpnameLijst();
            RefreshOpnameDetails();
        }

        // events (opnamedetails)
        private void cmbAfdeling_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (selectedpatient != null && selectedopname != null)
            {
                selectedopname.AfdelingID = cmbAfdeling.SelectedIndex;
                //RefreshOpnameDetails();
            }

        }
        private void dtpOpnameVan_ValueChanged(object sender, EventArgs e)
        {
            selectedopname.Opnamedatum = dtpOpnameVan.Value;
            RefreshOpnameDetails();
        }
        private void dtpOpnameTot_ValueChanged(object sender, EventArgs e)
        {
            selectedopname.Ontslagdatum = dtpOpnameTot.Value;
            RefreshOpnameDetails();
        }
        private void btnOpnameOpslaan_Click(object sender, EventArgs e)
        {
            if (selectedopname != null)
                OpnameDB.Update(selectedopname);

        }
        private void btnPatientUitschrijven_Click(object sender, EventArgs e)
        {
            Opname o = new Opname();
            o = OpnameDB.Get(selectedopname.Opnamenr);

            if (o.AfdelingID != selectedopname.AfdelingID || o.Opnamedatum != selectedopname.Opnamedatum || o.Ontslagdatum != selectedopname.Ontslagdatum)
            {
                OpnameDB.Update(selectedopname);
                selectedopname = null;
            }
            else
            {
                OpnameDB.Add(selectedopname);
                selectedopname = null;
            }
            RefreshOpnameDetails();
        }

        // routines
        private void RefreshOpnameLijst()
        {
            papier.Clear(Color.LightGray);

            if (selectedpatient != null)
            {
                patient_opnames = OpnameDB.GetList(selectedpatient);
                if (patient_opnames != null)
                {
                    if (patient_opnames.Count > 0)
                    {
                        if (selectedopname == null)
                            selectedopname = patient_opnames.Last();

                        foreach (Opname opn in patient_opnames)
                            TekenPatientOpname(opn);

                    }
                }
            }
            else
            {
                patient_opnames.Clear();
                selectedopname = null;
            }
            RefreshOpnameDetails();
        }
        private void RefreshOpnameDetails()
        {
            if (selectedpatient != null)
            {
                if (patient_opnames != null && patient_opnames.Count > 0)
                {
                    if (selectedopname == null)
                        selectedopname = patient_opnames.Last();

                    // toon opnamedetails
                    dtpOpnameVan.Value = (DateTime)selectedopname.Opnamedatum;
                    dtpOpnameVan.Checked = true;
                    mtbVanTijd.Text = ((DateTime)selectedopname.Opnamedatum).TimeOfDay.ToString();

                    if (selectedopname.Opnamedatum == selectedopname.Ontslagdatum)
                    {
                        // patient is nog niet ontslaan
                        dtpOpnameTot.Value = DateTime.Now;
                        dtpOpnameTot.Checked = false;
                        mtbTotTijd.Text = DateTime.Now.TimeOfDay.ToString();
                    }
                    else
                    {
                        dtpOpnameTot.Value = (DateTime)selectedopname.Ontslagdatum;
                        dtpOpnameTot.Checked = true;
                        mtbTotTijd.Text = ((DateTime)selectedopname.Ontslagdatum).TimeOfDay.ToString();
                    }

                    // vul de afdeling in
                    cmbAfdeling.SelectedValue = selectedopname.AfdelingID;

                    grpOpnameDetails.Show();


                }
                else
                {
                    selectedopname = null;
                    grpOpnameDetails.Hide();
                }
            }
            else
            {
                selectedopname = null;
                grpOpnameDetails.Hide();
            }

            //////////////////////////////////////////

            if (selectedpatient != null)
            {
                if (patient_opnames.Count > 0)
                {


                    // toon alle knoppen om opnamedetails te kunnen bewerken
                    grpOpnameDetails.Show();
                    btnGenereerOpname.Enabled = true;
                    btnNieuweOpname.Enabled = true;
                    btnVerwijderOpname.Enabled = true;
                    btnVolgendeOpname.Enabled = true;
                    btnVorigeOpname.Enabled = true;

                    // toon de toets om op te slaan als er wijzigingen zijn aangebracht
                    // of als er geen ontslagdatum is ingevuld

                    Opname o = new Opname();
                    o = OpnameDB.Get(selectedopname.Opnamenr);

                    if (o.AfdelingID != selectedopname.AfdelingID || o.Opnamedatum != selectedopname.Opnamedatum || o.Ontslagdatum != selectedopname.Ontslagdatum)
                    {
                        btnOpnameOpslaan.Text = "Wijzigingen Opslaan";
                        btnOpnameOpslaan.Show();
                    }
                    else
                    {
                        btnOpnameOpslaan.Hide();
                    }
                    if (selectedopname.Ontslagdatum == selectedopname.Opnamedatum)
                    {
                        btnOpnameOpslaan.Text = "Patient Uitschrijven";
                        btnOpnameOpslaan.Show();
                    }

                }
                else
                {
                    // er is geen opname (of patient) geselecteerd
                    // de toetsen om opnames te bewerken worden dan ook verborgen.
                    btnOpnameOpslaan.Hide();
                    btnNieuweOpname.Enabled = true;
                    grpOpnameDetails.Hide();
                    btnVerwijderOpname.Enabled = false;
                    btnVolgendeOpname.Enabled = false;
                    btnVorigeOpname.Enabled = false;
                }
            }
            else
            {
                // er is geen opname (of patient) geselecteerd
                // de toetsen om opnames te bewerken worden dan ook verborgen.

                btnOpnameOpslaan.Hide();
                grpOpnameDetails.Hide();
                btnGenereerOpname.Enabled = false;
                btnNieuweOpname.Enabled = false;
                btnVerwijderOpname.Enabled = false;
                btnVolgendeOpname.Enabled = false;
                btnVorigeOpname.Enabled = false;
            }
        }

        private void TekenPatientOpname(Opname opn)
        {
            if (opn != null)
            {
                // bereken opnameposities op de tijdsbalk
                float leeftijd = (float)(DateTime.Now.Subtract(selectedpatient.Geboortedatum)).Days;
                float factor = (float)picOpnames.Width / leeftijd;
                float begin = (((DateTime)opn.Opnamedatum).Subtract(selectedpatient.Geboortedatum).Days * factor);
                float einde = (((DateTime)opn.Ontslagdatum).Subtract(selectedpatient.Geboortedatum).Days * factor) - begin;
                einde *= 5;
                if (einde < 5) einde = 5.0f;

                // teken de opname
                if (selectedopname != null)
                {
                    if (opn.Opnamenr == selectedopname.Opnamenr)
                        brush = new SolidBrush(Color.Red);
                    else
                        brush = new SolidBrush(Color.White);

                    papier.FillRectangle(brush, (int)begin, 0, (int)einde, picOpnames.Height);
                }
            }
        }
        private int BerekenOpnamePositie(Opname opn)
        {
            float leeftijd = (float)(DateTime.Now.Subtract(selectedpatient.Geboortedatum)).Days;
            float factor = (float)picOpnames.Width / leeftijd;
            float begin = (((DateTime)opn.Opnamedatum).Subtract(selectedpatient.Geboortedatum).Days * factor);
            return (int)begin;
        }


        #endregion
    }
}

