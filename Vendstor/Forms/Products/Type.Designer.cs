namespace Vendstor.Forms.Products
{
    partial class Type
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.text_TypeName = new System.Windows.Forms.Label();
            this.txtTypeName = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.btnAction = new Bunifu.Framework.UI.BunifuFlatButton();
            this.imgbtnExit = new Bunifu.Framework.UI.BunifuImageButton();
            this.imgValidInput = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.imgbtnExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgValidInput)).BeginInit();
            this.SuspendLayout();
            // 
            // ElipBorder
            // 
            this.ElipBorder.ElipseRadius = 5;
            this.ElipBorder.TargetControl = this;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Poppins", 13F);
            this.lblTitle.Location = new System.Drawing.Point(12, 12);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(134, 32);
            this.lblTitle.TabIndex = 212;
            this.lblTitle.Text = "Product Type";
            // 
            // text_TypeName
            // 
            this.text_TypeName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.text_TypeName.AutoSize = true;
            this.text_TypeName.Font = new System.Drawing.Font("Poppins Light", 11F);
            this.text_TypeName.Location = new System.Drawing.Point(38, 75);
            this.text_TypeName.Name = "text_TypeName";
            this.text_TypeName.Size = new System.Drawing.Size(95, 26);
            this.text_TypeName.TabIndex = 213;
            this.text_TypeName.Text = "Type Name";
            // 
            // txtTypeName
            // 
            this.txtTypeName.AutoScroll = true;
            this.txtTypeName.AutoSize = true;
            this.txtTypeName.BackColor = System.Drawing.Color.White;
            this.txtTypeName.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.txtTypeName.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(246)))));
            this.txtTypeName.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.txtTypeName.BorderThickness = 2;
            this.txtTypeName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTypeName.Font = new System.Drawing.Font("Poppins Light", 10.5F);
            this.txtTypeName.ForeColor = System.Drawing.Color.DimGray;
            this.txtTypeName.isPassword = false;
            this.txtTypeName.Location = new System.Drawing.Point(43, 117);
            this.txtTypeName.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtTypeName.Name = "txtTypeName";
            this.txtTypeName.Size = new System.Drawing.Size(401, 43);
            this.txtTypeName.TabIndex = 214;
            this.txtTypeName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtTypeName.OnValueChanged += new System.EventHandler(this.TypeNameValueChanged);
            // 
            // btnAction
            // 
            this.btnAction.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.btnAction.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnAction.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.btnAction.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAction.BorderRadius = 5;
            this.btnAction.ButtonText = "Add Type";
            this.btnAction.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAction.DisabledColor = System.Drawing.Color.Gray;
            this.btnAction.Iconcolor = System.Drawing.Color.Transparent;
            this.btnAction.Iconimage = global::Vendstor.Properties.Resources.type_filled_w;
            this.btnAction.Iconimage_right = null;
            this.btnAction.Iconimage_right_Selected = null;
            this.btnAction.Iconimage_Selected = null;
            this.btnAction.IconMarginLeft = 0;
            this.btnAction.IconMarginRight = 0;
            this.btnAction.IconRightVisible = true;
            this.btnAction.IconRightZoom = 0D;
            this.btnAction.IconVisible = true;
            this.btnAction.IconZoom = 40D;
            this.btnAction.IsTab = false;
            this.btnAction.Location = new System.Drawing.Point(289, 189);
            this.btnAction.Margin = new System.Windows.Forms.Padding(4);
            this.btnAction.Name = "btnAction";
            this.btnAction.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.btnAction.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.btnAction.OnHoverTextColor = System.Drawing.Color.White;
            this.btnAction.selected = false;
            this.btnAction.Size = new System.Drawing.Size(155, 40);
            this.btnAction.TabIndex = 215;
            this.btnAction.Text = "Add Type";
            this.btnAction.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAction.Textcolor = System.Drawing.Color.White;
            this.btnAction.TextFont = new System.Drawing.Font("Poppins Light", 11F);
            this.btnAction.Click += new System.EventHandler(this.BtnAction_Click);
            // 
            // imgbtnExit
            // 
            this.imgbtnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.imgbtnExit.BackColor = System.Drawing.Color.Transparent;
            this.imgbtnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imgbtnExit.Image = global::Vendstor.Properties.Resources.close_w1;
            this.imgbtnExit.ImageActive = null;
            this.imgbtnExit.Location = new System.Drawing.Point(458, 12);
            this.imgbtnExit.Name = "imgbtnExit";
            this.imgbtnExit.Size = new System.Drawing.Size(18, 17);
            this.imgbtnExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgbtnExit.TabIndex = 211;
            this.imgbtnExit.TabStop = false;
            this.imgbtnExit.Zoom = 10;
            this.imgbtnExit.Click += new System.EventHandler(this.ImgbtnExit_Click);
            // 
            // imgValidInput
            // 
            this.imgValidInput.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.imgValidInput.Location = new System.Drawing.Point(414, 124);
            this.imgValidInput.Name = "imgValidInput";
            this.imgValidInput.Size = new System.Drawing.Size(21, 31);
            this.imgValidInput.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgValidInput.TabIndex = 216;
            this.imgValidInput.TabStop = false;
            // 
            // Type
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(488, 276);
            this.Controls.Add(this.imgValidInput);
            this.Controls.Add(this.btnAction);
            this.Controls.Add(this.txtTypeName);
            this.Controls.Add(this.text_TypeName);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.imgbtnExit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Type";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vendstor - Product Type";
            this.Load += new System.EventHandler(this.OnLoad);
            ((System.ComponentModel.ISupportInitialize)(this.imgbtnExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgValidInput)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse ElipBorder;
        private Bunifu.Framework.UI.BunifuImageButton imgbtnExit;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label text_TypeName;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtTypeName;
        private Bunifu.Framework.UI.BunifuFlatButton btnAction;
        private System.Windows.Forms.PictureBox imgValidInput;
    }
}