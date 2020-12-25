namespace Vendstor.Forms.PointOfSale
{
    partial class Discount
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Discount));
            this.ElipBorder = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.text_disc_type = new System.Windows.Forms.Label();
            this.Seperator1_cpp = new Bunifu.Framework.UI.BunifuSeparator();
            this.text_Name = new System.Windows.Forms.Label();
            this.txtDiscountName = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtDiscountValue = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.lblDiscountType = new System.Windows.Forms.Label();
            this.lblUnit = new System.Windows.Forms.Label();
            this.text_Text = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.imgbtnPtgDiscountType = new Bunifu.Framework.UI.BunifuImageButton();
            this.imgbtnCashDiscountType = new Bunifu.Framework.UI.BunifuImageButton();
            this.imgbtnExit = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnAdd = new Bunifu.Framework.UI.BunifuFlatButton();
            ((System.ComponentModel.ISupportInitialize)(this.imgbtnPtgDiscountType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgbtnCashDiscountType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgbtnExit)).BeginInit();
            this.SuspendLayout();
            // 
            // ElipBorder
            // 
            this.ElipBorder.ElipseRadius = 5;
            this.ElipBorder.TargetControl = this;
            // 
            // text_disc_type
            // 
            this.text_disc_type.AutoSize = true;
            this.text_disc_type.Font = new System.Drawing.Font("Poppins Light", 10.85F);
            this.text_disc_type.Location = new System.Drawing.Point(13, 51);
            this.text_disc_type.Name = "text_disc_type";
            this.text_disc_type.Size = new System.Drawing.Size(119, 26);
            this.text_disc_type.TabIndex = 47;
            this.text_disc_type.Text = "Discount Type ";
            // 
            // Seperator1_cpp
            // 
            this.Seperator1_cpp.BackColor = System.Drawing.Color.Transparent;
            this.Seperator1_cpp.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(246)))));
            this.Seperator1_cpp.LineThickness = 1;
            this.Seperator1_cpp.Location = new System.Drawing.Point(14, 99);
            this.Seperator1_cpp.Name = "Seperator1_cpp";
            this.Seperator1_cpp.Size = new System.Drawing.Size(311, 10);
            this.Seperator1_cpp.TabIndex = 50;
            this.Seperator1_cpp.Transparency = 255;
            this.Seperator1_cpp.Vertical = false;
            // 
            // text_Name
            // 
            this.text_Name.AutoSize = true;
            this.text_Name.Font = new System.Drawing.Font("Poppins Light", 10F);
            this.text_Name.Location = new System.Drawing.Point(13, 114);
            this.text_Name.Name = "text_Name";
            this.text_Name.Size = new System.Drawing.Size(54, 25);
            this.text_Name.TabIndex = 51;
            this.text_Name.Text = "Name";
            // 
            // txtDiscountName
            // 
            this.txtDiscountName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDiscountName.Font = new System.Drawing.Font("Poppins Light", 11F);
            this.txtDiscountName.ForeColor = System.Drawing.Color.DarkGray;
            this.txtDiscountName.HintForeColor = System.Drawing.Color.DarkGray;
            this.txtDiscountName.HintText = "Discount";
            this.txtDiscountName.isPassword = false;
            this.txtDiscountName.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.txtDiscountName.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(246)))));
            this.txtDiscountName.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.txtDiscountName.LineThickness = 1;
            this.txtDiscountName.Location = new System.Drawing.Point(14, 141);
            this.txtDiscountName.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtDiscountName.Name = "txtDiscountName";
            this.txtDiscountName.Size = new System.Drawing.Size(287, 45);
            this.txtDiscountName.TabIndex = 52;
            this.txtDiscountName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtDiscountName.OnValueChanged += new System.EventHandler(this.TxtDiscountName_OnValueChanged);
            // 
            // txtDiscountValue
            // 
            this.txtDiscountValue.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDiscountValue.Font = new System.Drawing.Font("Poppins Light", 11F);
            this.txtDiscountValue.ForeColor = System.Drawing.Color.DarkGray;
            this.txtDiscountValue.HintForeColor = System.Drawing.Color.DarkGray;
            this.txtDiscountValue.HintText = "00,00";
            this.txtDiscountValue.isPassword = false;
            this.txtDiscountValue.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.txtDiscountValue.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(246)))));
            this.txtDiscountValue.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.txtDiscountValue.LineThickness = 1;
            this.txtDiscountValue.Location = new System.Drawing.Point(55, 215);
            this.txtDiscountValue.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtDiscountValue.Name = "txtDiscountValue";
            this.txtDiscountValue.Size = new System.Drawing.Size(223, 45);
            this.txtDiscountValue.TabIndex = 54;
            this.txtDiscountValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // lblDiscountType
            // 
            this.lblDiscountType.AutoSize = true;
            this.lblDiscountType.Font = new System.Drawing.Font("Poppins Light", 10F);
            this.lblDiscountType.Location = new System.Drawing.Point(12, 192);
            this.lblDiscountType.Name = "lblDiscountType";
            this.lblDiscountType.Size = new System.Drawing.Size(67, 25);
            this.lblDiscountType.TabIndex = 53;
            this.lblDiscountType.Text = "Amount";
            // 
            // lblUnit
            // 
            this.lblUnit.AutoSize = true;
            this.lblUnit.BackColor = System.Drawing.Color.White;
            this.lblUnit.Font = new System.Drawing.Font("Poppins Light", 11F);
            this.lblUnit.ForeColor = System.Drawing.Color.DarkGray;
            this.lblUnit.Location = new System.Drawing.Point(23, 227);
            this.lblUnit.Name = "lblUnit";
            this.lblUnit.Size = new System.Drawing.Size(24, 26);
            this.lblUnit.TabIndex = 56;
            this.lblUnit.Text = "€";
            // 
            // text_Text
            // 
            this.text_Text.Dock = System.Windows.Forms.DockStyle.Top;
            this.text_Text.Font = new System.Drawing.Font("Poppins", 14F);
            this.text_Text.Location = new System.Drawing.Point(0, 0);
            this.text_Text.Name = "text_Text";
            this.text_Text.Size = new System.Drawing.Size(346, 48);
            this.text_Text.TabIndex = 58;
            this.text_Text.Text = "Discount";
            this.text_Text.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // imgbtnPtgDiscountType
            // 
            this.imgbtnPtgDiscountType.BackColor = System.Drawing.Color.White;
            this.imgbtnPtgDiscountType.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imgbtnPtgDiscountType.Image = global::Vendstor.Properties.Resources.discount_sell_w;
            this.imgbtnPtgDiscountType.ImageActive = null;
            this.imgbtnPtgDiscountType.Location = new System.Drawing.Point(137, 51);
            this.imgbtnPtgDiscountType.Name = "imgbtnPtgDiscountType";
            this.imgbtnPtgDiscountType.Size = new System.Drawing.Size(62, 41);
            this.imgbtnPtgDiscountType.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgbtnPtgDiscountType.TabIndex = 60;
            this.imgbtnPtgDiscountType.TabStop = false;
            this.imgbtnPtgDiscountType.Zoom = 10;
            this.imgbtnPtgDiscountType.Click += new System.EventHandler(this.ImgbtnPtgDiscountType_Click);
            // 
            // imgbtnCashDiscountType
            // 
            this.imgbtnCashDiscountType.BackColor = System.Drawing.Color.White;
            this.imgbtnCashDiscountType.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imgbtnCashDiscountType.Image = global::Vendstor.Properties.Resources.cash_discount_w;
            this.imgbtnCashDiscountType.ImageActive = null;
            this.imgbtnCashDiscountType.Location = new System.Drawing.Point(204, 51);
            this.imgbtnCashDiscountType.Name = "imgbtnCashDiscountType";
            this.imgbtnCashDiscountType.Size = new System.Drawing.Size(62, 41);
            this.imgbtnCashDiscountType.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgbtnCashDiscountType.TabIndex = 59;
            this.imgbtnCashDiscountType.TabStop = false;
            this.imgbtnCashDiscountType.Zoom = 10;
            this.imgbtnCashDiscountType.Click += new System.EventHandler(this.ImgbtnCashDiscountType_Click);
            // 
            // imgbtnExit
            // 
            this.imgbtnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.imgbtnExit.BackColor = System.Drawing.Color.Transparent;
            this.imgbtnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imgbtnExit.Image = global::Vendstor.Properties.Resources.close_w;
            this.imgbtnExit.ImageActive = null;
            this.imgbtnExit.Location = new System.Drawing.Point(314, 12);
            this.imgbtnExit.Name = "imgbtnExit";
            this.imgbtnExit.Size = new System.Drawing.Size(20, 20);
            this.imgbtnExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgbtnExit.TabIndex = 57;
            this.imgbtnExit.TabStop = false;
            this.imgbtnExit.Zoom = 10;
            this.imgbtnExit.Click += new System.EventHandler(this.ImgbtnExit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAdd.BorderRadius = 5;
            this.btnAdd.ButtonText = "Add";
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.DisabledColor = System.Drawing.Color.Gray;
            this.btnAdd.Iconcolor = System.Drawing.Color.Transparent;
            this.btnAdd.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnAdd.Iconimage")));
            this.btnAdd.Iconimage_right = null;
            this.btnAdd.Iconimage_right_Selected = null;
            this.btnAdd.Iconimage_Selected = null;
            this.btnAdd.IconMarginLeft = 0;
            this.btnAdd.IconMarginRight = 0;
            this.btnAdd.IconRightVisible = true;
            this.btnAdd.IconRightZoom = 0D;
            this.btnAdd.IconVisible = false;
            this.btnAdd.IconZoom = 90D;
            this.btnAdd.IsTab = false;
            this.btnAdd.Location = new System.Drawing.Point(85, 287);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.btnAdd.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(53)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.btnAdd.OnHoverTextColor = System.Drawing.Color.White;
            this.btnAdd.selected = false;
            this.btnAdd.Size = new System.Drawing.Size(177, 38);
            this.btnAdd.TabIndex = 55;
            this.btnAdd.Text = "Add";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAdd.Textcolor = System.Drawing.Color.White;
            this.btnAdd.TextFont = new System.Drawing.Font("Poppins Light", 11.85F);
            this.btnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // Discount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(346, 349);
            this.Controls.Add(this.imgbtnExit);
            this.Controls.Add(this.imgbtnPtgDiscountType);
            this.Controls.Add(this.imgbtnCashDiscountType);
            this.Controls.Add(this.text_Text);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblUnit);
            this.Controls.Add(this.text_Name);
            this.Controls.Add(this.lblDiscountType);
            this.Controls.Add(this.txtDiscountName);
            this.Controls.Add(this.Seperator1_cpp);
            this.Controls.Add(this.text_disc_type);
            this.Controls.Add(this.txtDiscountValue);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Discount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vendstor - Point Of Sale : Discount";
            this.Load += new System.EventHandler(this.OnLoad);
            ((System.ComponentModel.ISupportInitialize)(this.imgbtnPtgDiscountType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgbtnCashDiscountType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgbtnExit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse ElipBorder;
        private System.Windows.Forms.Label text_disc_type;
        private Bunifu.Framework.UI.BunifuSeparator Seperator1_cpp;
        private System.Windows.Forms.Label text_Name;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtDiscountName;
        private Bunifu.Framework.UI.BunifuFlatButton btnAdd;
        private System.Windows.Forms.Label lblDiscountType;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtDiscountValue;
        private System.Windows.Forms.Label lblUnit;
        internal Bunifu.Framework.UI.BunifuCustomLabel text_Text;
        private Bunifu.Framework.UI.BunifuImageButton imgbtnExit;
        private Bunifu.Framework.UI.BunifuImageButton imgbtnPtgDiscountType;
        private Bunifu.Framework.UI.BunifuImageButton imgbtnCashDiscountType;
    }
}