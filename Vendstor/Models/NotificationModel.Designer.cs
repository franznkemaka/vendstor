namespace Vendstor.Models
{
    partial class NotificationModel
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.imgbtnClear = new Bunifu.Framework.UI.BunifuImageButton();
            this.lblNotifForm = new System.Windows.Forms.Label();
            this.ElipBorder = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.lblNotifTitle = new System.Windows.Forms.Label();
            this.lblNotifDetails = new System.Windows.Forms.Label();
            this.lblNotifDate = new System.Windows.Forms.Label();
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgbtnClear)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.pnlHeader.Controls.Add(this.imgbtnClear);
            this.pnlHeader.Controls.Add(this.lblNotifForm);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(358, 45);
            this.pnlHeader.TabIndex = 0;
            // 
            // imgbtnClear
            // 
            this.imgbtnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.imgbtnClear.BackColor = System.Drawing.Color.Transparent;
            this.imgbtnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imgbtnClear.Image = global::Vendstor.Properties.Resources.close_w;
            this.imgbtnClear.ImageActive = null;
            this.imgbtnClear.Location = new System.Drawing.Point(329, 15);
            this.imgbtnClear.Name = "imgbtnClear";
            this.imgbtnClear.Size = new System.Drawing.Size(15, 15);
            this.imgbtnClear.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgbtnClear.TabIndex = 60;
            this.imgbtnClear.TabStop = false;
            this.imgbtnClear.Zoom = 10;
            this.imgbtnClear.Click += new System.EventHandler(this.ImgbtnClear_Click);
            // 
            // lblNotifForm
            // 
            this.lblNotifForm.AutoSize = true;
            this.lblNotifForm.BackColor = System.Drawing.Color.Transparent;
            this.lblNotifForm.Font = new System.Drawing.Font("Poppins Light", 13.5F);
            this.lblNotifForm.ForeColor = System.Drawing.Color.DimGray;
            this.lblNotifForm.Location = new System.Drawing.Point(142, 6);
            this.lblNotifForm.Name = "lblNotifForm";
            this.lblNotifForm.Size = new System.Drawing.Size(75, 32);
            this.lblNotifForm.TabIndex = 59;
            this.lblNotifForm.Text = "Setting";
            this.lblNotifForm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblNotifForm.Click += new System.EventHandler(this.OnClick);
            // 
            // ElipBorder
            // 
            this.ElipBorder.ElipseRadius = 7;
            this.ElipBorder.TargetControl = this;
            // 
            // lblNotifTitle
            // 
            this.lblNotifTitle.AutoSize = true;
            this.lblNotifTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblNotifTitle.Font = new System.Drawing.Font("Poppins Light", 10F);
            this.lblNotifTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblNotifTitle.Location = new System.Drawing.Point(6, 52);
            this.lblNotifTitle.Name = "lblNotifTitle";
            this.lblNotifTitle.Size = new System.Drawing.Size(48, 25);
            this.lblNotifTitle.TabIndex = 60;
            this.lblNotifTitle.Text = "_Title";
            this.lblNotifTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblNotifTitle.Click += new System.EventHandler(this.OnClick);
            // 
            // lblNotifDetails
            // 
            this.lblNotifDetails.AutoSize = true;
            this.lblNotifDetails.BackColor = System.Drawing.Color.Transparent;
            this.lblNotifDetails.Font = new System.Drawing.Font("Poppins ExtraLight", 10F);
            this.lblNotifDetails.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblNotifDetails.Location = new System.Drawing.Point(3, 81);
            this.lblNotifDetails.MaximumSize = new System.Drawing.Size(360, 0);
            this.lblNotifDetails.Name = "lblNotifDetails";
            this.lblNotifDetails.Size = new System.Drawing.Size(66, 25);
            this.lblNotifDetails.TabIndex = 61;
            this.lblNotifDetails.Text = "_Details";
            this.lblNotifDetails.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblNotifDetails.Click += new System.EventHandler(this.OnClick);
            // 
            // lblNotifDate
            // 
            this.lblNotifDate.AutoSize = true;
            this.lblNotifDate.BackColor = System.Drawing.Color.Transparent;
            this.lblNotifDate.Font = new System.Drawing.Font("Poppins Light", 10F);
            this.lblNotifDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblNotifDate.Location = new System.Drawing.Point(13, 156);
            this.lblNotifDate.Name = "lblNotifDate";
            this.lblNotifDate.Size = new System.Drawing.Size(54, 25);
            this.lblNotifDate.TabIndex = 62;
            this.lblNotifDate.Text = "_Date";
            this.lblNotifDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblNotifDate.Click += new System.EventHandler(this.OnClick);
            // 
            // NotificationsTabNotif
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(246)))));
            this.Controls.Add(this.lblNotifDate);
            this.Controls.Add(this.lblNotifDetails);
            this.Controls.Add(this.lblNotifTitle);
            this.Controls.Add(this.pnlHeader);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.Name = "NotificationsTabNotif";
            this.Size = new System.Drawing.Size(358, 181);
            this.Load += new System.EventHandler(this.OnLoad);
            this.Click += new System.EventHandler(this.OnClick);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgbtnClear)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private Bunifu.Framework.UI.BunifuElipse ElipBorder;
        private System.Windows.Forms.Label lblNotifForm;
        private System.Windows.Forms.Label lblNotifDate;
        private System.Windows.Forms.Label lblNotifDetails;
        private System.Windows.Forms.Label lblNotifTitle;
        private Bunifu.Framework.UI.BunifuImageButton imgbtnClear;
    }
}
