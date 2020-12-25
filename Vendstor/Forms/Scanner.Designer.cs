namespace Vendstor.Forms
{
    partial class Scanner
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
            this.cardToken = new Bunifu.Framework.UI.BunifuCards();
            this.lblToken = new System.Windows.Forms.Label();
            this.text_ScannedToken = new System.Windows.Forms.Label();
            this.imgpnlProduct_Card = new System.Windows.Forms.Panel();
            this.imgScanner_Card = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnScanning = new Bunifu.Framework.UI.BunifuFlatButton();
            this.cardToken.SuspendLayout();
            this.imgpnlProduct_Card.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgScanner_Card)).BeginInit();
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
            // cardToken
            // 
            this.cardToken.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cardToken.BackColor = System.Drawing.Color.White;
            this.cardToken.BorderRadius = 10;
            this.cardToken.BottomSahddow = true;
            this.cardToken.color = System.Drawing.Color.Transparent;
            this.cardToken.Controls.Add(this.lblToken);
            this.cardToken.Controls.Add(this.text_ScannedToken);
            this.cardToken.Controls.Add(this.imgpnlProduct_Card);
            this.cardToken.LeftSahddow = false;
            this.cardToken.Location = new System.Drawing.Point(34, 25);
            this.cardToken.Name = "cardToken";
            this.cardToken.RightSahddow = true;
            this.cardToken.ShadowDepth = 10;
            this.cardToken.Size = new System.Drawing.Size(334, 95);
            this.cardToken.TabIndex = 218;
            // 
            // lblToken
            // 
            this.lblToken.AutoSize = true;
            this.lblToken.Font = new System.Drawing.Font("Poppins SemiBold", 20F, System.Drawing.FontStyle.Bold);
            this.lblToken.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblToken.Location = new System.Drawing.Point(85, 38);
            this.lblToken.Name = "lblToken";
            this.lblToken.Size = new System.Drawing.Size(36, 48);
            this.lblToken.TabIndex = 2;
            this.lblToken.Text = "-";
            // 
            // text_ScannedToken
            // 
            this.text_ScannedToken.AutoSize = true;
            this.text_ScannedToken.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_ScannedToken.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.text_ScannedToken.Location = new System.Drawing.Point(88, 10);
            this.text_ScannedToken.Name = "text_ScannedToken";
            this.text_ScannedToken.Size = new System.Drawing.Size(134, 28);
            this.text_ScannedToken.TabIndex = 1;
            this.text_ScannedToken.Text = "Scanned Token";
            // 
            // imgpnlProduct_Card
            // 
            this.imgpnlProduct_Card.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(206)))), ((int)(((byte)(104)))));
            this.imgpnlProduct_Card.Controls.Add(this.imgScanner_Card);
            this.imgpnlProduct_Card.Location = new System.Drawing.Point(23, 18);
            this.imgpnlProduct_Card.Name = "imgpnlProduct_Card";
            this.imgpnlProduct_Card.Size = new System.Drawing.Size(49, 47);
            this.imgpnlProduct_Card.TabIndex = 8;
            // 
            // imgScanner_Card
            // 
            this.imgScanner_Card.BackColor = System.Drawing.Color.Transparent;
            this.imgScanner_Card.Image = global::Vendstor.Properties.Resources.barcode_reader_filled_w;
            this.imgScanner_Card.ImageActive = null;
            this.imgScanner_Card.Location = new System.Drawing.Point(7, 6);
            this.imgScanner_Card.Name = "imgScanner_Card";
            this.imgScanner_Card.Size = new System.Drawing.Size(35, 35);
            this.imgScanner_Card.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgScanner_Card.TabIndex = 3;
            this.imgScanner_Card.TabStop = false;
            this.imgScanner_Card.Zoom = 10;
            // 
            // btnScanning
            // 
            this.btnScanning.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.btnScanning.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnScanning.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.btnScanning.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnScanning.BorderRadius = 5;
            this.btnScanning.ButtonText = "Scanning";
            this.btnScanning.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnScanning.DisabledColor = System.Drawing.Color.Gray;
            this.btnScanning.Iconcolor = System.Drawing.Color.Transparent;
            this.btnScanning.Iconimage = global::Vendstor.Properties.Resources.ok_filled_w_xl;
            this.btnScanning.Iconimage_right = null;
            this.btnScanning.Iconimage_right_Selected = null;
            this.btnScanning.Iconimage_Selected = null;
            this.btnScanning.IconMarginLeft = 0;
            this.btnScanning.IconMarginRight = 0;
            this.btnScanning.IconRightVisible = true;
            this.btnScanning.IconRightZoom = 0D;
            this.btnScanning.IconVisible = true;
            this.btnScanning.IconZoom = 45D;
            this.btnScanning.IsTab = false;
            this.btnScanning.Location = new System.Drawing.Point(121, 234);
            this.btnScanning.Margin = new System.Windows.Forms.Padding(4);
            this.btnScanning.Name = "btnScanning";
            this.btnScanning.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.btnScanning.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.btnScanning.OnHoverTextColor = System.Drawing.Color.White;
            this.btnScanning.selected = false;
            this.btnScanning.Size = new System.Drawing.Size(160, 37);
            this.btnScanning.TabIndex = 217;
            this.btnScanning.Text = "Scanning";
            this.btnScanning.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnScanning.Textcolor = System.Drawing.Color.White;
            this.btnScanning.TextFont = new System.Drawing.Font("Poppins Light", 11F);
            // 
            // Scanner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(402, 302);
            this.Controls.Add(this.cardToken);
            this.Controls.Add(this.btnScanning);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Scanner";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vendstor - Scanner";
            this.Load += new System.EventHandler(this.OnLoad);
            this.Click += new System.EventHandler(this.OnClick);
            this.cardToken.ResumeLayout(false);
            this.cardToken.PerformLayout();
            this.imgpnlProduct_Card.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgScanner_Card)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse ElipBorder;
        private Bunifu.Framework.UI.BunifuDragControl DragControl;
        private Bunifu.Framework.UI.BunifuCards cardToken;
        private System.Windows.Forms.Label lblToken;
        private System.Windows.Forms.Label text_ScannedToken;
        private System.Windows.Forms.Panel imgpnlProduct_Card;
        private Bunifu.Framework.UI.BunifuImageButton imgScanner_Card;
        private Bunifu.Framework.UI.BunifuFlatButton btnScanning;
    }
}