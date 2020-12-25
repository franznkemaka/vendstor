namespace Vendstor.UserControls.Dashboard.Products
{
    partial class Tags
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
            this.flpnlTagsGrid = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlGridTitle = new System.Windows.Forms.Panel();
            this.GridTitle_Separator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.lblNumberOfProd = new System.Windows.Forms.Label();
            this.lblTagName = new System.Windows.Forms.Label();
            this.bunifuSeparator8 = new Bunifu.Framework.UI.BunifuSeparator();
            this.pnlFilter = new System.Windows.Forms.Panel();
            this.lblHint = new System.Windows.Forms.Label();
            this.btnAddTag = new Bunifu.Framework.UI.BunifuFlatButton();
            this.pnlGridTitle.SuspendLayout();
            this.pnlFilter.SuspendLayout();
            this.SuspendLayout();
            // 
            // flpnlTagsGrid
            // 
            this.flpnlTagsGrid.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.flpnlTagsGrid.AutoScroll = true;
            this.flpnlTagsGrid.BackColor = System.Drawing.Color.White;
            this.flpnlTagsGrid.Location = new System.Drawing.Point(9, 123);
            this.flpnlTagsGrid.Margin = new System.Windows.Forms.Padding(2);
            this.flpnlTagsGrid.Name = "flpnlTagsGrid";
            this.flpnlTagsGrid.Size = new System.Drawing.Size(1110, 465);
            this.flpnlTagsGrid.TabIndex = 135;
            // 
            // pnlGridTitle
            // 
            this.pnlGridTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pnlGridTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(246)))));
            this.pnlGridTitle.Controls.Add(this.GridTitle_Separator1);
            this.pnlGridTitle.Controls.Add(this.lblNumberOfProd);
            this.pnlGridTitle.Controls.Add(this.lblTagName);
            this.pnlGridTitle.Controls.Add(this.bunifuSeparator8);
            this.pnlGridTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.pnlGridTitle.Location = new System.Drawing.Point(13, 70);
            this.pnlGridTitle.Name = "pnlGridTitle";
            this.pnlGridTitle.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.pnlGridTitle.Size = new System.Drawing.Size(1106, 48);
            this.pnlGridTitle.TabIndex = 134;
            // 
            // GridTitle_Separator1
            // 
            this.GridTitle_Separator1.BackColor = System.Drawing.Color.Transparent;
            this.GridTitle_Separator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.GridTitle_Separator1.LineThickness = 1;
            this.GridTitle_Separator1.Location = new System.Drawing.Point(613, 10);
            this.GridTitle_Separator1.Margin = new System.Windows.Forms.Padding(7);
            this.GridTitle_Separator1.Name = "GridTitle_Separator1";
            this.GridTitle_Separator1.Size = new System.Drawing.Size(8, 28);
            this.GridTitle_Separator1.TabIndex = 173;
            this.GridTitle_Separator1.Transparency = 255;
            this.GridTitle_Separator1.Vertical = true;
            this.GridTitle_Separator1.Visible = false;
            // 
            // lblNumberOfProd
            // 
            this.lblNumberOfProd.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblNumberOfProd.AutoSize = true;
            this.lblNumberOfProd.Font = new System.Drawing.Font("Poppins", 12F);
            this.lblNumberOfProd.Location = new System.Drawing.Point(660, 10);
            this.lblNumberOfProd.Name = "lblNumberOfProd";
            this.lblNumberOfProd.Size = new System.Drawing.Size(169, 28);
            this.lblNumberOfProd.TabIndex = 171;
            this.lblNumberOfProd.Text = "Number of Products";
            // 
            // lblTagName
            // 
            this.lblTagName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTagName.AutoSize = true;
            this.lblTagName.Font = new System.Drawing.Font("Poppins", 12F);
            this.lblTagName.Location = new System.Drawing.Point(22, 10);
            this.lblTagName.Name = "lblTagName";
            this.lblTagName.Size = new System.Drawing.Size(60, 28);
            this.lblTagName.TabIndex = 169;
            this.lblTagName.Text = "Name";
            // 
            // bunifuSeparator8
            // 
            this.bunifuSeparator8.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator8.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(246)))));
            this.bunifuSeparator8.LineThickness = 1;
            this.bunifuSeparator8.Location = new System.Drawing.Point(1189, 14);
            this.bunifuSeparator8.Margin = new System.Windows.Forms.Padding(6);
            this.bunifuSeparator8.Name = "bunifuSeparator8";
            this.bunifuSeparator8.Size = new System.Drawing.Size(24, 44);
            this.bunifuSeparator8.TabIndex = 148;
            this.bunifuSeparator8.Transparency = 255;
            this.bunifuSeparator8.Vertical = true;
            // 
            // pnlFilter
            // 
            this.pnlFilter.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pnlFilter.BackColor = System.Drawing.Color.White;
            this.pnlFilter.Controls.Add(this.lblHint);
            this.pnlFilter.Controls.Add(this.btnAddTag);
            this.pnlFilter.Location = new System.Drawing.Point(13, 8);
            this.pnlFilter.Name = "pnlFilter";
            this.pnlFilter.Size = new System.Drawing.Size(1106, 56);
            this.pnlFilter.TabIndex = 133;
            // 
            // lblHint
            // 
            this.lblHint.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblHint.AutoSize = true;
            this.lblHint.Font = new System.Drawing.Font("Poppins Light", 10F);
            this.lblHint.ForeColor = System.Drawing.Color.Silver;
            this.lblHint.Location = new System.Drawing.Point(22, 16);
            this.lblHint.Name = "lblHint";
            this.lblHint.Size = new System.Drawing.Size(229, 25);
            this.lblHint.TabIndex = 171;
            this.lblHint.Text = "A list of all of your product tags.";
            // 
            // btnAddTag
            // 
            this.btnAddTag.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.btnAddTag.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnAddTag.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.btnAddTag.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddTag.BorderRadius = 5;
            this.btnAddTag.ButtonText = "Add Tag";
            this.btnAddTag.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddTag.DisabledColor = System.Drawing.Color.Gray;
            this.btnAddTag.Iconcolor = System.Drawing.Color.Transparent;
            this.btnAddTag.Iconimage = global::Vendstor.Properties.Resources.addTag_filled_w;
            this.btnAddTag.Iconimage_right = null;
            this.btnAddTag.Iconimage_right_Selected = null;
            this.btnAddTag.Iconimage_Selected = null;
            this.btnAddTag.IconMarginLeft = 0;
            this.btnAddTag.IconMarginRight = 0;
            this.btnAddTag.IconRightVisible = true;
            this.btnAddTag.IconRightZoom = 0D;
            this.btnAddTag.IconVisible = true;
            this.btnAddTag.IconZoom = 45D;
            this.btnAddTag.IsTab = false;
            this.btnAddTag.Location = new System.Drawing.Point(938, 8);
            this.btnAddTag.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddTag.Name = "btnAddTag";
            this.btnAddTag.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.btnAddTag.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.btnAddTag.OnHoverTextColor = System.Drawing.Color.White;
            this.btnAddTag.selected = false;
            this.btnAddTag.Size = new System.Drawing.Size(155, 40);
            this.btnAddTag.TabIndex = 133;
            this.btnAddTag.Text = "Add Tag";
            this.btnAddTag.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAddTag.Textcolor = System.Drawing.Color.White;
            this.btnAddTag.TextFont = new System.Drawing.Font("Poppins Light", 11F);
            this.btnAddTag.Click += new System.EventHandler(this.BtnAddTag_Click);
            // 
            // Tags
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(246)))));
            this.Controls.Add(this.flpnlTagsGrid);
            this.Controls.Add(this.pnlGridTitle);
            this.Controls.Add(this.pnlFilter);
            this.Name = "Tags";
            this.Size = new System.Drawing.Size(1128, 597);
            this.Load += new System.EventHandler(this.OnLoad);
            this.SizeChanged += new System.EventHandler(this.OnSizeChanged);
            this.pnlGridTitle.ResumeLayout(false);
            this.pnlGridTitle.PerformLayout();
            this.pnlFilter.ResumeLayout(false);
            this.pnlFilter.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.FlowLayoutPanel flpnlTagsGrid;
        private System.Windows.Forms.Panel pnlGridTitle;
        private Bunifu.Framework.UI.BunifuSeparator GridTitle_Separator1;
        private System.Windows.Forms.Label lblNumberOfProd;
        private System.Windows.Forms.Label lblTagName;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator8;
        private System.Windows.Forms.Panel pnlFilter;
        private System.Windows.Forms.Label lblHint;
        private Bunifu.Framework.UI.BunifuFlatButton btnAddTag;
    }
}
