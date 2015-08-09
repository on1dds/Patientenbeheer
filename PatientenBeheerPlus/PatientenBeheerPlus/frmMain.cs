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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Generator.Initialiseer();
            
        }

        private void btnAfdelingen_Click(object sender, EventArgs e)
        {
            BewerkAfdelingen ba = new BewerkAfdelingen();
            this.Hide();
            ba.ShowDialog();
            this.Show();
        }

        private void btnPersoneel_Click(object sender, EventArgs e)
        {
            BewerkPersoneel bp = new BewerkPersoneel();
            this.Hide();
            bp.ShowDialog();
            this.Show();
        }

        private void btnPostcodes_Click(object sender, EventArgs e)
        {
            BewerkPostcodes pc = new BewerkPostcodes();
            this.Hide();
            pc.ShowDialog();
            this.Show();
        }

        private void btnPrestatieSoorten_Click(object sender, EventArgs e)
        {
            BewerkPrestatiesoorten bp = new BewerkPrestatiesoorten();
            this.Hide();
            bp.ShowDialog();
            this.Show();
        }

        private void btnBewerkPatienten_Click(object sender, EventArgs e)
        {
            BewerkPatienten bp = new BewerkPatienten();
            this.Hide();
            bp.ShowDialog();
            this.Show();
        }

        private void btnBeheerOpnames_Click(object sender, EventArgs e)
        {
            frmOpnamebeheer sp = new frmOpnamebeheer();
            this.Hide();
            sp.ShowDialog();
            this.Show();
        }

        private void btnBeheerPrestaties_Click(object sender, EventArgs e)
        {
            frmPrestaties pr = new frmPrestaties();
            this.Hide();
            pr.ShowDialog();
            this.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmGenereerPatient gp = new frmGenereerPatient();
            this.Hide();
            gp.ShowDialog();
            this.Show();
        }
    }
}
