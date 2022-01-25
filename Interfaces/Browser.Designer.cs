namespace Project_Excelsior.Interfaces
{
    partial class Browser
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.pageNameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.launchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contributeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutUsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ButtonNew = new System.Windows.Forms.Button();
            this.ButtonGo = new System.Windows.Forms.Button();
            this.ReloadPicutre = new System.Windows.Forms.PictureBox();
            this.BackPicture = new System.Windows.Forms.PictureBox();
            this.HomePicture = new System.Windows.Forms.PictureBox();
            this.AddressText = new System.Windows.Forms.TextBox();
            this.WebBrowser = new Microsoft.Web.WebView2.WinForms.WebView2();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ReloadPicutre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BackPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HomePicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WebBrowser)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pageNameToolStripMenuItem,
            this.fileToolStripMenuItem,
            this.launchToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(631, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // pageNameToolStripMenuItem
            // 
            this.pageNameToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.pageNameToolStripMenuItem.Enabled = false;
            this.pageNameToolStripMenuItem.Name = "pageNameToolStripMenuItem";
            this.pageNameToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.pageNameToolStripMenuItem.Text = "Browser";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newToolStripMenuItem.ShowShortcutKeys = false;
            this.newToolStripMenuItem.Size = new System.Drawing.Size(93, 22);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(93, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // launchToolStripMenuItem
            // 
            this.launchToolStripMenuItem.Name = "launchToolStripMenuItem";
            this.launchToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.launchToolStripMenuItem.Text = "Launch";
            this.launchToolStripMenuItem.Click += new System.EventHandler(this.launchToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contributeToolStripMenuItem,
            this.aboutUsToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // contributeToolStripMenuItem
            // 
            this.contributeToolStripMenuItem.Name = "contributeToolStripMenuItem";
            this.contributeToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.contributeToolStripMenuItem.Text = "Contribute";
            this.contributeToolStripMenuItem.Click += new System.EventHandler(this.contributeToolStripMenuItem_Click);
            // 
            // aboutUsToolStripMenuItem
            // 
            this.aboutUsToolStripMenuItem.Name = "aboutUsToolStripMenuItem";
            this.aboutUsToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.aboutUsToolStripMenuItem.Text = "About Us";
            this.aboutUsToolStripMenuItem.Click += new System.EventHandler(this.aboutUsToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ButtonNew);
            this.panel1.Controls.Add(this.ButtonGo);
            this.panel1.Controls.Add(this.ReloadPicutre);
            this.panel1.Controls.Add(this.BackPicture);
            this.panel1.Controls.Add(this.HomePicture);
            this.panel1.Controls.Add(this.AddressText);
            this.panel1.Location = new System.Drawing.Point(0, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(628, 30);
            this.panel1.TabIndex = 1;
            // 
            // ButtonNew
            // 
            this.ButtonNew.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonNew.Location = new System.Drawing.Point(609, 4);
            this.ButtonNew.Name = "ButtonNew";
            this.ButtonNew.Size = new System.Drawing.Size(21, 23);
            this.ButtonNew.TabIndex = 5;
            this.ButtonNew.Text = "+";
            this.ButtonNew.UseVisualStyleBackColor = true;
            this.ButtonNew.Click += new System.EventHandler(this.ButtonNew_Click);
            // 
            // ButtonGo
            // 
            this.ButtonGo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonGo.Location = new System.Drawing.Point(562, 4);
            this.ButtonGo.Name = "ButtonGo";
            this.ButtonGo.Size = new System.Drawing.Size(45, 23);
            this.ButtonGo.TabIndex = 4;
            this.ButtonGo.Text = "Go!";
            this.ButtonGo.UseVisualStyleBackColor = true;
            this.ButtonGo.Click += new System.EventHandler(this.ButtonGo_Click);
            // 
            // ReloadPicutre
            // 
            this.ReloadPicutre.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ReloadPicutre.Image = global::Project_Excelsior.Properties.Resources.Reload;
            this.ReloadPicutre.Location = new System.Drawing.Point(67, 2);
            this.ReloadPicutre.Name = "ReloadPicutre";
            this.ReloadPicutre.Size = new System.Drawing.Size(25, 25);
            this.ReloadPicutre.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ReloadPicutre.TabIndex = 3;
            this.ReloadPicutre.TabStop = false;
            this.ReloadPicutre.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // BackPicture
            // 
            this.BackPicture.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BackPicture.Image = global::Project_Excelsior.Properties.Resources.Back;
            this.BackPicture.Location = new System.Drawing.Point(38, 2);
            this.BackPicture.Name = "BackPicture";
            this.BackPicture.Size = new System.Drawing.Size(25, 25);
            this.BackPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BackPicture.TabIndex = 2;
            this.BackPicture.TabStop = false;
            this.BackPicture.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // HomePicture
            // 
            this.HomePicture.Cursor = System.Windows.Forms.Cursors.Hand;
            this.HomePicture.Image = global::Project_Excelsior.Properties.Resources.home;
            this.HomePicture.Location = new System.Drawing.Point(7, 2);
            this.HomePicture.Name = "HomePicture";
            this.HomePicture.Size = new System.Drawing.Size(25, 25);
            this.HomePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.HomePicture.TabIndex = 1;
            this.HomePicture.TabStop = false;
            this.HomePicture.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // AddressText
            // 
            this.AddressText.Location = new System.Drawing.Point(95, 5);
            this.AddressText.Name = "AddressText";
            this.AddressText.Size = new System.Drawing.Size(463, 20);
            this.AddressText.TabIndex = 0;
            // 
            // WebBrowser
            // 
            this.WebBrowser.CreationProperties = null;
            this.WebBrowser.DefaultBackgroundColor = System.Drawing.Color.White;
            this.WebBrowser.Location = new System.Drawing.Point(0, 61);
            this.WebBrowser.Name = "WebBrowser";
            this.WebBrowser.Size = new System.Drawing.Size(631, 332);
            this.WebBrowser.TabIndex = 2;
            this.WebBrowser.ZoomFactor = 1D;
            this.WebBrowser.CoreWebView2InitializationCompleted += new System.EventHandler<Microsoft.Web.WebView2.Core.CoreWebView2InitializationCompletedEventArgs>(this.WebBrowser_CoreWebView2InitializationCompleted);
            this.WebBrowser.NavigationCompleted += new System.EventHandler<Microsoft.Web.WebView2.Core.CoreWebView2NavigationCompletedEventArgs>(this.WebBrowser_NavigationCompleted);
            this.WebBrowser.ContentLoading += new System.EventHandler<Microsoft.Web.WebView2.Core.CoreWebView2ContentLoadingEventArgs>(this.WebBrowser_ContentLoading);
            // 
            // Browser
            // 
            this.AcceptButton = this.ButtonGo;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 394);
            this.Controls.Add(this.WebBrowser);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(647, 433);
            this.Name = "Browser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Browser";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Browser_FormClosed);
            this.Load += new System.EventHandler(this.Browser_Load);
            this.Resize += new System.EventHandler(this.Browser_Resize);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ReloadPicutre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BackPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HomePicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WebBrowser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem launchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pageNameToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox AddressText;
        private Microsoft.Web.WebView2.WinForms.WebView2 WebBrowser;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.PictureBox ReloadPicutre;
        private System.Windows.Forms.PictureBox BackPicture;
        private System.Windows.Forms.PictureBox HomePicture;
        private System.Windows.Forms.Button ButtonGo;
        private System.Windows.Forms.Button ButtonNew;
        private System.Windows.Forms.ToolStripMenuItem contributeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutUsToolStripMenuItem;
    }
}