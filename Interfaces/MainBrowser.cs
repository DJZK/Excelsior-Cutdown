using Project_Excelsior.Functions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Excelsior.Interfaces
{
    public partial class MainBrowser : Form
    {

        public Uri source;
        public String title;
        private Boolean bypass = false;
        private MessageFunctions messenger = new MessageFunctions();

        public MainBrowser()
        {

            InitializeComponent();
        }


        private void MainBrowser_Load(object sender, EventArgs e)
        {
            // Form
            Text = title;
            Icon = Properties.Resources.SVCC_Icon_Fixed;
            PageNameToolStripMenuItem.Text = title;

            // Browser
            WebView2.Source = source;
            WebView2.Size = Size;
            WebView2.Width = Width - 15;
            WebView2.Height = Height - 64;
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void NavigateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WebView2.Refresh();
        }

        private void ForwardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WebView2.GoForward();
        }

        private void BackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WebView2.GoBack();
        }

        private void HomeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (messenger.BackHome())
            {
                WebView2.Enabled = false;
                WebView2.Source = new Uri("https://google.com");
                WebView2.Source = source;
                WebView2.Enabled = true;
            }
        }

        private void SVCCNeoLMSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Uri link = new Uri(Properties.Resources.neoLMSURL);
            Launcher.LaunchWindow("SVCC NeoLMS", link);
        }

        private void MainBrowser_Resize(object sender, EventArgs e)
        {
            // Scrollbars
            WebView2.Size = Size;
            WebView2.Width = Width - 15;
            WebView2.Height = Height - 64;
        }

        private void MainBrowser_FormClosed(object sender, FormClosedEventArgs e)
        {
           

            FormChecker.CheckForms();

        }

        private void SVCCSystemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Uri link = new Uri(Properties.Resources.svccSystemURL);
            Launcher.LaunchWindow("SVCC System", link);
        }

        private void ToolsAndResourcesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Launcher.LaunchWindow("resourcesPage");
        }

        private void MainMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {

            
            Launcher.LaunchWindow("land");
        }

        private void DonateToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Launcher.LaunchWindow("donate");
        }

        private void AboutUsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Launcher.LaunchWindow("credits");
        }

        private void WebView2_CoreWebView2InitializationCompleted(object sender, Microsoft.Web.WebView2.Core.CoreWebView2InitializationCompletedEventArgs e)
        {
            // Specific setting change
            WebView2.CoreWebView2.Settings.AreDefaultContextMenusEnabled = false;
            WebView2.CoreWebView2.Settings.AreDevToolsEnabled = false;
            WebView2.CoreWebView2.Settings.AreDefaultScriptDialogsEnabled = false;
            WebView2.CoreWebView2.Settings.IsStatusBarEnabled = false;
            WebView2.CoreWebView2.Settings.IsWebMessageEnabled = false;

            WebView2.CoreWebView2.NewWindowRequested += CoreWebView2_NewWindowRequested;
        }

        private void CoreWebView2_NewWindowRequested(object sender, Microsoft.Web.WebView2.Core.CoreWebView2NewWindowRequestedEventArgs e)
        {
            Uri handling = new Uri(e.Uri);
            Launcher.LaunchWindow("PopUp: " + title, handling);
            e.Handled = true;
        }

        private void WebView2_NavigationCompleted(object sender, Microsoft.Web.WebView2.Core.CoreWebView2NavigationCompletedEventArgs e)
        {
            PageNameToolStripMenuItem.Text = WebView2.CoreWebView2.DocumentTitle;
        }

        private void MainBrowser_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!(bypass || FormChecker.closeAll))
            {
                if (!messenger.ExitStatementConfirm())
                {
                    e.Cancel = true;
                }

      
            
            
            }
  
        }

        private void LaunchToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Launcher.LaunchWindow("resourcesPage");
        }
    }
}
