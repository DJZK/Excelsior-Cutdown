using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
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

            Uri path = new Uri(@"file:\\\" + Environment.CurrentDirectory + @"\news.html");
            String path2 = Environment.CurrentDirectory + @"\news.html";

            if (File.Exists(path2))
            {
                File.WriteAllText(path2, string.Empty);
                File.WriteAllText(path2, Properties.Resources.newsString);
            }

            else
            {
                File.WriteAllText(path2,Properties.Resources.newsString);
            }
           

            NewsWindow.Source = path;
           

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            TimeLabel.Text = DateTime.Now.ToString();
        }

       

        private void PortalButton_Click(object sender, EventArgs e)
        {
            Uri uri = new Uri(Properties.Resources.svccSystemURL);
            Launcher.LaunchWindow("SVCC System", uri);
            this.Hide();
        }



        private void LmsButton_Click(object sender, EventArgs e)
        {
            Uri uri = new Uri(Properties.Resources.neoLMSURL);
            Launcher.LaunchWindow("SVCC NeoLMS", uri);
            this.Hide();
        }

        private void ResourcesButton_Click(object sender, EventArgs e)
        {
            FormChecker.LastLocation.X = Location.X + 20;
            FormChecker.LastLocation.Y = Location.Y + 20;
            Launcher.LaunchWindow("resourcesPage");
            this.Close();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            MessageFunctions messenger = new MessageFunctions();
          
                FormChecker.closeAll = true;
                Application.Exit();
     
        }



        private void LandingPage_FormClosing(object sender, FormClosingEventArgs e)
        {
            
            if (!(FormChecker.closeAll || Application.OpenForms.Count == 1))
            {
                e.Cancel = true;
                Hide();
            }
           
        }

        private void AboutUsButton_Click(object sender, EventArgs e)
        {
            FormChecker.LastLocation.X = Location.X + 20;
            FormChecker.LastLocation.Y = Location.Y + 20;
            Launcher.LaunchWindow("credits");
        }

        private void ContributeButton_Click(object sender, EventArgs e)
        {
            FormChecker.LastLocation.X = Location.X + 20;
            FormChecker.LastLocation.Y = Location.Y + 20;
            Launcher.LaunchWindow("donate");
        }

        private void NewsWindow_CoreWebView2InitializationCompleted(object sender, Microsoft.Web.WebView2.Core.CoreWebView2InitializationCompletedEventArgs e)
        {

            // Specific setting change
            NewsWindow.CoreWebView2.Settings.AreDefaultContextMenusEnabled = false;
            NewsWindow.CoreWebView2.Settings.AreDevToolsEnabled = false;
            NewsWindow.CoreWebView2.Settings.AreDefaultScriptDialogsEnabled = false;
            NewsWindow.CoreWebView2.Settings.IsStatusBarEnabled = false;
            NewsWindow.CoreWebView2.Settings.IsWebMessageEnabled = false;

            NewsWindow.CoreWebView2.NewWindowRequested += CoreWebView2_NewWindowRequested;
        }

        private void CoreWebView2_NewWindowRequested(object sender, Microsoft.Web.WebView2.Core.CoreWebView2NewWindowRequestedEventArgs e)
        {
            System.Diagnostics.Process.Start(e.Uri);
            e.Handled = true;
        }
    }
}
