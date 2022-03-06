namespace Project_Excelsior.Interfaces
{
    partial class Splash
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Splash));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Panel1 = new System.Windows.Forms.Panel();
            this.VersionLabel = new System.Windows.Forms.Label();
            this.SvccLogo = new System.Windows.Forms.PictureBox();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.CAWLabel = new System.Windows.Forms.Label();
            this.PixelCowboyLogo = new System.Windows.Forms.PictureBox();
            this.CAWLogo = new System.Windows.Forms.PictureBox();
            this.Panel2 = new System.Windows.Forms.Panel();
            this.LoadingLabel = new System.Windows.Forms.Label();
            this.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SvccLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PixelCowboyLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CAWLogo)).BeginInit();
            this.Panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Panel1
            // 
            this.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(22)))), ((int)(((byte)(25)))));
            this.Panel1.Controls.Add(this.VersionLabel);
            this.Panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(22)))), ((int)(((byte)(25)))));
            this.Panel1.Location = new System.Drawing.Point(12, 12);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(310, 32);
            this.Panel1.TabIndex = 8;
            // 
            // VersionLabel
            // 
            this.VersionLabel.ForeColor = System.Drawing.Color.White;
            this.VersionLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.VersionLabel.Location = new System.Drawing.Point(208, 5);
            this.VersionLabel.Name = "VersionLabel";
            this.VersionLabel.Size = new System.Drawing.Size(99, 20);
            this.VersionLabel.TabIndex = 6;
            this.VersionLabel.Text = "v1.0";
            this.VersionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // SvccLogo
            // 
            this.SvccLogo.Image = global::Project_Excelsior.Properties.Resources.SVCC_Logo_Fixed;
            this.SvccLogo.Location = new System.Drawing.Point(89, 61);
            this.SvccLogo.Name = "SvccLogo";
            this.SvccLogo.Size = new System.Drawing.Size(157, 157);
            this.SvccLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.SvccLogo.TabIndex = 7;
            this.SvccLogo.TabStop = false;
            // 
            // TitleLabel
            // 
            this.TitleLabel.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLabel.Location = new System.Drawing.Point(34, 233);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(267, 85);
            this.TitleLabel.TabIndex = 9;
            this.TitleLabel.Text = "St. Vincent College of Cabuyao";
            this.TitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CAWLabel
            // 
            this.CAWLabel.BackColor = System.Drawing.Color.Transparent;
            this.CAWLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CAWLabel.ForeColor = System.Drawing.Color.Transparent;
            this.CAWLabel.Location = new System.Drawing.Point(135, 3);
            this.CAWLabel.Name = "CAWLabel";
            this.CAWLabel.Size = new System.Drawing.Size(172, 70);
            this.CAWLabel.TabIndex = 5;
            this.CAWLabel.Text = "This app is provided by Computer Automation Wizards of SVCC, developed and mainta" +
    "ined by Pixel Cowboy Studios.";
            this.CAWLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // PixelCowboyLogo
            // 
            this.PixelCowboyLogo.Image = global::Project_Excelsior.Properties.Resources.Pixel_Cowboy_old;
            this.PixelCowboyLogo.Location = new System.Drawing.Point(5, 9);
            this.PixelCowboyLogo.Name = "PixelCowboyLogo";
            this.PixelCowboyLogo.Size = new System.Drawing.Size(58, 58);
            this.PixelCowboyLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PixelCowboyLogo.TabIndex = 4;
            this.PixelCowboyLogo.TabStop = false;
            // 
            // CAWLogo
            // 
            this.CAWLogo.Image = global::Project_Excelsior.Properties.Resources.CAW;
            this.CAWLogo.Location = new System.Drawing.Point(67, 3);
            this.CAWLogo.Name = "CAWLogo";
            this.CAWLogo.Size = new System.Drawing.Size(70, 70);
            this.CAWLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.CAWLogo.TabIndex = 3;
            this.CAWLogo.TabStop = false;
            // 
            // Panel2
            // 
            this.Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(22)))), ((int)(((byte)(25)))));
            this.Panel2.Controls.Add(this.CAWLabel);
            this.Panel2.Controls.Add(this.PixelCowboyLogo);
            this.Panel2.Controls.Add(this.CAWLogo);
            this.Panel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(22)))), ((int)(((byte)(25)))));
            this.Panel2.Location = new System.Drawing.Point(12, 415);
            this.Panel2.Name = "Panel2";
            this.Panel2.Size = new System.Drawing.Size(310, 73);
            this.Panel2.TabIndex = 10;
            // 
            // LoadingLabel
            // 
            this.LoadingLabel.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoadingLabel.Location = new System.Drawing.Point(70, 354);
            this.LoadingLabel.Name = "LoadingLabel";
            this.LoadingLabel.Size = new System.Drawing.Size(205, 24);
            this.LoadingLabel.TabIndex = 11;
            this.LoadingLabel.Text = "Loading";
            this.LoadingLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Splash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(334, 500);
            this.Controls.Add(this.Panel1);
            this.Controls.Add(this.SvccLogo);
            this.Controls.Add(this.TitleLabel);
            this.Controls.Add(this.Panel2);
            this.Controls.Add(this.LoadingLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Splash";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Splash";
            this.Load += new System.EventHandler(this.Splash_Load);
            this.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SvccLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PixelCowboyLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CAWLogo)).EndInit();
            this.Panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        internal System.Windows.Forms.Panel Panel1;
        internal System.Windows.Forms.Label VersionLabel;
        internal System.Windows.Forms.PictureBox SvccLogo;
        internal System.Windows.Forms.Label TitleLabel;
        internal System.Windows.Forms.Label CAWLabel;
        internal System.Windows.Forms.PictureBox PixelCowboyLogo;
        internal System.Windows.Forms.PictureBox CAWLogo;
        internal System.Windows.Forms.Panel Panel2;
        internal System.Windows.Forms.Label LoadingLabel;
    }
}