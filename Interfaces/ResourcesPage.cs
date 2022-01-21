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
    public partial class ResourcesPage : Form
    {
        public ResourcesPage()
        {
            InitializeComponent();
        }

        private void ResourcesPage_Load(object sender, EventArgs e)
        {
            // On Load Settings
            Icon = Properties.Resources.SVCC_Icon_Fixed;
        }

        private void ResourcesPage_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormChecker.CheckForms();
        }

        // For launching the repetitive code
        private void LoadBrowser(String title, String source)
        {
            Uri link = new Uri(source);
            Launcher.LaunchWindow(title, link);
            this.Close();
        }

        private void AuthGoogle(String title, String source)
        {
            Uri link = new Uri(source);
            Launcher.AuthGoogle(title, link);
            this.Close();
        }


        // Logos Starts here
        private void GmailLogo_Click(object sender, EventArgs e)
        {
            AuthGoogle("Google Mail", Properties.Resources.gmailURL);
        }

        private void OutlookLogo_Click(object sender, EventArgs e)
        {
            LoadBrowser("Microsoft Outlook", Properties.Resources.hotmailURL);
        }

        private void MerriamLogo_Click(object sender, EventArgs e)
        {
            LoadBrowser("Merriam-Webster Dictionary", Properties.Resources.merriamURL);
        }

        private void GoogleScholarLogo_Click(object sender, EventArgs e)
        {
            LoadBrowser("Google Scholar", Properties.Resources.googleScholarURL);
        }

        private void ResearchGateLogo_Click(object sender, EventArgs e)
        {
            LoadBrowser("Research Gate", Properties.Resources.researchGateURL);
        }

        private void SlideShareLogo_Click(object sender, EventArgs e)
        {
            LoadBrowser("Slide Share", Properties.Resources.sildeshareURL);
        }

        private void ScribdLogo_Click(object sender, EventArgs e)
        {
            LoadBrowser("Scribd", Properties.Resources.scribdURL);
        }

        private void GoolgleDocsLogo_Click(object sender, EventArgs e)
        {
            AuthGoogle("Google Docs", Properties.Resources.googleDocsURL);
        }

        private void MicrosoftOfficeLogo_Click(object sender, EventArgs e)
        {
            LoadBrowser("Microsoft Office 365", Properties.Resources.microsoftOfficeLiveURL);
        }

        private void LucidChartLogo_Click(object sender, EventArgs e)
        {
            LoadBrowser("Lucidchart", Properties.Resources.lucidChartsURL);
        }

        private void PDFConverterLogo_Click(object sender, EventArgs e)
        {
            LoadBrowser("PDF Converter", Properties.Resources.pdfConverterURL);
        }

        private void OmniCalculatorLogo_Click(object sender, EventArgs e)
        {
            LoadBrowser("Omni Calculator", Properties.Resources.omniCalculatorURL);
        }

        private void GeoGebraLogo_Click(object sender, EventArgs e)
        {
            LoadBrowser("GeoGebra Calculator Suite", Properties.Resources.geogebraURL);
        }

        private void GoogleMeetLogo_Click(object sender, EventArgs e)
        {
            AuthGoogle("Google Meet", Properties.Resources.googleMeetURL);
        }

        private void GoogleClassroomLogo_Click(object sender, EventArgs e)
        {
            AuthGoogle("Google Classroom", Properties.Resources.googleClassroomURL);
        }

        private void OneDriveLogo_Click(object sender, EventArgs e)
        {
            LoadBrowser ("Microsoft OneDrive", Properties.Resources.oneDriveURL);
        }

        private void MegaLogo_Click(object sender, EventArgs e)
        {
            LoadBrowser("Mega", Properties.Resources.megaURL);
        }

        private void DropboxLogo_Click(object sender, EventArgs e)
        {
            LoadBrowser("Dropbox", Properties.Resources.dropBoxURL);
        }

        private void ZoomLogo_Click(object sender, EventArgs e)
        {
            LoadBrowser("Zoom",Properties.Resources.zoomURL);
        }

        private void MicrosoftTeamsLogo_Click(object sender, EventArgs e)
        {
            LoadBrowser("Zoom", Properties.Resources.microsoftTeamsURL);
        }

        private void GoogleDriveLogo_Click(object sender, EventArgs e)
        {
            AuthGoogle("Google Drive", Properties.Resources.googleDriveURL);
        }

        private void MediafireLogo_Click(object sender, EventArgs e)
        {
            LoadBrowser("Mediafire", Properties.Resources.mediafireURL);
        }

        private void ImgurLogo_Click(object sender, EventArgs e)
        {
            LoadBrowser("Imgur", Properties.Resources.imgurlURL);
        }

        private void PastebinLogo_Click(object sender, EventArgs e)
        {
            LoadBrowser("Pastebin", Properties.Resources.pastebinURL);
        }

        private void StreamableLogo_Click(object sender, EventArgs e)
        {
            LoadBrowser("Streamable", Properties.Resources.streamableURL);
        }

        private void ZippyshareLogo_Click(object sender, EventArgs e)
        {
            LoadBrowser("Zippyshare", Properties.Resources.zippyshareURL);
        }
    }
}
