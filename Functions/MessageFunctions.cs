using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Excelsior.Functions
{
    internal class MessageFunctions
    {
        public Boolean ExitStatementConfirm()
        {
            return MessageBox.Show("Are you sure you want to exit? You may lose all your unsaved work!", "Confirm exit", MessageBoxButtons.YesNo, MessageBoxIcon.Warning).Equals(DialogResult.Yes);
        }

        public Boolean ExitAllConfirm()
        {
            return MessageBox.Show("This action would close the SVCC System and all the opened Windows. Any unsaved would might be lost.", "Confirm exit", MessageBoxButtons.YesNo, MessageBoxIcon.Warning).Equals(DialogResult.Yes);
        }

        public Boolean BackHome()
        {
            return MessageBox.Show("Are you sure you want to go back to start page? You may lose all your unsaved work!", "Confirm Reload", MessageBoxButtons.YesNo, MessageBoxIcon.Warning).Equals(DialogResult.Yes);
        }

        public void FeatureAlternative()
        {
            MessageBox.Show("This feature is still under development. It will open your browser as an alternative access to the said app.", "Opening Browser", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        public void Interested()
        {
            MessageBox.Show("Thanks for having the interest to contribute!", "Interested eh...", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        public void FeatureExperimental()
        {
            MessageBox.Show("This feature is experimental. If the functionality failed, please just use the browser... for now...", "Experimental Feature", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
    }
}
