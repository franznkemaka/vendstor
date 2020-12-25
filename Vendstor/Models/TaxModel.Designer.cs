namespace Vendstor.Models
{
    partial class TaxModel
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
            this.lblTaxShortName = new System.Windows.Forms.Label();
            this.lblTaxDescription = new System.Windows.Forms.Label();
            this.lblTaxRate = new System.Windows.Forms.Label();
            this.lblTotalTax = new System.Windows.Forms.Label();
            this.lblTaxName = new System.Windows.Forms.Label();
            this.imgpnlTax_DateRange = new System.Windows.Forms.Panel();
            this.imgbtnTax = new Bunifu.Framework.UI.BunifuImageButton();
            this.Indicator = new System.Windows.Forms.Panel();
            this.lblTaxStoreShortName = new System.Windows.Forms.Label();
            this.ElipBorder = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.imgpnlTax_DateRange.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgbtnTax)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTaxShortName
            // 
            this.lblTaxShortName.AutoSize = true;
            this.lblTaxShortName.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTaxShortName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblTaxShortName.Location = new System.Drawing.Point(262, 28);
            this.lblTaxShortName.Name = "lblTaxShortName";
            this.lblTaxShortName.Size = new System.Drawing.Size(68, 28);
            this.lblTaxShortName.TabIndex = 216;
            this.lblTaxShortName.Text = "(MwSt)";
            // 
            // lblTaxDescription
            // 
            this.lblTaxDescription.AutoSize = true;
            this.lblTaxDescription.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTaxDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblTaxDescription.Location = new System.Drawing.Point(37, 103);
            this.lblTaxDescription.MaximumSize = new System.Drawing.Size(450, 0);
            this.lblTaxDescription.Name = "lblTaxDescription";
            this.lblTaxDescription.Size = new System.Drawing.Size(445, 112);
            this.lblTaxDescription.TabIndex = 215;
            this.lblTaxDescription.Text = "Mehrwert Steuer, is a tax levied at several levels of value added, the amount of " +
    "which is used to offset the revenues of companies with the expenses of businesse" +
    "s.";
            // 
            // lblTaxRate
            // 
            this.lblTaxRate.AutoSize = true;
            this.lblTaxRate.Font = new System.Drawing.Font("Poppins", 15F);
            this.lblTaxRate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(175)))), ((int)(((byte)(0)))));
            this.lblTaxRate.Location = new System.Drawing.Point(449, 21);
            this.lblTaxRate.Name = "lblTaxRate";
            this.lblTaxRate.Size = new System.Drawing.Size(54, 35);
            this.lblTaxRate.TabIndex = 213;
            this.lblTaxRate.Text = "19 %";
            // 
            // lblTotalTax
            // 
            this.lblTotalTax.AutoSize = true;
            this.lblTotalTax.Font = new System.Drawing.Font("Poppins SemiBold", 20F, System.Drawing.FontStyle.Bold);
            this.lblTotalTax.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblTotalTax.Location = new System.Drawing.Point(122, 55);
            this.lblTotalTax.Name = "lblTotalTax";
            this.lblTotalTax.Size = new System.Drawing.Size(59, 48);
            this.lblTotalTax.TabIndex = 212;
            this.lblTotalTax.Text = "€0";
            // 
            // lblTaxName
            // 
            this.lblTaxName.AutoSize = true;
            this.lblTaxName.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTaxName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblTaxName.Location = new System.Drawing.Point(114, 28);
            this.lblTaxName.Name = "lblTaxName";
            this.lblTaxName.Size = new System.Drawing.Size(142, 28);
            this.lblTaxName.TabIndex = 211;
            this.lblTaxName.Text = "Mehrwert Steuer";
            // 
            // imgpnlTax_DateRange
            // 
            this.imgpnlTax_DateRange.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(175)))), ((int)(((byte)(0)))));
            this.imgpnlTax_DateRange.Controls.Add(this.imgbtnTax);
            this.imgpnlTax_DateRange.Location = new System.Drawing.Point(25, 39);
            this.imgpnlTax_DateRange.Name = "imgpnlTax_DateRange";
            this.imgpnlTax_DateRange.Size = new System.Drawing.Size(49, 47);
            this.imgpnlTax_DateRange.TabIndex = 214;
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
            // Indicator
            // 
            this.Indicator.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.Indicator.Location = new System.Drawing.Point(0, 0);
            this.Indicator.Name = "Indicator";
            this.Indicator.Size = new System.Drawing.Size(4, 226);
            this.Indicator.TabIndex = 217;
            this.Indicator.Visible = false;
            // 
            // lblTaxStoreShortName
            // 
            this.lblTaxStoreShortName.AutoSize = true;
            this.lblTaxStoreShortName.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTaxStoreShortName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblTaxStoreShortName.Location = new System.Drawing.Point(336, 28);
            this.lblTaxStoreShortName.Name = "lblTaxStoreShortName";
            this.lblTaxStoreShortName.Size = new System.Drawing.Size(23, 28);
            this.lblTaxStoreShortName.TabIndex = 218;
            this.lblTaxStoreShortName.Text = "A";
            // 
            // ElipBorder
            // 
            this.ElipBorder.ElipseRadius = 10;
            this.ElipBorder.TargetControl = this;
            // 
            // TaxModel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lblTaxStoreShortName);
            this.Controls.Add(this.Indicator);
            this.Controls.Add(this.lblTaxShortName);
            this.Controls.Add(this.lblTaxDescription);
            this.Controls.Add(this.lblTaxRate);
            this.Controls.Add(this.lblTotalTax);
            this.Controls.Add(this.lblTaxName);
            this.Controls.Add(this.imgpnlTax_DateRange);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Margin = new System.Windows.Forms.Padding(10);
            this.Name = "TaxModel";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Size = new System.Drawing.Size(518, 226);
            this.Load += new System.EventHandler(this.OnLoad);
            this.Click += new System.EventHandler(this.OnClick);
            this.imgpnlTax_DateRange.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgbtnTax)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblTaxShortName;
        private System.Windows.Forms.Label lblTaxDescription;
        private System.Windows.Forms.Label lblTaxRate;
        private System.Windows.Forms.Label lblTotalTax;
        private System.Windows.Forms.Label lblTaxName;
        private System.Windows.Forms.Panel imgpnlTax_DateRange;
        private Bunifu.Framework.UI.BunifuImageButton imgbtnTax;
        private System.Windows.Forms.Panel Indicator;
        private System.Windows.Forms.Label lblTaxStoreShortName;
        private Bunifu.Framework.UI.BunifuElipse ElipBorder;
    }
}
