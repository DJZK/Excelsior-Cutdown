using Project_Excelsior.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Excelsior
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Startup properties
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // cancels closing of app if it the first form is closed like a mother fucker
            var spash = new Splash();
            spash.Show();
            Application.Run();

        }
    }
}
