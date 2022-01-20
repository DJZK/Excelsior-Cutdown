using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Project_Excelsior.Functions;


namespace Project_Excelsior.Interfaces
{
    public partial class LandingPage : Form
    {
        public LandingPage()
        {
            InitializeComponent();
        }

        private void LandingPage_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormChecker.CheckForms();
        }

        private void LandingPage_Load(object sender, EventArgs e)
        {
            // Extra properties
            Icon = Properties.Resources.SVCC_Icon_Fixed;
            VersionLabel.Text = Properties.Resources.appVersion;
            timer1.Start();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            TimeLabel.Text = DateTime.Now.ToString();
        }

        private void aboutUsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Launcher.LaunchWindow("credits");
        }

        private void PortalButton_Click(object sender, EventArgs e)
        {
            Uri uri = new Uri(Properties.Resources.svccSystemURL);
            Launcher.LaunchWindow("SVCC System", uri);
            this.Close();
        }

        private void contributeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Launcher.LaunchWindow("donate");
        }

        private void LmsButton_Click(object sender, EventArgs e)
        {
            Uri uri = new Uri(Properties.Resources.neoLMSURL);
            Launcher.LaunchWindow("SVCC NeoLMS", uri);
            this.Close();
        }
    }
}
