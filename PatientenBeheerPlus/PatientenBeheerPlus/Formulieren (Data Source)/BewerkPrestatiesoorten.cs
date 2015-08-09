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
    public partial class BewerkPrestatiesoorten : Form
    {
        public BewerkPrestatiesoorten()
        {
            InitializeComponent();
        }

        private void prestatieSoortBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.prestatieSoortBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.patientenDataSet);

        }

        private void frmPrestatieSoort_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'patientenDataSet.PrestatieSoort' table. You can move, or remove it, as needed.
            this.prestatieSoortTableAdapter.Fill(this.patientenDataSet.PrestatieSoort);

        }
    }
}
