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
    public partial class OpnameBeheer : Form
    {
        Patient patient;
        List<Opname> alle_opnames = new List<Opname>();

        public OpnameBeheer()
        {
            InitializeComponent();
        }

        private void frmOpnames_Load(object sender, EventArgs e)
        {

        }

        private void OpnameBeheer_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }

        private void btnSelecteerPatient_Click(object sender, EventArgs e)
        {
            SelecteerPatient sp = new SelecteerPatient();
            sp.ShowDialog();
            patient = sp.selectedpatient;
            if(patient != null)
                txtPatientDetails.Text = patient.ToString();
        }

        private void btnNieuwePatient_Click(object sender, EventArgs e)
        {
            frmNieuwePatient np = new frmNieuwePatient();
            np.ShowDialog();
            patient = np.patient;
            if (patient != null)
                txtPatientDetails.Text = patient.ToString();
        }
    }
}
