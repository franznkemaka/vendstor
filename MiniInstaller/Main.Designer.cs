namespace MiniInstaller
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.timSplash = new System.Windows.Forms.Timer(this.components);
            this.ElipBorder = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.DragControl = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.lblSoftName = new System.Windows.Forms.Label();
            this.lblCopyright = new System.Windows.Forms.Label();
            this.cpgbSplash = new Bunifu.Framework.UI.BunifuCircleProgressbar();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnExit = new Bunifu.Framework.UI.BunifuImageButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).BeginInit();
            this.SuspendLayout();
            // 
            // timSplash
            // 
            this.timSplash.Interval = 1000;
            this.timSplash.Tick += new System.EventHandler(this.TimSplash_Tick);
            // 
            // ElipBorder
            // 
            this.ElipBorder.ElipseRadius = 5;
            this.ElipBorder.TargetControl = this;
            // 
            // DragControl
            // 
            this.DragControl.Fixed = true;
            this.DragControl.Horizontal = true;
            this.DragControl.TargetControl = this;
            this.DragControl.Vertical = true;
            // 
            // lblSoftName
            // 
            this.lblSoftName.AutoSize = true;
            this.lblSoftName.BackColor = System.Drawing.Color.Transparent;
            this.lblSoftName.Font = new System.Drawing.Font("Product Sans", 25F);
            this.lblSoftName.ForeColor = System.Drawing.Color.White;
            this.lblSoftName.Location = new System.Drawing.Point(12, 9);
            this.lblSoftName.Name = "lblSoftName";
            this.lblSoftName.Size = new System.Drawing.Size(152, 43);
            this.lblSoftName.TabIndex = 4;
            this.lblSoftName.Text = "Vendstor";
            // 
            // lblCopyright
            // 
            this.lblCopyright.AutoSize = true;
            this.lblCopyright.BackColor = System.Drawing.Color.Transparent;
            this.lblCopyright.Font = new System.Drawing.Font("Product Sans", 9.5F);
            this.lblCopyright.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.lblCopyright.Location = new System.Drawing.Point(12, 298);
            this.lblCopyright.MaximumSize = new System.Drawing.Size(252, 0);
            this.lblCopyright.Name = "lblCopyright";
            this.lblCopyright.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblCopyright.Size = new System.Drawing.Size(252, 17);
            this.lblCopyright.TabIndex = 5;
            this.lblCopyright.Text = "Copyright © 2018 RigleSoft. Franz Nkemaka";
            // 
            // cpgbSplash
            // 
            this.cpgbSplash.animated = true;
            this.cpgbSplash.animationIterval = 5;
            this.cpgbSplash.animationSpeed = 1;
            this.cpgbSplash.BackColor = System.Drawing.Color.Transparent;
            this.cpgbSplash.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cpgbSplash.BackgroundImage")));
            this.cpgbSplash.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F);
            this.cpgbSplash.ForeColor = System.Drawing.Color.SeaGreen;
            this.cpgbSplash.LabelVisible = false;
            this.cpgbSplash.LineProgressThickness = 2;
            this.cpgbSplash.LineThickness = 2;
            this.cpgbSplash.Location = new System.Drawing.Point(501, 250);
            this.cpgbSplash.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.cpgbSplash.MaxValue = 100;
            this.cpgbSplash.Name = "cpgbSplash";
            this.cpgbSplash.ProgressBackColor = System.Drawing.Color.Silver;
            this.cpgbSplash.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.cpgbSplash.Size = new System.Drawing.Size(65, 65);
            this.cpgbSplash.TabIndex = 8;
            this.cpgbSplash.Value = 50;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Poppins Light", 20F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.label1.Location = new System.Drawing.Point(12, 241);
            this.label1.MaximumSize = new System.Drawing.Size(252, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 48);
            this.label1.TabIndex = 9;
            this.label1.Text = "Installing...";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.bunifuImageButton1);
            this.panel1.Controls.Add(this.lblSoftName);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(575, 220);
            this.panel1.TabIndex = 10;
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton1.Image = global::MiniInstaller.Properties.Resources.installing_480;
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(192, 49);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(190, 123);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 5;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.Image = global::MiniInstaller.Properties.Resources.close_w;
            this.btnExit.ImageActive = null;
            this.btnExit.Location = new System.Drawing.Point(543, 12);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(20, 20);
            this.btnExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnExit.TabIndex = 95;
            this.btnExit.TabStop = false;
            this.btnExit.Zoom = 10;
            this.btnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(575, 324);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblCopyright);
            this.Controls.Add(this.cpgbSplash);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.Load += new System.EventHandler(this.OnLoad);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timSplash;
        private Bunifu.Framework.UI.BunifuElipse ElipBorder;
        private Bunifu.Framework.UI.BunifuDragControl DragControl;
        private System.Windows.Forms.Label lblSoftName;
        private System.Windows.Forms.Label lblCopyright;
        private Bunifu.Framework.UI.BunifuCircleProgressbar cpgbSplash;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private Bunifu.Framework.UI.BunifuImageButton btnExit;
    }
}

