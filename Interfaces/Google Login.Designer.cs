﻿namespace Project_Excelsior.Interfaces
{
    partial class Google_Login
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
            this.GoogleAuth = new Microsoft.Web.WebView2.WinForms.WebView2();
            ((System.ComponentModel.ISupportInitialize)(this.GoogleAuth)).BeginInit();
            this.SuspendLayout();
            // 
            // GoogleAuth
            // 
            this.GoogleAuth.CreationProperties = null;
            this.GoogleAuth.DefaultBackgroundColor = System.Drawing.Color.White;
            this.GoogleAuth.Location = new System.Drawing.Point(-2, 0);
            this.GoogleAuth.Name = "GoogleAuth";
            this.GoogleAuth.Size = new System.Drawing.Size(350, 463);
            this.GoogleAuth.TabIndex = 0;
            this.GoogleAuth.ZoomFactor = 1D;
            this.GoogleAuth.CoreWebView2InitializationCompleted += new System.EventHandler<Microsoft.Web.WebView2.Core.CoreWebView2InitializationCompletedEventArgs>(this.GoogleAuth_CoreWebView2InitializationCompleted);
            this.GoogleAuth.ContentLoading += new System.EventHandler<Microsoft.Web.WebView2.Core.CoreWebView2ContentLoadingEventArgs>(this.GoogleAuth_ContentLoading);
            // 
            // Google_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 465);
            this.Controls.Add(this.GoogleAuth);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Google_Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Google Login";
            this.Load += new System.EventHandler(this.Google_Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GoogleAuth)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Web.WebView2.WinForms.WebView2 GoogleAuth;
    }
}