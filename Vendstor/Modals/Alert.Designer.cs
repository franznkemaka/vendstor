namespace Vendstor.Modals
{
    partial class Alert
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
            this.ElipBorder = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.DragControl = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblMessage = new System.Windows.Forms.Label();
            this.timAutoClose = new System.Windows.Forms.Timer(this.components);
            this.timTimeOut = new System.Windows.Forms.Timer(this.components);
            this.timShow = new System.Windows.Forms.Timer(this.components);
            this.imgbtnExit = new Bunifu.Framework.UI.BunifuImageButton();
            this.imgIcon = new Bunifu.Framework.UI.BunifuImageButton();
            ((System.ComponentModel.ISupportInitialize)(this.imgbtnExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgIcon)).BeginInit();
            this.SuspendLayout();
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
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Poppins", 14F);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(82, 16);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(0);
            this.lblTitle.MaximumSize = new System.Drawing.Size(541, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(201, 33);
            this.lblTitle.TabIndex = 147;
            this.lblTitle.Text = "Internal Server Error";
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Font = new System.Drawing.Font("Poppins Light", 10F);
            this.lblMessage.ForeColor = System.Drawing.Color.White;
            this.lblMessage.Location = new System.Drawing.Point(83, 47);
            this.lblMessage.Margin = new System.Windows.Forms.Padding(0);
            this.lblMessage.MaximumSize = new System.Drawing.Size(350, 0);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(337, 50);
            this.lblMessage.TabIndex = 149;
            this.lblMessage.Tag = " ";
            this.lblMessage.Text = "bla bla bla bla bla bla bla bla bla bla bla bla bla bla bla bla bla bla bla bla b" +
    "la bla bla bla bla bla";
            // 
            // timAutoClose
            // 
            this.timAutoClose.Tick += new System.EventHandler(this.TimAutoClose_Tick);
            // 
            // timTimeOut
            // 
            this.timTimeOut.Enabled = true;
            this.timTimeOut.Interval = 5000;
            this.timTimeOut.Tick += new System.EventHandler(this.TimTimeOut_Tick);
            // 
            // timShow
            // 
            this.timShow.Enabled = true;
            this.timShow.Tick += new System.EventHandler(this.TimShow_Tick);
            // 
            // imgbtnExit
            // 
            this.imgbtnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.imgbtnExit.BackColor = System.Drawing.Color.Transparent;
            this.imgbtnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imgbtnExit.Image = global::Vendstor.Properties.Resources.close_w1;
            this.imgbtnExit.ImageActive = null;
            this.imgbtnExit.Location = new System.Drawing.Point(423, 7);
            this.imgbtnExit.Name = "imgbtnExit";
            this.imgbtnExit.Size = new System.Drawing.Size(18, 17);
            this.imgbtnExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgbtnExit.TabIndex = 151;
            this.imgbtnExit.TabStop = false;
            this.imgbtnExit.Zoom = 10;
            this.imgbtnExit.Click += new System.EventHandler(this.ImgbtnExit_Click);
            // 
            // imgIcon
            // 
            this.imgIcon.BackColor = System.Drawing.Color.Transparent;
            this.imgIcon.Image = global::Vendstor.Properties.Resources.info_filled_xl_black;
            this.imgIcon.ImageActive = null;
            this.imgIcon.Location = new System.Drawing.Point(12, 23);
            this.imgIcon.Name = "imgIcon";
            this.imgIcon.Size = new System.Drawing.Size(63, 50);
            this.imgIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgIcon.TabIndex = 0;
            this.imgIcon.TabStop = false;
            this.imgIcon.Zoom = 10;
            // 
            // Alert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(42)))), ((int)(((byte)(61)))));
            this.ClientSize = new System.Drawing.Size(449, 106);
            this.Controls.Add(this.imgbtnExit);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.imgIcon);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Alert";
            this.Opacity = 0.95D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Alert";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.OnLoad);
            ((System.ComponentModel.ISupportInitialize)(this.imgbtnExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse ElipBorder;
        private Bunifu.Framework.UI.BunifuDragControl DragControl;
        private Bunifu.Framework.UI.BunifuImageButton imgIcon;
        public System.Windows.Forms.Label lblTitle;
        public System.Windows.Forms.Label lblMessage;
        private Bunifu.Framework.UI.BunifuImageButton imgbtnExit;
        private System.Windows.Forms.Timer timAutoClose;
        private System.Windows.Forms.Timer timTimeOut;
        private System.Windows.Forms.Timer timShow;
    }
}