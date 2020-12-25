namespace Vendstor.UserControls.Dashboard.Reports
{
    partial class Tax
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tax));
            this.cardTaxDateRange = new Bunifu.Framework.UI.BunifuCards();
            this.text_Revenue = new System.Windows.Forms.Label();
            this.lblRevenue_DateRange = new System.Windows.Forms.Label();
            this.lblTaxPercentage_DateRange = new System.Windows.Forms.Label();
            this.lblTotalTax_DateRange = new System.Windows.Forms.Label();
            this.lblTaxName = new System.Windows.Forms.Label();
            this.imgpnlTax_DateRange = new System.Windows.Forms.Panel();
            this.imgbtnTax = new Bunifu.Framework.UI.BunifuImageButton();
            this.pnlFilter = new System.Windows.Forms.Panel();
            this.switchFilterApply = new Bunifu.Framework.UI.BunifuiOSSwitch();
            this.btnFilter = new Bunifu.Framework.UI.BunifuFlatButton();
            this.dpDateTo = new Bunifu.Framework.UI.BunifuDatepicker();
            this.dpDateFrom = new Bunifu.Framework.UI.BunifuDatepicker();
            this.text_DateTo = new System.Windows.Forms.Label();
            this.text_From = new System.Windows.Forms.Label();
            this.cardTaxTotal = new Bunifu.Framework.UI.BunifuCards();
            this.text_TotalRevenue = new System.Windows.Forms.Label();
            this.lblTotalRevenue = new System.Windows.Forms.Label();
            this.lblTaxPercentage = new System.Windows.Forms.Label();
            this.lblTotalTax = new System.Windows.Forms.Label();
            this.text_Taxes = new System.Windows.Forms.Label();
            this.imgpnlTax_DateRange2 = new System.Windows.Forms.Panel();
            this.imgbtnTax2 = new Bunifu.Framework.UI.BunifuImageButton();
            this.cardTaxDateRange.SuspendLayout();
            this.imgpnlTax_DateRange.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgbtnTax)).BeginInit();
            this.pnlFilter.SuspendLayout();
            this.cardTaxTotal.SuspendLayout();
            this.imgpnlTax_DateRange2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgbtnTax2)).BeginInit();
            this.SuspendLayout();
            // 
            // cardTaxDateRange
            // 
            this.cardTaxDateRange.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cardTaxDateRange.BackColor = System.Drawing.Color.White;
            this.cardTaxDateRange.BorderRadius = 10;
            this.cardTaxDateRange.BottomSahddow = true;
            this.cardTaxDateRange.color = System.Drawing.Color.Transparent;
            this.cardTaxDateRange.Controls.Add(this.text_Revenue);
            this.cardTaxDateRange.Controls.Add(this.lblRevenue_DateRange);
            this.cardTaxDateRange.Controls.Add(this.lblTaxPercentage_DateRange);
            this.cardTaxDateRange.Controls.Add(this.lblTotalTax_DateRange);
            this.cardTaxDateRange.Controls.Add(this.lblTaxName);
            this.cardTaxDateRange.Controls.Add(this.imgpnlTax_DateRange);
            this.cardTaxDateRange.LeftSahddow = false;
            this.cardTaxDateRange.Location = new System.Drawing.Point(292, 401);
            this.cardTaxDateRange.Name = "cardTaxDateRange";
            this.cardTaxDateRange.RightSahddow = true;
            this.cardTaxDateRange.ShadowDepth = 10;
            this.cardTaxDateRange.Size = new System.Drawing.Size(545, 157);
            this.cardTaxDateRange.TabIndex = 1;
            this.cardTaxDateRange.Visible = false;
            // 
            // text_Revenue
            // 
            this.text_Revenue.AutoSize = true;
            this.text_Revenue.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_Revenue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.text_Revenue.Location = new System.Drawing.Point(355, 24);
            this.text_Revenue.Name = "text_Revenue";
            this.text_Revenue.Size = new System.Drawing.Size(170, 28);
            this.text_Revenue.TabIndex = 10;
            this.text_Revenue.Text = "Revenue (Exclusive)";
            // 
            // lblRevenue_DateRange
            // 
            this.lblRevenue_DateRange.AutoSize = true;
            this.lblRevenue_DateRange.Font = new System.Drawing.Font("Poppins SemiBold", 20F, System.Drawing.FontStyle.Bold);
            this.lblRevenue_DateRange.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblRevenue_DateRange.Location = new System.Drawing.Point(374, 55);
            this.lblRevenue_DateRange.Name = "lblRevenue_DateRange";
            this.lblRevenue_DateRange.Size = new System.Drawing.Size(120, 48);
            this.lblRevenue_DateRange.TabIndex = 9;
            this.lblRevenue_DateRange.Text = "€78441";
            // 
            // lblTaxPercentage_DateRange
            // 
            this.lblTaxPercentage_DateRange.AutoSize = true;
            this.lblTaxPercentage_DateRange.Font = new System.Drawing.Font("Poppins Light", 15F);
            this.lblTaxPercentage_DateRange.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(175)))), ((int)(((byte)(0)))));
            this.lblTaxPercentage_DateRange.Location = new System.Drawing.Point(207, 46);
            this.lblTaxPercentage_DateRange.Name = "lblTaxPercentage_DateRange";
            this.lblTaxPercentage_DateRange.Size = new System.Drawing.Size(54, 35);
            this.lblTaxPercentage_DateRange.TabIndex = 6;
            this.lblTaxPercentage_DateRange.Text = "19 %";
            // 
            // lblTotalTax_DateRange
            // 
            this.lblTotalTax_DateRange.AutoSize = true;
            this.lblTotalTax_DateRange.Font = new System.Drawing.Font("Poppins SemiBold", 20F, System.Drawing.FontStyle.Bold);
            this.lblTotalTax_DateRange.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblTotalTax_DateRange.Location = new System.Drawing.Point(91, 62);
            this.lblTotalTax_DateRange.Name = "lblTotalTax_DateRange";
            this.lblTotalTax_DateRange.Size = new System.Drawing.Size(110, 48);
            this.lblTotalTax_DateRange.TabIndex = 2;
            this.lblTotalTax_DateRange.Text = "€4356";
            // 
            // lblTaxName
            // 
            this.lblTaxName.AutoSize = true;
            this.lblTaxName.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTaxName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblTaxName.Location = new System.Drawing.Point(78, 24);
            this.lblTaxName.Name = "lblTaxName";
            this.lblTaxName.Size = new System.Drawing.Size(142, 28);
            this.lblTaxName.TabIndex = 1;
            this.lblTaxName.Text = "Mehrwert Steuer";
            // 
            // imgpnlTax_DateRange
            // 
            this.imgpnlTax_DateRange.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(175)))), ((int)(((byte)(0)))));
            this.imgpnlTax_DateRange.Controls.Add(this.imgbtnTax);
            this.imgpnlTax_DateRange.Location = new System.Drawing.Point(23, 18);
            this.imgpnlTax_DateRange.Name = "imgpnlTax_DateRange";
            this.imgpnlTax_DateRange.Size = new System.Drawing.Size(49, 47);
            this.imgpnlTax_DateRange.TabIndex = 8;
            // 
            // imgbtnTax
            // 
            this.imgbtnTax.BackColor = System.Drawing.Color.Transparent;
            this.imgbtnTax.Image = global::Vendstor.Properties.Resources.tax_filled_w;
            this.imgbtnTax.ImageActive = null;
            this.imgbtnTax.Location = new System.Drawing.Point(7, 6);
            this.imgbtnTax.Name = "imgbtnTax";
            this.imgbtnTax.Size = new System.Drawing.Size(35, 35);
            this.imgbtnTax.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgbtnTax.TabIndex = 3;
            this.imgbtnTax.TabStop = false;
            this.imgbtnTax.Zoom = 10;
            // 
            // pnlFilter
            // 
            this.pnlFilter.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pnlFilter.BackColor = System.Drawing.Color.White;
            this.pnlFilter.Controls.Add(this.switchFilterApply);
            this.pnlFilter.Controls.Add(this.btnFilter);
            this.pnlFilter.Controls.Add(this.dpDateTo);
            this.pnlFilter.Controls.Add(this.dpDateFrom);
            this.pnlFilter.Controls.Add(this.text_DateTo);
            this.pnlFilter.Controls.Add(this.text_From);
            this.pnlFilter.Location = new System.Drawing.Point(10, 14);
            this.pnlFilter.Name = "pnlFilter";
            this.pnlFilter.Size = new System.Drawing.Size(1108, 103);
            this.pnlFilter.TabIndex = 121;
            // 
            // switchFilterApply
            // 
            this.switchFilterApply.BackColor = System.Drawing.Color.Transparent;
            this.switchFilterApply.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("switchFilterApply.BackgroundImage")));
            this.switchFilterApply.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.switchFilterApply.Cursor = System.Windows.Forms.Cursors.Hand;
            this.switchFilterApply.Location = new System.Drawing.Point(718, 38);
            this.switchFilterApply.Name = "switchFilterApply";
            this.switchFilterApply.OffColor = System.Drawing.Color.Tomato;
            this.switchFilterApply.OnColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(202)))), ((int)(((byte)(94)))));
            this.switchFilterApply.Size = new System.Drawing.Size(35, 20);
            this.switchFilterApply.TabIndex = 137;
            this.switchFilterApply.Value = false;
            this.switchFilterApply.Click += new System.EventHandler(this.SwitchFilterApply_Click);
            // 
            // btnFilter
            // 
            this.btnFilter.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.btnFilter.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnFilter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.btnFilter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFilter.BorderRadius = 5;
            this.btnFilter.ButtonText = "Filter";
            this.btnFilter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFilter.DisabledColor = System.Drawing.Color.Gray;
            this.btnFilter.Iconcolor = System.Drawing.Color.Transparent;
            this.btnFilter.Iconimage = global::Vendstor.Properties.Resources.filter_filled_w;
            this.btnFilter.Iconimage_right = null;
            this.btnFilter.Iconimage_right_Selected = null;
            this.btnFilter.Iconimage_Selected = null;
            this.btnFilter.IconMarginLeft = 0;
            this.btnFilter.IconMarginRight = 0;
            this.btnFilter.IconRightVisible = true;
            this.btnFilter.IconRightZoom = 0D;
            this.btnFilter.IconVisible = true;
            this.btnFilter.IconZoom = 45D;
            this.btnFilter.IsTab = false;
            this.btnFilter.Location = new System.Drawing.Point(939, 29);
            this.btnFilter.Margin = new System.Windows.Forms.Padding(4);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.btnFilter.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.btnFilter.OnHoverTextColor = System.Drawing.Color.White;
            this.btnFilter.selected = false;
            this.btnFilter.Size = new System.Drawing.Size(126, 45);
            this.btnFilter.TabIndex = 129;
            this.btnFilter.Text = "Filter";
            this.btnFilter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnFilter.Textcolor = System.Drawing.Color.White;
            this.btnFilter.TextFont = new System.Drawing.Font("Poppins Light", 11F);
            this.btnFilter.Click += new System.EventHandler(this.BtnFilter_Click);
            // 
            // dpDateTo
            // 
            this.dpDateTo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dpDateTo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(246)))));
            this.dpDateTo.BorderRadius = 0;
            this.dpDateTo.ForeColor = System.Drawing.Color.DimGray;
            this.dpDateTo.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dpDateTo.FormatCustom = null;
            this.dpDateTo.Location = new System.Drawing.Point(337, 38);
            this.dpDateTo.Margin = new System.Windows.Forms.Padding(4);
            this.dpDateTo.Name = "dpDateTo";
            this.dpDateTo.Size = new System.Drawing.Size(276, 36);
            this.dpDateTo.TabIndex = 128;
            this.dpDateTo.Value = new System.DateTime(2018, 7, 13, 17, 53, 8, 9);
            // 
            // dpDateFrom
            // 
            this.dpDateFrom.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dpDateFrom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(246)))));
            this.dpDateFrom.BorderRadius = 0;
            this.dpDateFrom.ForeColor = System.Drawing.Color.DimGray;
            this.dpDateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dpDateFrom.FormatCustom = null;
            this.dpDateFrom.Location = new System.Drawing.Point(42, 40);
            this.dpDateFrom.Margin = new System.Windows.Forms.Padding(4);
            this.dpDateFrom.Name = "dpDateFrom";
            this.dpDateFrom.Size = new System.Drawing.Size(276, 36);
            this.dpDateFrom.TabIndex = 127;
            this.dpDateFrom.Value = new System.DateTime(2018, 7, 13, 17, 53, 8, 9);
            // 
            // text_DateTo
            // 
            this.text_DateTo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.text_DateTo.AutoSize = true;
            this.text_DateTo.Font = new System.Drawing.Font("Poppins Light", 11F);
            this.text_DateTo.Location = new System.Drawing.Point(341, 11);
            this.text_DateTo.Name = "text_DateTo";
            this.text_DateTo.Size = new System.Drawing.Size(69, 26);
            this.text_DateTo.TabIndex = 126;
            this.text_DateTo.Text = "Date To";
            // 
            // text_From
            // 
            this.text_From.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.text_From.AutoSize = true;
            this.text_From.Font = new System.Drawing.Font("Poppins Light", 11F);
            this.text_From.Location = new System.Drawing.Point(47, 11);
            this.text_From.Name = "text_From";
            this.text_From.Size = new System.Drawing.Size(88, 26);
            this.text_From.TabIndex = 125;
            this.text_From.Text = "Date From";
            // 
            // cardTaxTotal
            // 
            this.cardTaxTotal.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cardTaxTotal.BackColor = System.Drawing.Color.White;
            this.cardTaxTotal.BorderRadius = 10;
            this.cardTaxTotal.BottomSahddow = true;
            this.cardTaxTotal.color = System.Drawing.Color.Transparent;
            this.cardTaxTotal.Controls.Add(this.text_TotalRevenue);
            this.cardTaxTotal.Controls.Add(this.lblTotalRevenue);
            this.cardTaxTotal.Controls.Add(this.lblTaxPercentage);
            this.cardTaxTotal.Controls.Add(this.lblTotalTax);
            this.cardTaxTotal.Controls.Add(this.text_Taxes);
            this.cardTaxTotal.Controls.Add(this.imgpnlTax_DateRange2);
            this.cardTaxTotal.LeftSahddow = false;
            this.cardTaxTotal.Location = new System.Drawing.Point(292, 220);
            this.cardTaxTotal.Name = "cardTaxTotal";
            this.cardTaxTotal.RightSahddow = true;
            this.cardTaxTotal.ShadowDepth = 10;
            this.cardTaxTotal.Size = new System.Drawing.Size(545, 157);
            this.cardTaxTotal.TabIndex = 129;
            // 
            // text_TotalRevenue
            // 
            this.text_TotalRevenue.AutoSize = true;
            this.text_TotalRevenue.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_TotalRevenue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.text_TotalRevenue.Location = new System.Drawing.Point(302, 24);
            this.text_TotalRevenue.Name = "text_TotalRevenue";
            this.text_TotalRevenue.Size = new System.Drawing.Size(214, 28);
            this.text_TotalRevenue.TabIndex = 10;
            this.text_TotalRevenue.Text = "Total Revenue (Exclusive)";
            // 
            // lblTotalRevenue
            // 
            this.lblTotalRevenue.AutoSize = true;
            this.lblTotalRevenue.Font = new System.Drawing.Font("Poppins SemiBold", 20F, System.Drawing.FontStyle.Bold);
            this.lblTotalRevenue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblTotalRevenue.Location = new System.Drawing.Point(359, 62);
            this.lblTotalRevenue.Name = "lblTotalRevenue";
            this.lblTotalRevenue.Size = new System.Drawing.Size(123, 48);
            this.lblTotalRevenue.TabIndex = 9;
            this.lblTotalRevenue.Text = "€ 00.00";
            // 
            // lblTaxPercentage
            // 
            this.lblTaxPercentage.AutoSize = true;
            this.lblTaxPercentage.BackColor = System.Drawing.Color.Transparent;
            this.lblTaxPercentage.Font = new System.Drawing.Font("Poppins Light", 15F);
            this.lblTaxPercentage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(175)))), ((int)(((byte)(0)))));
            this.lblTaxPercentage.Location = new System.Drawing.Point(182, 30);
            this.lblTaxPercentage.Name = "lblTaxPercentage";
            this.lblTaxPercentage.Size = new System.Drawing.Size(54, 35);
            this.lblTaxPercentage.TabIndex = 6;
            this.lblTaxPercentage.Text = "19 %";
            this.lblTaxPercentage.Visible = false;
            // 
            // lblTotalTax
            // 
            this.lblTotalTax.AutoSize = true;
            this.lblTotalTax.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalTax.Font = new System.Drawing.Font("Poppins SemiBold", 20F, System.Drawing.FontStyle.Bold);
            this.lblTotalTax.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblTotalTax.Location = new System.Drawing.Point(75, 62);
            this.lblTotalTax.Name = "lblTotalTax";
            this.lblTotalTax.Size = new System.Drawing.Size(123, 48);
            this.lblTotalTax.TabIndex = 2;
            this.lblTotalTax.Text = "€ 00.00";
            // 
            // text_Taxes
            // 
            this.text_Taxes.AutoSize = true;
            this.text_Taxes.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_Taxes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.text_Taxes.Location = new System.Drawing.Point(78, 24);
            this.text_Taxes.Name = "text_Taxes";
            this.text_Taxes.Size = new System.Drawing.Size(81, 28);
            this.text_Taxes.TabIndex = 1;
            this.text_Taxes.Text = "All Taxes";
            // 
            // imgpnlTax_DateRange2
            // 
            this.imgpnlTax_DateRange2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(175)))), ((int)(((byte)(0)))));
            this.imgpnlTax_DateRange2.Controls.Add(this.imgbtnTax2);
            this.imgpnlTax_DateRange2.Location = new System.Drawing.Point(23, 18);
            this.imgpnlTax_DateRange2.Name = "imgpnlTax_DateRange2";
            this.imgpnlTax_DateRange2.Size = new System.Drawing.Size(49, 47);
            this.imgpnlTax_DateRange2.TabIndex = 8;
            // 
            // imgbtnTax2
            // 
            this.imgbtnTax2.BackColor = System.Drawing.Color.Transparent;
            this.imgbtnTax2.Image = global::Vendstor.Properties.Resources.tax_filled_w;
            this.imgbtnTax2.ImageActive = null;
            this.imgbtnTax2.Location = new System.Drawing.Point(7, 6);
            this.imgbtnTax2.Name = "imgbtnTax2";
            this.imgbtnTax2.Size = new System.Drawing.Size(35, 35);
            this.imgbtnTax2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgbtnTax2.TabIndex = 3;
            this.imgbtnTax2.TabStop = false;
            this.imgbtnTax2.Zoom = 10;
            // 
            // Tax
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(246)))));
            this.Controls.Add(this.cardTaxTotal);
            this.Controls.Add(this.pnlFilter);
            this.Controls.Add(this.cardTaxDateRange);
            this.Name = "Tax";
            this.Size = new System.Drawing.Size(1128, 597);
            this.Load += new System.EventHandler(this.OnLoad);
            this.cardTaxDateRange.ResumeLayout(false);
            this.cardTaxDateRange.PerformLayout();
            this.imgpnlTax_DateRange.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgbtnTax)).EndInit();
            this.pnlFilter.ResumeLayout(false);
            this.pnlFilter.PerformLayout();
            this.cardTaxTotal.ResumeLayout(false);
            this.cardTaxTotal.PerformLayout();
            this.imgpnlTax_DateRange2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgbtnTax2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCards cardTaxDateRange;
        private System.Windows.Forms.Label lblTaxPercentage_DateRange;
        private System.Windows.Forms.Label lblTotalTax_DateRange;
        private System.Windows.Forms.Label lblTaxName;
        private System.Windows.Forms.Panel imgpnlTax_DateRange;
        private Bunifu.Framework.UI.BunifuImageButton imgbtnTax;
        private System.Windows.Forms.Panel pnlFilter;
        private Bunifu.Framework.UI.BunifuDatepicker dpDateTo;
        private Bunifu.Framework.UI.BunifuDatepicker dpDateFrom;
        private System.Windows.Forms.Label text_DateTo;
        private System.Windows.Forms.Label text_From;
        private System.Windows.Forms.Label text_Revenue;
        private System.Windows.Forms.Label lblRevenue_DateRange;
        private Bunifu.Framework.UI.BunifuCards cardTaxTotal;
        private System.Windows.Forms.Label text_TotalRevenue;
        private System.Windows.Forms.Label lblTotalRevenue;
        private System.Windows.Forms.Label lblTaxPercentage;
        private System.Windows.Forms.Label lblTotalTax;
        private System.Windows.Forms.Label text_Taxes;
        private System.Windows.Forms.Panel imgpnlTax_DateRange2;
        private Bunifu.Framework.UI.BunifuImageButton imgbtnTax2;
        private Bunifu.Framework.UI.BunifuFlatButton btnFilter;
        private Bunifu.Framework.UI.BunifuiOSSwitch switchFilterApply;
    }
}
