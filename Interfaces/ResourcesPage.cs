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
    public partial class ResourcesPage : Form
    {
        public ResourcesPage()
        {
            InitializeComponent();
        }

        private void ResourcesPage_Load(object sender, EventArgs e)
        {
            // On Load Settings
            Icon = Properties.Resources.SVCC_Icon_Fixed;
        }

        private void ResourcesPage_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormChecker.CheckForms();
        }
    }
}
