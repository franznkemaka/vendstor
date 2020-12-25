namespace Vendstor.UserControls
{
    partial class ComingSoon
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
            this.cardComingSoon = new Bunifu.Framework.UI.BunifuCards();
            this.imgSorry_Alert = new Bunifu.Framework.UI.BunifuImageButton();
            this.seperator_Alert = new Bunifu.Framework.UI.BunifuSeparator();
            this.lblMessage = new System.Windows.Forms.Label();
            this.btnNextRelease = new Bunifu.Framework.UI.BunifuFlatButton();
            this.cardComingSoon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgSorry_Alert)).BeginInit();
            this.SuspendLayout();
            // 
            // cardComingSoon
            // 
            this.cardComingSoon.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cardComingSoon.BackColor = System.Drawing.Color.White;
            this.cardComingSoon.BorderRadius = 5;
            this.cardComingSoon.BottomSahddow = true;
            this.cardComingSoon.color = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(246)))));
            this.cardComingSoon.Controls.Add(this.imgSorry_Alert);
            this.cardComingSoon.Controls.Add(this.seperator_Alert);
            this.cardComingSoon.Controls.Add(this.lblMessage);
            this.cardComingSoon.Controls.Add(this.btnNextRelease);
            this.cardComingSoon.LeftSahddow = false;
            this.cardComingSoon.Location = new System.Drawing.Point(26, 16);
            this.cardComingSoon.Name = "cardComingSoon";
            this.cardComingSoon.RightSahddow = true;
            this.cardComingSoon.ShadowDepth = 20;
            this.cardComingSoon.Size = new System.Drawing.Size(451, 286);
            this.cardComingSoon.TabIndex = 134;
            // 
            // imgSorry_Alert
            // 
            this.imgSorry_Alert.BackColor = System.Drawing.Color.Transparent;
            this.imgSorry_Alert.Image = global::Vendstor.Properties.Resources.vector_sorrygirl;
            this.imgSorry_Alert.ImageActive = null;
            this.imgSorry_Alert.Location = new System.Drawing.Point(166, 25);
            this.imgSorry_Alert.Name = "imgSorry_Alert";
            this.imgSorry_Alert.Size = new System.Drawing.Size(118, 91);
            this.imgSorry_Alert.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgSorry_Alert.TabIndex = 182;
            this.imgSorry_Alert.TabStop = false;
            this.imgSorry_Alert.Zoom = 10;
            // 
            // seperator_Alert
            // 
            this.seperator_Alert.BackColor = System.Drawing.Color.Transparent;
            this.seperator_Alert.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(246)))));
            this.seperator_Alert.LineThickness = 1;
            this.seperator_Alert.Location = new System.Drawing.Point(192, 180);
            this.seperator_Alert.Margin = new System.Windows.Forms.Padding(7);
            this.seperator_Alert.Name = "seperator_Alert";
            this.seperator_Alert.Size = new System.Drawing.Size(65, 28);
            this.seperator_Alert.TabIndex = 181;
            this.seperator_Alert.Transparency = 255;
            this.seperator_Alert.Vertical = false;
            this.seperator_Alert.Visible = false;
            // 
            // lblMessage
            // 
            this.lblMessage.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblMessage.AutoSize = true;
            this.lblMessage.Font = new System.Drawing.Font("Poppins Light", 11F);
            this.lblMessage.Location = new System.Drawing.Point(59, 140);
            this.lblMessage.MaximumSize = new System.Drawing.Size(350, 0);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(332, 26);
            this.lblMessage.TabIndex = 180;
            this.lblMessage.Text = "This feature or service will be soon avaiilable";
            // 
            // btnNextRelease
            // 
            this.btnNextRelease.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.btnNextRelease.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnNextRelease.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.btnNextRelease.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNextRelease.BorderRadius = 5;
            this.btnNextRelease.ButtonText = "Next Release";
            this.btnNextRelease.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNextRelease.DisabledColor = System.Drawing.Color.Gray;
            this.btnNextRelease.Iconcolor = System.Drawing.Color.Transparent;
            this.btnNextRelease.Iconimage = global::Vendstor.Properties.Resources.ok_filled_w_xl;
            this.btnNextRelease.Iconimage_right = null;
            this.btnNextRelease.Iconimage_right_Selected = null;
            this.btnNextRelease.Iconimage_Selected = null;
            this.btnNextRelease.IconMarginLeft = 0;
            this.btnNextRelease.IconMarginRight = 0;
            this.btnNextRelease.IconRightVisible = true;
            this.btnNextRelease.IconRightZoom = 0D;
            this.btnNextRelease.IconVisible = true;
            this.btnNextRelease.IconZoom = 45D;
            this.btnNextRelease.IsTab = false;
            this.btnNextRelease.Location = new System.Drawing.Point(147, 218);
            this.btnNextRelease.Margin = new System.Windows.Forms.Padding(4);
            this.btnNextRelease.Name = "btnNextRelease";
            this.btnNextRelease.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.btnNextRelease.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.btnNextRelease.OnHoverTextColor = System.Drawing.Color.White;
            this.btnNextRelease.selected = false;
            this.btnNextRelease.Size = new System.Drawing.Size(155, 40);
            this.btnNextRelease.TabIndex = 172;
            this.btnNextRelease.Text = "Next Release";
            this.btnNextRelease.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnNextRelease.Textcolor = System.Drawing.Color.White;
            this.btnNextRelease.TextFont = new System.Drawing.Font("Poppins Light", 11F);
            // 
            // ComingSoon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cardComingSoon);
            this.Name = "ComingSoon";
            this.Size = new System.Drawing.Size(503, 318);
            this.Load += new System.EventHandler(this.OnLoad);
            this.cardComingSoon.ResumeLayout(false);
            this.cardComingSoon.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgSorry_Alert)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCards cardComingSoon;
        private Bunifu.Framework.UI.BunifuImageButton imgSorry_Alert;
        private Bunifu.Framework.UI.BunifuSeparator seperator_Alert;
        private System.Windows.Forms.Label lblMessage;
        private Bunifu.Framework.UI.BunifuFlatButton btnNextRelease;
    }
}
