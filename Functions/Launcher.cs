using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project_Excelsior.Interfaces;
using System.Windows.Forms;

namespace Project_Excelsior.Functions
{
    internal class Launcher
    {
        public static void LaunchWindow(String window)
        {

            if (window.Equals("credits"))
            {
                Credits credits = new Credits();
                credits.Show();
                return;
            }

            if (window.Equals("donate"))
            {
                Donate donate = new Donate();
                donate.Show();
                return;
            }

            if (window.Equals("land"))
            {
                FormCollection fc = Application.OpenForms;

                foreach(Form form in fc)
                {
                    if(form.Name == "LandingPage")
                    {
                        form.Show();
                    }
                }
                return;
            }

            if (window.Equals("resourcesPage"))
            {
                ResourcesPage resourcesPage = new ResourcesPage();
                resourcesPage.Show();
                return;
            }

            if (window.Equals("splash"))
            {
                Splash splash = new Splash();
                splash.Show();
                return;
            }
            if (window.Equals("browser"))
            {
                Browser browser = new Browser();
                browser.Show();
                return;
            }
        }

        public static void LaunchWindow(string title, Uri source)
        {
            MainBrowser browser = new MainBrowser
            {
                source = source,
                title = title
            };
            browser.Show();
                

        }

        public static void AuthGoogle(string title, Uri source)
        {
            Google_Login google = new Google_Login
            {
                forwardLink = source,
                forwardTitle = title
            };
            google.Show();


        }
    }
}
