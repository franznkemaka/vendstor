namespace Vendstor.UserControls
{
    partial class NotificationsTab
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
            this.flpnlNotifications = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lbl_Notifications = new System.Windows.Forms.Label();
            this.pnlHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // flpnlNotifications
            // 
            this.flpnlNotifications.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.flpnlNotifications.AutoScroll = true;
            this.flpnlNotifications.BackColor = System.Drawing.Color.White;
            this.flpnlNotifications.Location = new System.Drawing.Point(-2, 41);
            this.flpnlNotifications.Name = "flpnlNotifications";
            this.flpnlNotifications.Size = new System.Drawing.Size(366, 573);
            this.flpnlNotifications.TabIndex = 3;
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.pnlHeader.Controls.Add(this.lbl_Notifications);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(364, 41);
            this.pnlHeader.TabIndex = 2;
            // 
            // lbl_Notifications
            // 
            this.lbl_Notifications.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_Notifications.AutoSize = true;
            this.lbl_Notifications.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Notifications.Font = new System.Drawing.Font("Product Sans", 15F);
            this.lbl_Notifications.ForeColor = System.Drawing.Color.White;
            this.lbl_Notifications.Location = new System.Drawing.Point(121, 8);
            this.lbl_Notifications.Name = "lbl_Notifications";
            this.lbl_Notifications.Size = new System.Drawing.Size(122, 25);
            this.lbl_Notifications.TabIndex = 48;
            this.lbl_Notifications.Text = "Notifications";
            // 
            // NotificationsTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.flpnlNotifications);
            this.Controls.Add(this.pnlHeader);
            this.Name = "NotificationsTab";
            this.Size = new System.Drawing.Size(364, 614);
            this.Load += new System.EventHandler(this.OnLoad);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpnlNotifications;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lbl_Notifications;
    }
}
