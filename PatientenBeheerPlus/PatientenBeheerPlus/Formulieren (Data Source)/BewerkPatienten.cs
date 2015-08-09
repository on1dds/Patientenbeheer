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
    public partial class BewerkPatienten : Form
    {
        public BewerkPatienten()
        {
            InitializeComponent();
        }

        private void patientBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.patientBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.patientenDataSet);

        }

        private void BewerkPatienten_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'patientenDataSet.Patient' table. You can move, or remove it, as needed.
            this.patientTableAdapter.Fill(this.patientenDataSet.Patient);

        }
    }
}
