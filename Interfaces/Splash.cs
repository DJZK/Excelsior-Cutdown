using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Excelsior.Interfaces
{
    public partial class Splash : Form
    {
        private int seconds;
        public Splash()
        {
            InitializeComponent();
        }

        private void Splash_Load(object sender, EventArgs e)
        {

            // Extra Properties at bootup
            this.Icon = Properties.Resources.SVCC_Icon_Fixed;
            VersionLabel.Text = Properties.Resources.appVersion;

            // Splash Timer
            timer1.Start();
            timer1.Interval = 1000;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            // This should be the loader for the landing page
            seconds += 1;
            if(seconds == 4)
            {
                // MessageBox.Show("Hello world");

                LandingPage lp = new LandingPage();
                lp.Show();
                this.Close();
               
            }
        }
    }
}
