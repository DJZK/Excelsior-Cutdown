using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Project_Excelsior.Functions
{
    internal class FormChecker
    {

        public static Boolean closeAll = false;
        public static Point LastLocation = new Point();

   

        public static void CheckForms()
        {

            // Closes the application if there's no open forms


            FormCollection fc = Application.OpenForms;
            foreach (Form form in fc)
            {
                if (Application.OpenForms.Count == 1 && form.Name == "LandingPage")
                {
                    form.Show();
                }
            }
            if (Application.OpenForms.Count == 0)
            {
                Application.Exit();
            }

           

        }
    }
}
