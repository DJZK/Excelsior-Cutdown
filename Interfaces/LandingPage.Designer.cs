namespace Project_Excelsior.Interfaces
{
    partial class LandingPage
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.ExitButton = new System.Windows.Forms.Button();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.Label1 = new System.Windows.Forms.Label();
            this.TimeLabel = new System.Windows.Forms.Label();
            this.VersionLabel = new System.Windows.Forms.Label();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.SvccLogo = new System.Windows.Forms.PictureBox();
            this.ResourcesButton = new System.Windows.Forms.Button();
            this.AboutUsButton = new System.Windows.Forms.Button();
            this.ContributeButton = new System.Windows.Forms.Button();
            this.NewsWindow = new Microsoft.Web.WebView2.WinForms.WebView2();
            this.menuStrip1.SuspendLayout();
            this.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SvccLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NewsWindow)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(681, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(93, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(493, 224);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(101, 30);
            this.ExitButton.TabIndex = 14;
            this.ExitButton.Text = "Quit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // Panel1
            // 
            this.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(22)))), ((int)(((byte)(25)))));
            this.Panel1.Controls.Add(this.Label1);
            this.Panel1.Controls.Add(this.TimeLabel);
            this.Panel1.Controls.Add(this.VersionLabel);
            this.Panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(22)))), ((int)(((byte)(25)))));
            this.Panel1.Location = new System.Drawing.Point(11, 331);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(657, 32);
            this.Panel1.TabIndex = 11;
            // 
            // Label1
            // 
            this.Label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(22)))), ((int)(((byte)(25)))));
            this.Label1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.ForeColor = System.Drawing.Color.White;
            this.Label1.Location = new System.Drawing.Point(199, 9);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(347, 17);
            this.Label1.TabIndex = 9;
            this.Label1.Text = "FOR EVALUATION PURPOSES ONLY. DO NOT DISTRIBUTE";
            this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Label1.Visible = false;
            // 
            // TimeLabel
            // 
            this.TimeLabel.ForeColor = System.Drawing.Color.White;
            this.TimeLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.TimeLabel.Location = new System.Drawing.Point(19, 6);
            this.TimeLabel.Name = "TimeLabel";
            this.TimeLabel.Size = new System.Drawing.Size(196, 20);
            this.TimeLabel.TabIndex = 6;
            this.TimeLabel.Text = "<time>";
            this.TimeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // VersionLabel
            // 
            this.VersionLabel.ForeColor = System.Drawing.Color.White;
            this.VersionLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.VersionLabel.Location = new System.Drawing.Point(221, 6);
            this.VersionLabel.Name = "VersionLabel";
            this.VersionLabel.Size = new System.Drawing.Size(429, 20);
            this.VersionLabel.TabIndex = 5;
            this.VersionLabel.Text = "v1.0";
            this.VersionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TitleLabel
            // 
            this.TitleLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(22)))), ((int)(((byte)(25)))));
            this.TitleLabel.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLabel.ForeColor = System.Drawing.Color.White;
            this.TitleLabel.Location = new System.Drawing.Point(304, 55);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(348, 55);
            this.TitleLabel.TabIndex = 10;
            this.TitleLabel.Text = "Welcome to SVCC System!";
            this.TitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SvccLogo
            // 
            this.SvccLogo.Image = global::Project_Excelsior.Properties.Resources.SVCC_Logo_Fixed;
            this.SvccLogo.Location = new System.Drawing.Point(440, 113);
            this.SvccLogo.Name = "SvccLogo";
            this.SvccLogo.Size = new System.Drawing.Size(77, 72);
            this.SvccLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.SvccLogo.TabIndex = 9;
            this.SvccLogo.TabStop = false;
            // 
            // ResourcesButton
            // 
            this.ResourcesButton.Location = new System.Drawing.Point(364, 177);
            this.ResourcesButton.Name = "ResourcesButton";
            this.ResourcesButton.Size = new System.Drawing.Size(101, 30);
            this.ResourcesButton.TabIndex = 15;
            this.ResourcesButton.Text = "Get Started!";
            this.ResourcesButton.UseVisualStyleBackColor = true;
            this.ResourcesButton.Click += new System.EventHandler(this.ResourcesButton_Click);
            // 
            // AboutUsButton
            // 
            this.AboutUsButton.Location = new System.Drawing.Point(493, 177);
            this.AboutUsButton.Name = "AboutUsButton";
            this.AboutUsButton.Size = new System.Drawing.Size(101, 30);
            this.AboutUsButton.TabIndex = 16;
            this.AboutUsButton.Text = "About Us";
            this.AboutUsButton.UseVisualStyleBackColor = true;
            this.AboutUsButton.Click += new System.EventHandler(this.AboutUsButton_Click);
            // 
            // ContributeButton
            // 
            this.ContributeButton.Location = new System.Drawing.Point(364, 224);
            this.ContributeButton.Name = "ContributeButton";
            this.ContributeButton.Size = new System.Drawing.Size(101, 30);
            this.ContributeButton.TabIndex = 17;
            this.ContributeButton.Text = "Contribute";
            this.ContributeButton.UseVisualStyleBackColor = true;
            this.ContributeButton.Click += new System.EventHandler(this.ContributeButton_Click);
            // 
            // NewsWindow
            // 
            this.NewsWindow.CreationProperties = null;
            this.NewsWindow.DefaultBackgroundColor = System.Drawing.Color.White;
            this.NewsWindow.Location = new System.Drawing.Point(24, 39);
            this.NewsWindow.Name = "NewsWindow";
            this.NewsWindow.Size = new System.Drawing.Size(257, 273);
            this.NewsWindow.TabIndex = 18;
            this.NewsWindow.ZoomFactor = 1D;
            this.NewsWindow.CoreWebView2InitializationCompleted += new System.EventHandler<Microsoft.Web.WebView2.Core.CoreWebView2InitializationCompletedEventArgs>(this.NewsWindow_CoreWebView2InitializationCompleted);
            // 
            // LandingPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 373);
            this.Controls.Add(this.NewsWindow);
            this.Controls.Add(this.ContributeButton);
            this.Controls.Add(this.AboutUsButton);
            this.Controls.Add(this.ResourcesButton);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.Panel1);
            this.Controls.Add(this.TitleLabel);
            this.Controls.Add(this.SvccLogo);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LandingPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Welcome to SVCC!";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LandingPage_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.LandingPage_FormClosed);
            this.Load += new System.EventHandler(this.LandingPage_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SvccLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NewsWindow)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Timer timer1;
        internal System.Windows.Forms.Button ExitButton;
        internal System.Windows.Forms.Panel Panel1;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Label TimeLabel;
        internal System.Windows.Forms.Label VersionLabel;
        internal System.Windows.Forms.Label TitleLabel;
        internal System.Windows.Forms.PictureBox SvccLogo;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        internal System.Windows.Forms.Button ResourcesButton;
        internal System.Windows.Forms.Button AboutUsButton;
        internal System.Windows.Forms.Button ContributeButton;
        private Microsoft.Web.WebView2.WinForms.WebView2 NewsWindow;
    }
}