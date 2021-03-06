﻿using System;
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
    public partial class BewerkAfdelingen : Form
    {
        public BewerkAfdelingen()
        {
            InitializeComponent();
        }

        private void afdelingBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.afdelingBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.patientenDataSet);

        }

        private void frmAfdeling_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'patientenDataSet.Afdeling' table. You can move, or remove it, as needed.
            this.afdelingTableAdapter.Fill(this.patientenDataSet.Afdeling);

        }
    }
}
