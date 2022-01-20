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
            // Seconds
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

                LandingPage LP = new LandingPage ();
                LP.Show();
                this.Hide();
                this.Dispose();
            }
        }
    }
}
