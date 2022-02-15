using Project_Excelsior.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

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

            using (var mutex = new Mutex(false, "Excelsior"))
            {
                // TimeSpan.Zero to test the mutex's signal state and
                // return immediately without blocking
                bool isAnotherInstanceOpen = !mutex.WaitOne(TimeSpan.Zero);
                if (isAnotherInstanceOpen)
                {
                    MessageBox.Show("Application already running!", "Application Running", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }


                // Startup properties
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);

                // cancels closing of app if it the first form is closed like a mother fucker
                var spash = new Splash();
                spash.Show();
                Application.Run();
                mutex.ReleaseMutex();
            }
        }
    }
}
