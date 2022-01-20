using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Excelsior.Functions
{
    internal class FormChecker
    {
        public static void CheckForms()
        {

            // Closes the application if there's no open forms
            if(Application.OpenForms.Count == 0)
            {
                Application.Exit();
            }
        }
    }
}
