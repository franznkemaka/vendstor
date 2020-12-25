namespace Vendstor.Forms
{
    partial class SplashScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SplashScreen));
            this.ElipBorder = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.lblSoft_Version = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblSoft_Copyright = new System.Windows.Forms.Label();
            this.lblSoft_Name = new System.Windows.Forms.Label();
            this.lblSoft_Release = new System.Windows.Forms.Label();
            this.timSplash = new System.Windows.Forms.Timer(this.components);
            this.dgSplash = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.cpgbSplash = new Bunifu.Framework.UI.BunifuCircleProgressbar();
            this.SuspendLayout();
            // 
            // ElipBorder
            // 
            this.ElipBorder.ElipseRadius = 5;
            this.ElipBorder.TargetControl = this;
            // 
            // lblSoft_Version
            // 
            this.lblSoft_Version.AutoSize = true;
            this.lblSoft_Version.BackColor = System.Drawing.Color.Transparent;
            this.lblSoft_Version.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoft_Version.ForeColor = System.Drawing.Color.White;
            this.lblSoft_Version.Location = new System.Drawing.Point(16, 287);
            this.lblSoft_Version.Name = "lblSoft_Version";
            this.lblSoft_Version.Size = new System.Drawing.Size(222, 16);
            this.lblSoft_Version.TabIndex = 1;
            this.lblSoft_Version.Text = "Version 1.0.0 - Beta  [Build 001] 64 Bits";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.BackColor = System.Drawing.Color.Transparent;
            this.lblStatus.Font = new System.Drawing.Font("Poppins Light", 9.5F);
            this.lblStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(167)))), ((int)(((byte)(82)))));
            this.lblStatus.Location = new System.Drawing.Point(304, 300);
            this.lblStatus.MaximumSize = new System.Drawing.Size(250, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(16, 23);
            this.lblStatus.TabIndex = 1;
            this.lblStatus.Text = "...";
            // 
            // lblSoft_Copyright
            // 
            this.lblSoft_Copyright.AutoSize = true;
            this.lblSoft_Copyright.BackColor = System.Drawing.Color.Transparent;
            this.lblSoft_Copyright.Font = new System.Drawing.Font("Product Sans", 9.5F);
            this.lblSoft_Copyright.ForeColor = System.Drawing.Color.White;
            this.lblSoft_Copyright.Location = new System.Drawing.Point(13, 313);
            this.lblSoft_Copyright.MaximumSize = new System.Drawing.Size(252, 0);
            this.lblSoft_Copyright.Name = "lblSoft_Copyright";
            this.lblSoft_Copyright.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblSoft_Copyright.Size = new System.Drawing.Size(252, 34);
            this.lblSoft_Copyright.TabIndex = 1;
            this.lblSoft_Copyright.Text = "Copyright © 2018 RigleSoft. Franz Nkemaka    All Rights Reserved";
            // 
            // lblSoft_Name
            // 
            this.lblSoft_Name.AutoSize = true;
            this.lblSoft_Name.BackColor = System.Drawing.Color.Transparent;
            this.lblSoft_Name.Font = new System.Drawing.Font("Product Sans", 42F);
            this.lblSoft_Name.ForeColor = System.Drawing.Color.White;
            this.lblSoft_Name.Location = new System.Drawing.Point(9, 94);
            this.lblSoft_Name.Name = "lblSoft_Name";
            this.lblSoft_Name.Size = new System.Drawing.Size(249, 71);
            this.lblSoft_Name.TabIndex = 1;
            this.lblSoft_Name.Text = "Vendstor";
            // 
            // lblSoft_Release
            // 
            this.lblSoft_Release.AutoSize = true;
            this.lblSoft_Release.BackColor = System.Drawing.Color.Transparent;
            this.lblSoft_Release.Font = new System.Drawing.Font("Champagne & Limousines", 40F);
            this.lblSoft_Release.ForeColor = System.Drawing.Color.White;
            this.lblSoft_Release.Location = new System.Drawing.Point(12, 165);
            this.lblSoft_Release.Name = "lblSoft_Release";
            this.lblSoft_Release.Size = new System.Drawing.Size(120, 54);
            this.lblSoft_Release.TabIndex = 1;
            this.lblSoft_Release.Text = "Beta";
            // 
            // timSplash
            // 
            this.timSplash.Interval = 10;
            this.timSplash.Tick += new System.EventHandler(this.TimSplash_Tick);
            // 
            // dgSplash
            // 
            this.dgSplash.Fixed = true;
            this.dgSplash.Horizontal = true;
            this.dgSplash.TargetControl = this;
            this.dgSplash.Vertical = true;
            // 
            // cpgbSplash
            // 
            this.cpgbSplash.animated = true;
            this.cpgbSplash.animationIterval = 5;
            this.cpgbSplash.animationSpeed = 10;
            this.cpgbSplash.BackColor = System.Drawing.Color.White;
            this.cpgbSplash.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cpgbSplash.BackgroundImage")));
            this.cpgbSplash.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F);
            this.cpgbSplash.ForeColor = System.Drawing.Color.SeaGreen;
            this.cpgbSplash.LabelVisible = false;
            this.cpgbSplash.LineProgressThickness = 2;
            this.cpgbSplash.LineThickness = 2;
            this.cpgbSplash.Location = new System.Drawing.Point(535, 286);
            this.cpgbSplash.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.cpgbSplash.MaxValue = 100;
            this.cpgbSplash.Name = "cpgbSplash";
            this.cpgbSplash.ProgressBackColor = System.Drawing.Color.Silver;
            this.cpgbSplash.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(167)))), ((int)(((byte)(82)))));
            this.cpgbSplash.Size = new System.Drawing.Size(65, 65);
            this.cpgbSplash.TabIndex = 2;
            this.cpgbSplash.Value = 0;
            // 
            // SplashScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::Vendstor.Properties.Resources.SplashScreen;
            this.ClientSize = new System.Drawing.Size(603, 355);
            this.Controls.Add(this.cpgbSplash);
            this.Controls.Add(this.lblSoft_Copyright);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblSoft_Release);
            this.Controls.Add(this.lblSoft_Name);
            this.Controls.Add(this.lblSoft_Version);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SplashScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vendstor - Point Of Sale System © RigleSoft | Franz Nkemaka";
            this.Load += new System.EventHandler(this.OnLoad);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse ElipBorder;
        private System.Windows.Forms.Label lblSoft_Copyright;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblSoft_Name;
        private System.Windows.Forms.Label lblSoft_Version;
        private System.Windows.Forms.Label lblSoft_Release;
        private System.Windows.Forms.Timer timSplash;
        private Bunifu.Framework.UI.BunifuDragControl dgSplash;
        private Bunifu.Framework.UI.BunifuCircleProgressbar cpgbSplash;
    }
}

