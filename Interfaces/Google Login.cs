using Microsoft.Web.WebView2.Core;
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
    public partial class Google_Login : Form
    {

        public Uri forwardLink;
        public String forwardTitle;
        public Google_Login()
        {
            InitializeComponent();
        }

        private void Google_Login_Load(object sender, EventArgs e)
        {

            // Warning
            MessageFunctions messenger = new MessageFunctions();

            messenger.FeatureExperimental();

            // Form load parameters
            Uri uri = new Uri("https://accounts.google.com");
            GoogleAuth.Source = uri;


        }

        private void GoogleAuth_CoreWebView2InitializationCompleted(object sender, Microsoft.Web.WebView2.Core.CoreWebView2InitializationCompletedEventArgs e)
        {
            GoogleAuth.CoreWebView2.Settings.AreDefaultContextMenusEnabled = false;
            GoogleAuth.CoreWebView2.Settings.AreDevToolsEnabled = false;
            GoogleAuth.CoreWebView2.Settings.AreDefaultScriptDialogsEnabled = false;
            GoogleAuth.CoreWebView2.Settings.IsStatusBarEnabled = false;
            GoogleAuth.CoreWebView2.Settings.IsWebMessageEnabled = false;
            GoogleAuth.CoreWebView2.Settings.UserAgent = "Chrome";

            GoogleAuth.CoreWebView2.NewWindowRequested += CoreWebView2_NewWindowRequested;
        }

        private void CoreWebView2_NewWindowRequested(object sender, CoreWebView2NewWindowRequestedEventArgs e)
        {
            e.Handled = true;
        }

        private void GoogleAuth_ContentLoading(object sender, CoreWebView2ContentLoadingEventArgs e)
        {
            if (e.IsErrorPage)
            {
                Launcher.LaunchWindow(forwardTitle, forwardLink);
                this.Close();
            }
        }
    }
}
