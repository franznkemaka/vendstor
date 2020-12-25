namespace Vendstor.Models
{
    partial class SaleLedgerProductModel
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
            this.bunifuSeparator8 = new Bunifu.Framework.UI.BunifuSeparator();
            this.card_ProductQuantity = new Bunifu.Framework.UI.BunifuCards();
            this.lblProductQuantity = new System.Windows.Forms.Label();
            this.lblProductName = new System.Windows.Forms.Label();
            this.lblProductId = new System.Windows.Forms.Label();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.lblTaxAmount = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblDiscountView = new System.Windows.Forms.Label();
            this.card_ProductQuantity.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuSeparator8
            // 
            this.bunifuSeparator8.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator8.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bunifuSeparator8.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(246)))));
            this.bunifuSeparator8.LineThickness = 1;
            this.bunifuSeparator8.Location = new System.Drawing.Point(0, 45);
            this.bunifuSeparator8.Name = "bunifuSeparator8";
            this.bunifuSeparator8.Size = new System.Drawing.Size(757, 5);
            this.bunifuSeparator8.TabIndex = 146;
            this.bunifuSeparator8.Transparency = 255;
            this.bunifuSeparator8.Vertical = false;
            // 
            // card_ProductQuantity
            // 
            this.card_ProductQuantity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.card_ProductQuantity.BorderRadius = 5;
            this.card_ProductQuantity.BottomSahddow = true;
            this.card_ProductQuantity.color = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.card_ProductQuantity.Controls.Add(this.lblProductQuantity);
            this.card_ProductQuantity.LeftSahddow = false;
            this.card_ProductQuantity.Location = new System.Drawing.Point(12, 13);
            this.card_ProductQuantity.Name = "card_ProductQuantity";
            this.card_ProductQuantity.RightSahddow = true;
            this.card_ProductQuantity.ShadowDepth = 20;
            this.card_ProductQuantity.Size = new System.Drawing.Size(31, 24);
            this.card_ProductQuantity.TabIndex = 147;
            // 
            // lblProductQuantity
            // 
            this.lblProductQuantity.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblProductQuantity.Font = new System.Drawing.Font("Poppins", 10F);
            this.lblProductQuantity.ForeColor = System.Drawing.Color.White;
            this.lblProductQuantity.Location = new System.Drawing.Point(0, 0);
            this.lblProductQuantity.Name = "lblProductQuantity";
            this.lblProductQuantity.Size = new System.Drawing.Size(31, 24);
            this.lblProductQuantity.TabIndex = 58;
            this.lblProductQuantity.Text = "0";
            this.lblProductQuantity.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Font = new System.Drawing.Font("Poppins Light", 10.85F);
            this.lblProductName.Location = new System.Drawing.Point(59, 6);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(122, 26);
            this.lblProductName.TabIndex = 148;
            this.lblProductName.Text = "_ProductName";
            // 
            // lblProductId
            // 
            this.lblProductId.AutoSize = true;
            this.lblProductId.Font = new System.Drawing.Font("Poppins Light", 11F);
            this.lblProductId.ForeColor = System.Drawing.Color.DarkGray;
            this.lblProductId.Location = new System.Drawing.Point(268, 12);
            this.lblProductId.Name = "lblProductId";
            this.lblProductId.Size = new System.Drawing.Size(91, 26);
            this.lblProductId.TabIndex = 149;
            this.lblProductId.Text = "_ProductId";
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.AutoSize = true;
            this.lblSubtotal.Font = new System.Drawing.Font("Poppins", 11F);
            this.lblSubtotal.Location = new System.Drawing.Point(377, 11);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(82, 26);
            this.lblSubtotal.TabIndex = 150;
            this.lblSubtotal.Text = "@ €00,00";
            // 
            // lblTaxAmount
            // 
            this.lblTaxAmount.AutoSize = true;
            this.lblTaxAmount.Font = new System.Drawing.Font("Poppins Light", 10.85F);
            this.lblTaxAmount.Location = new System.Drawing.Point(466, 13);
            this.lblTaxAmount.Name = "lblTaxAmount";
            this.lblTaxAmount.Size = new System.Drawing.Size(155, 26);
            this.lblTaxAmount.TabIndex = 151;
            this.lblTaxAmount.Text = "+ € 0.00 Tax (Mwst)";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Poppins", 11F);
            this.lblTotal.Location = new System.Drawing.Point(673, 11);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(67, 26);
            this.lblTotal.TabIndex = 152;
            this.lblTotal.Text = "€ 00,00";
            // 
            // lblDiscountView
            // 
            this.lblDiscountView.AutoSize = true;
            this.lblDiscountView.Font = new System.Drawing.Font("Poppins Light", 8F);
            this.lblDiscountView.ForeColor = System.Drawing.Color.DarkGray;
            this.lblDiscountView.Location = new System.Drawing.Point(63, 25);
            this.lblDiscountView.Name = "lblDiscountView";
            this.lblDiscountView.Size = new System.Drawing.Size(145, 19);
            this.lblDiscountView.TabIndex = 153;
            this.lblDiscountView.Text = "Was : € 0 ; Disc :  0% /€ 0";
            // 
            // SaleLedgerProductModel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lblDiscountView);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblTaxAmount);
            this.Controls.Add(this.lblSubtotal);
            this.Controls.Add(this.lblProductId);
            this.Controls.Add(this.lblProductName);
            this.Controls.Add(this.card_ProductQuantity);
            this.Controls.Add(this.bunifuSeparator8);
            this.Name = "SaleLedgerProductModel";
            this.Size = new System.Drawing.Size(757, 50);
            this.Load += new System.EventHandler(this.OnLoad);
            this.card_ProductQuantity.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator8;
        private Bunifu.Framework.UI.BunifuCards card_ProductQuantity;
        private System.Windows.Forms.Label lblProductQuantity;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.Label lblProductId;
        private System.Windows.Forms.Label lblSubtotal;
        private System.Windows.Forms.Label lblTaxAmount;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblDiscountView;
    }
}
