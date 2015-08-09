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
    public partial class BewerkPersoneel : Form
    {
        public BewerkPersoneel()
        {
            InitializeComponent();
        }

        private void personeelBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.personeelBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.patientenDataSet);

        }

        private void frmPersoneel_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'patientenDataSet.Personeel' table. You can move, or remove it, as needed.
            this.personeelTableAdapter.Fill(this.patientenDataSet.Personeel);

        }
    }
}
