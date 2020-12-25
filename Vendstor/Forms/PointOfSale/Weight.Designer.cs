namespace Vendstor.Forms.PointOfSale
{
    partial class Weight
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Weight));
            this.ElipBorder = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.text_Weight = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btnAdd = new Bunifu.Framework.UI.BunifuFlatButton();
            this.pnlWeightDisplay = new System.Windows.Forms.Panel();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.ElipPanel = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.txtQuantity = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.imgIsBalanceRequired = new Bunifu.Framework.UI.BunifuImageButton();
            this.pnlWeightDisplay.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgIsBalanceRequired)).BeginInit();
            this.SuspendLayout();
            // 
            // ElipBorder
            // 
            this.ElipBorder.ElipseRadius = 5;
            this.ElipBorder.TargetControl = this;
            // 
            // text_Weight
            // 
            this.text_Weight.Dock = System.Windows.Forms.DockStyle.Top;
            this.text_Weight.Font = new System.Drawing.Font("Poppins", 14F);
            this.text_Weight.Location = new System.Drawing.Point(0, 0);
            this.text_Weight.Name = "text_Weight";
            this.text_Weight.Size = new System.Drawing.Size(330, 47);
            this.text_Weight.TabIndex = 60;
            this.text_Weight.Text = "Add Weight (Kg)";
            this.text_Weight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.btnAdd.Location = new System.Drawing.Point(77, 260);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.btnAdd.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(53)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.btnAdd.OnHoverTextColor = System.Drawing.Color.White;
            this.btnAdd.selected = false;
            this.btnAdd.Size = new System.Drawing.Size(177, 38);
            this.btnAdd.TabIndex = 135;
            this.btnAdd.Text = "Add";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAdd.Textcolor = System.Drawing.Color.White;
            this.btnAdd.TextFont = new System.Drawing.Font("Poppins Light", 11.85F);
            this.btnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // pnlWeightDisplay
            // 
            this.pnlWeightDisplay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(66)))));
            this.pnlWeightDisplay.Controls.Add(this.lblQuantity);
            this.pnlWeightDisplay.Location = new System.Drawing.Point(66, 84);
            this.pnlWeightDisplay.Name = "pnlWeightDisplay";
            this.pnlWeightDisplay.Size = new System.Drawing.Size(198, 74);
            this.pnlWeightDisplay.TabIndex = 136;
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Font = new System.Drawing.Font("Poppins SemiBold", 20F, System.Drawing.FontStyle.Bold);
            this.lblQuantity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(255)))), ((int)(((byte)(197)))));
            this.lblQuantity.Location = new System.Drawing.Point(30, 13);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(0, 48);
            this.lblQuantity.TabIndex = 137;
            // 
            // ElipPanel
            // 
            this.ElipPanel.ElipseRadius = 20;
            this.ElipPanel.TargetControl = this.pnlWeightDisplay;
            // 
            // txtQuantity
            // 
            this.txtQuantity.AutoScroll = true;
            this.txtQuantity.AutoSize = true;
            this.txtQuantity.BackColor = System.Drawing.Color.White;
            this.txtQuantity.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.txtQuantity.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(246)))));
            this.txtQuantity.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.txtQuantity.BorderThickness = 2;
            this.txtQuantity.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtQuantity.Font = new System.Drawing.Font("Poppins SemiBold", 20F, System.Drawing.FontStyle.Bold);
            this.txtQuantity.ForeColor = System.Drawing.Color.DimGray;
            this.txtQuantity.isPassword = false;
            this.txtQuantity.Location = new System.Drawing.Point(88, 167);
            this.txtQuantity.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(155, 63);
            this.txtQuantity.TabIndex = 211;
            this.txtQuantity.Text = "1";
            this.txtQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtQuantity.OnValueChanged += new System.EventHandler(this.TxtQuantity_OnValueChanged);
            // 
            // imgIsBalanceRequired
            // 
            this.imgIsBalanceRequired.BackColor = System.Drawing.Color.Transparent;
            this.imgIsBalanceRequired.Image = global::Vendstor.Properties.Resources.scale_colored;
            this.imgIsBalanceRequired.ImageActive = null;
            this.imgIsBalanceRequired.Location = new System.Drawing.Point(139, 50);
            this.imgIsBalanceRequired.Name = "imgIsBalanceRequired";
            this.imgIsBalanceRequired.Size = new System.Drawing.Size(68, 28);
            this.imgIsBalanceRequired.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgIsBalanceRequired.TabIndex = 138;
            this.imgIsBalanceRequired.TabStop = false;
            this.imgIsBalanceRequired.Zoom = 10;
            // 
            // Weight
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(330, 310);
            this.Controls.Add(this.imgIsBalanceRequired);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.pnlWeightDisplay);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.text_Weight);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Weight";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vendstor - Weight";
            this.Load += new System.EventHandler(this.OnLoad);
            this.Click += new System.EventHandler(this.OnClick);
            this.pnlWeightDisplay.ResumeLayout(false);
            this.pnlWeightDisplay.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgIsBalanceRequired)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse ElipBorder;
        internal Bunifu.Framework.UI.BunifuCustomLabel text_Weight;
        private Bunifu.Framework.UI.BunifuFlatButton btnAdd;
        private System.Windows.Forms.Panel pnlWeightDisplay;
        private System.Windows.Forms.Label lblQuantity;
        private Bunifu.Framework.UI.BunifuElipse ElipPanel;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtQuantity;
        public Bunifu.Framework.UI.BunifuImageButton imgIsBalanceRequired;
    }
}