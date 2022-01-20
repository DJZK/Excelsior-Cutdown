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
    public partial class Donate : Form
    {
        public Donate()
        {
            InitializeComponent();
        }

        private void Donate_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormChecker.CheckForms();
        }

        private void Donate_Load(object sender, EventArgs e)
        {
            MessageFunctions messenger = new MessageFunctions();
            messenger.Interested();
            // Form load properties
            Icon = Properties.Resources.SVCC_Icon_Fixed;
        }
    }
}
