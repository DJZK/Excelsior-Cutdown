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

  
    public partial class Browser : Form
    {
        public Boolean popup = false;
        public Uri link;
        MessageFunctions messenger = new MessageFunctions();
        public Browser()
        {
            InitializeComponent();
        }

        private void Browser_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormChecker.CheckForms();
        }

        private void Browser_Load(object sender, EventArgs e)
        {
            // Form
            Icon = Properties.Resources.SVCC_Icon_Fixed;


            // WebView
            if (popup)
            {
                WebBrowser.Source = link;
            }
            else
            {
                WebBrowser.Source = new Uri("https://google.com/");
            }
            
           

        }

        private void Browser_Resize(object sender, EventArgs e)
        {

            // Panel
            panel1.Width = Width;

            // Addressbar
            AddressText.Width = panel1.Width - 180;

            // Button
            ButtonGo.Location = new Point(AddressText.Location.X + AddressText.Width + 2, ButtonGo.Location.Y);
            ButtonNew.Location = new Point(ButtonGo.Location.X + ButtonGo.Width + 2, ButtonGo.Location.Y);
          

            // Webview size
            WebBrowser.Width = Width - 15;
            WebBrowser.Height = Height - 64;

        }

        private void WebBrowser_CoreWebView2InitializationCompleted(object sender, Microsoft.Web.WebView2.Core.CoreWebView2InitializationCompletedEventArgs e)
        {
            // Specific setting change
   
            WebBrowser.CoreWebView2.Settings.AreDevToolsEnabled = false;
            WebBrowser.CoreWebView2.Settings.IsWebMessageEnabled = false;
            WebBrowser.CoreWebView2.Settings.AreDefaultScriptDialogsEnabled = false;
            WebBrowser.CoreWebView2.NewWindowRequested += CoreWebView2_NewWindowRequested;
        }

        private void CoreWebView2_NewWindowRequested(object sender, Microsoft.Web.WebView2.Core.CoreWebView2NewWindowRequestedEventArgs e)
        {
            Browser brow = new Browser();
            brow.popup = true;
            brow.link = new Uri (e.Uri);
            brow.Show();
         
            
            e.Handled = true;
        }

        private void ButtonNew_Click(object sender, EventArgs e)
        {
            Browser brow = new Browser();
            brow.Show();
        }

        private void ButtonGo_Click(object sender, EventArgs e)
        {
            try
            {
                if (AddressText.Text.Contains("http"))
                {
                    WebBrowser.Source = new Uri(AddressText.Text);
                }

                else
                {
                    WebBrowser.Source = new Uri("https://" + AddressText.Text);
                }
               
            }

            catch (Exception)
            {
                WebBrowser.Source = new Uri("https://www.google.com/search?q=" + AddressText.Text);
            }
            
        }

        private void WebBrowser_NavigationCompleted(object sender, Microsoft.Web.WebView2.Core.CoreWebView2NavigationCompletedEventArgs e)
        {
            pageNameToolStripMenuItem.Text = WebBrowser.CoreWebView2.DocumentTitle;
            AddressText.Text = WebBrowser.CoreWebView2.Source;
            ReloadPicutre.Enabled = true;
            BackPicture.Enabled = true;
            ReloadPicutre.Visible = true;
            ButtonGo.Enabled = true;

            Cursor.Current = Cursors.Default;
            WebBrowser.Cursor = Cursors.Default;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            WebBrowser.Refresh();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            WebBrowser.GoBack();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            WebBrowser.Source = new Uri("https://google.com");
        }

        private void launchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Launcher.LaunchWindow("resourcesPage");
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Browser brow = new Browser();
            brow.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (messenger.ExitStatementConfirm())
            {
                this.Close();
            }
        }

        private void contributeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Launcher.LaunchWindow("donate");
        }

        private void aboutUsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Launcher.LaunchWindow("credits");
        }

        private void WebBrowser_ContentLoading(object sender, Microsoft.Web.WebView2.Core.CoreWebView2ContentLoadingEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            WebBrowser.Cursor = Cursors.WaitCursor;
            ReloadPicutre.Enabled = false;
            ReloadPicutre.Visible = false;
            BackPicture.Enabled = false;
            ButtonGo.Enabled = false;
            pageNameToolStripMenuItem.Text = "Loading....";
           
        }
    }
}
