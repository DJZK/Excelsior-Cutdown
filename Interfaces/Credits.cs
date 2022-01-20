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
    public partial class Credits : Form
    {
        public Credits()
        {
            InitializeComponent();
        }

        private void Credits_Load(object sender, EventArgs e)
        {
            // Form load details
           
            LabelCredits.Text = Properties.Resources.appVersion;
            Icon = Properties.Resources.SVCC_Icon_Fixed;
        }

        private void Credits_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormChecker.CheckForms();
        }

        private void SVCCFacebookLabel_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(Properties.Resources.svccFacebookURL);
        }

        private void SVCCHomeLabel_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(Properties.Resources.svccHomePage);
        }

        private void SVCCEmailLabel_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("mailto:" + Properties.Resources.svccEmail);
        }

        private void PCSFacebookLabel_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(Properties.Resources.pcsFacebookURL);
        }

        private void PCSStoreLabel_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(Properties.Resources.pcsApkPureURL);
        }

        private void DJZKGithubLabel_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(Properties.Resources.zkGithubURL);
        }

        private void PCSEmailLabel_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("mailto:" + Properties.Resources.carlEmail);
        }

        private void DJZKEmailLabel_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("mailto:" + Properties.Resources.zkEmail);
        }
    }
}
