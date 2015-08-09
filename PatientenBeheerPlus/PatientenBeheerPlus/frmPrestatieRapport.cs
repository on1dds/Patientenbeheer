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
    public partial class frmPrestatieRapport : Form
    {
        const double speed = .1f;
        double rad=0;
        double x;
        double y;
        double dx = 5f;


        public frmPrestatieRapport()
        {
            InitializeComponent();
        }

        private void frmPrestatieRapport_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            if (x > this.Width - lblnoreport.Width) { dx = -dx; }
            if (x < 0) { x = 0; dx = -dx; };

            x += dx;

            rad += speed;            
            if (rad < 0) rad += 2 * Math.PI;
            if (rad > (2 * Math.PI)) rad -= 2 * Math.PI;

            double r = this.Height / 2;
            int onder = this.Height - 10;

            y = (this.Height-50) -Math.Abs(Math.Sin(rad) * r);

            lblnoreport.Location = new Point((int)x, (int)y);
        }


    }
}
