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
    public partial class SelecteerPatient : Form
    {
        // Fields

        public Patient selectedpatient;
        List<Patient> all_patients = new List<Patient>();
        List<Patient> filtered_patients = new List<Patient>();

        // Constructor
        public SelecteerPatient()
        {
            InitializeComponent();
        }

        // Methods
        void UpdatePatientenLijst()
        {
            all_patients = PatientDB.GetPatientenLijst();           // laad alle patienten
            filtered_patients.Clear();

            foreach (Patient p in all_patients)             // laad de gefilterde lijst met alle patienten
                filtered_patients.Add(p);                   // toon de lijst met patienten

            lvResultaat.Items.Clear();

            for (int i = 0; i < filtered_patients.Count; i++)
            {
                lvResultaat.Items.Add(filtered_patients[i].Patientnr.ToString());
                lvResultaat.Items[i].SubItems.Add(filtered_patients[i].Voornaam.ToString());
                lvResultaat.Items[i].SubItems.Add(filtered_patients[i].Achternaam.ToString());
                lvResultaat.Items[i].SubItems.Add(filtered_patients[i].Straat.ToString() + " " + filtered_patients[i].Huisnummer.ToString());
                lvResultaat.Items[i].SubItems.Add(PostcodeDB.Get(filtered_patients[i].PostcodeID).Code);
                lvResultaat.Items[i].SubItems.Add(PostcodeDB.Get(filtered_patients[i].PostcodeID).Gemeente);
                lvResultaat.Items[i].SubItems.Add(filtered_patients[i].Geboortedatum.ToShortDateString());
            }
            lvResultaat.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
        }

        // Private Events
        void SelecteerPatient_Load(object sender, EventArgs e)
        {
            string[] patienttabel = { "ID", "Voornaam", "Achternaam", "Straat + nr", "PC", "Gemeente", "Geboortedatum" };

            lvResultaat.Items.Clear();
            foreach (string kolom in patienttabel)
                lvResultaat.Columns.Add(kolom);

            UpdatePatientenLijst();
        }

        void SelectieAnnuleren(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        
        void Selecteren(object sender, EventArgs e)
        {
            if(selectedpatient != null)
                this.DialogResult = DialogResult.OK;
        }
        void Verwijderen(object sender, EventArgs e)
        {
            int i = lvResultaat.SelectedItems[0].Index;
            PatientDB.DeletePatient(selectedpatient.Patientnr);
            UpdatePatientenLijst();
            selectedpatient = null;
            txtPatientDetail.Text = "";

        }
        void WijzigSelectie(object sender, EventArgs e)
        {
            if (lvResultaat.SelectedItems.Count > 0)
            {
                int i = lvResultaat.SelectedItems[0].Index;
                selectedpatient = filtered_patients[i];
                txtPatientDetail.Text = selectedpatient.ToString();
            }
        }

        private void btnNieuwePatient_Click(object sender, EventArgs e)
        {
            frmNieuwePatient np = new frmNieuwePatient();
            DialogResult dr = np.ShowDialog();
            if (dr == DialogResult.OK)
            {
                UpdatePatientenLijst();
                selectedpatient = filtered_patients[filtered_patients.Count - 1];
                txtPatientDetail.Text = selectedpatient.ToString();
            }
        }
    }
}
