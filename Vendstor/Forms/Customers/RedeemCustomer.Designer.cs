namespace Vendstor.Forms.Customers
{
    partial class RedeemCustomer
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
            this.txtStoreCredit = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.cardStoreCredit = new Bunifu.Framework.UI.BunifuCards();
            this.lblCurrentStoreCredit = new System.Windows.Forms.Label();
            this.text_CurrentStoreCredit = new System.Windows.Forms.Label();
            this.imgpnlProduct_Card = new System.Windows.Forms.Panel();
            this.imgProduct_Card = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnRedeem = new Bunifu.Framework.UI.BunifuFlatButton();
            this.cardStoreCredit.SuspendLayout();
            this.imgpnlProduct_Card.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgProduct_Card)).BeginInit();
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
            // txtStoreCredit
            // 
            this.txtStoreCredit.AutoScroll = true;
            this.txtStoreCredit.AutoSize = true;
            this.txtStoreCredit.BackColor = System.Drawing.Color.White;
            this.txtStoreCredit.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.txtStoreCredit.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(246)))));
            this.txtStoreCredit.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.txtStoreCredit.BorderThickness = 2;
            this.txtStoreCredit.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtStoreCredit.Font = new System.Drawing.Font("Poppins SemiBold", 20F, System.Drawing.FontStyle.Bold);
            this.txtStoreCredit.ForeColor = System.Drawing.Color.DimGray;
            this.txtStoreCredit.isPassword = false;
            this.txtStoreCredit.Location = new System.Drawing.Point(164, 129);
            this.txtStoreCredit.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtStoreCredit.Name = "txtStoreCredit";
            this.txtStoreCredit.Size = new System.Drawing.Size(89, 61);
            this.txtStoreCredit.TabIndex = 219;
            this.txtStoreCredit.Text = "0";
            this.txtStoreCredit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cardStoreCredit
            // 
            this.cardStoreCredit.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cardStoreCredit.BackColor = System.Drawing.Color.White;
            this.cardStoreCredit.BorderRadius = 10;
            this.cardStoreCredit.BottomSahddow = true;
            this.cardStoreCredit.color = System.Drawing.Color.Transparent;
            this.cardStoreCredit.Controls.Add(this.lblCurrentStoreCredit);
            this.cardStoreCredit.Controls.Add(this.text_CurrentStoreCredit);
            this.cardStoreCredit.Controls.Add(this.imgpnlProduct_Card);
            this.cardStoreCredit.LeftSahddow = false;
            this.cardStoreCredit.Location = new System.Drawing.Point(56, 25);
            this.cardStoreCredit.Name = "cardStoreCredit";
            this.cardStoreCredit.RightSahddow = true;
            this.cardStoreCredit.ShadowDepth = 10;
            this.cardStoreCredit.Size = new System.Drawing.Size(304, 95);
            this.cardStoreCredit.TabIndex = 218;
            // 
            // lblCurrentStoreCredit
            // 
            this.lblCurrentStoreCredit.AutoSize = true;
            this.lblCurrentStoreCredit.Font = new System.Drawing.Font("Poppins SemiBold", 20F, System.Drawing.FontStyle.Bold);
            this.lblCurrentStoreCredit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblCurrentStoreCredit.Location = new System.Drawing.Point(103, 38);
            this.lblCurrentStoreCredit.Name = "lblCurrentStoreCredit";
            this.lblCurrentStoreCredit.Size = new System.Drawing.Size(99, 48);
            this.lblCurrentStoreCredit.TabIndex = 2;
            this.lblCurrentStoreCredit.Text = "€ 999";
            // 
            // text_CurrentStoreCredit
            // 
            this.text_CurrentStoreCredit.AutoSize = true;
            this.text_CurrentStoreCredit.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_CurrentStoreCredit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.text_CurrentStoreCredit.Location = new System.Drawing.Point(88, 10);
            this.text_CurrentStoreCredit.Name = "text_CurrentStoreCredit";
            this.text_CurrentStoreCredit.Size = new System.Drawing.Size(170, 28);
            this.text_CurrentStoreCredit.TabIndex = 1;
            this.text_CurrentStoreCredit.Text = "Current Store Credit";
            // 
            // imgpnlProduct_Card
            // 
            this.imgpnlProduct_Card.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(206)))), ((int)(((byte)(104)))));
            this.imgpnlProduct_Card.Controls.Add(this.imgProduct_Card);
            this.imgpnlProduct_Card.Location = new System.Drawing.Point(23, 18);
            this.imgpnlProduct_Card.Name = "imgpnlProduct_Card";
            this.imgpnlProduct_Card.Size = new System.Drawing.Size(49, 47);
            this.imgpnlProduct_Card.TabIndex = 8;
            // 
            // imgProduct_Card
            // 
            this.imgProduct_Card.BackColor = System.Drawing.Color.Transparent;
            this.imgProduct_Card.Image = global::Vendstor.Properties.Resources.money_d_w;
            this.imgProduct_Card.ImageActive = null;
            this.imgProduct_Card.Location = new System.Drawing.Point(7, 6);
            this.imgProduct_Card.Name = "imgProduct_Card";
            this.imgProduct_Card.Size = new System.Drawing.Size(35, 35);
            this.imgProduct_Card.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgProduct_Card.TabIndex = 3;
            this.imgProduct_Card.TabStop = false;
            this.imgProduct_Card.Zoom = 10;
            // 
            // btnRedeem
            // 
            this.btnRedeem.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.btnRedeem.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnRedeem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.btnRedeem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRedeem.BorderRadius = 5;
            this.btnRedeem.ButtonText = "Redeem";
            this.btnRedeem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRedeem.DisabledColor = System.Drawing.Color.Gray;
            this.btnRedeem.Iconcolor = System.Drawing.Color.Transparent;
            this.btnRedeem.Iconimage = global::Vendstor.Properties.Resources.ok_filled_w_xl;
            this.btnRedeem.Iconimage_right = null;
            this.btnRedeem.Iconimage_right_Selected = null;
            this.btnRedeem.Iconimage_Selected = null;
            this.btnRedeem.IconMarginLeft = 0;
            this.btnRedeem.IconMarginRight = 0;
            this.btnRedeem.IconRightVisible = true;
            this.btnRedeem.IconRightZoom = 0D;
            this.btnRedeem.IconVisible = true;
            this.btnRedeem.IconZoom = 45D;
            this.btnRedeem.IsTab = false;
            this.btnRedeem.Location = new System.Drawing.Point(138, 241);
            this.btnRedeem.Margin = new System.Windows.Forms.Padding(4);
            this.btnRedeem.Name = "btnRedeem";
            this.btnRedeem.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.btnRedeem.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.btnRedeem.OnHoverTextColor = System.Drawing.Color.White;
            this.btnRedeem.selected = false;
            this.btnRedeem.Size = new System.Drawing.Size(127, 37);
            this.btnRedeem.TabIndex = 217;
            this.btnRedeem.Text = "Redeem";
            this.btnRedeem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnRedeem.Textcolor = System.Drawing.Color.White;
            this.btnRedeem.TextFont = new System.Drawing.Font("Poppins Light", 11F);
            this.btnRedeem.Click += new System.EventHandler(this.BtnRedeem_Click);
            // 
            // RedeemCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(402, 302);
            this.Controls.Add(this.txtStoreCredit);
            this.Controls.Add(this.cardStoreCredit);
            this.Controls.Add(this.btnRedeem);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RedeemCustomer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vendstor - Customer  :  Redeem";
            this.Load += new System.EventHandler(this.OnLoad);
            this.Click += new System.EventHandler(this.OnClick);
            this.cardStoreCredit.ResumeLayout(false);
            this.cardStoreCredit.PerformLayout();
            this.imgpnlProduct_Card.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgProduct_Card)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse ElipBorder;
        private Bunifu.Framework.UI.BunifuDragControl DragControl;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtStoreCredit;
        private Bunifu.Framework.UI.BunifuCards cardStoreCredit;
        private System.Windows.Forms.Label lblCurrentStoreCredit;
        private System.Windows.Forms.Label text_CurrentStoreCredit;
        private System.Windows.Forms.Panel imgpnlProduct_Card;
        private Bunifu.Framework.UI.BunifuImageButton imgProduct_Card;
        private Bunifu.Framework.UI.BunifuFlatButton btnRedeem;
    }
}