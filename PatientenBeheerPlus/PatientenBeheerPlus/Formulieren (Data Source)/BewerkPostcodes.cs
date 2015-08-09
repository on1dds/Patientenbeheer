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
    public partial class BewerkPostcodes : Form
    {
        public BewerkPostcodes()
        {
            InitializeComponent();
        }

        private void postcodeBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.postcodeBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.patientenDataSet);

        }

        private void frmPostcode_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'patientenDataSet.Postcode' table. You can move, or remove it, as needed.
            this.postcodeTableAdapter.Fill(this.patientenDataSet.Postcode);

        }
    }
}
