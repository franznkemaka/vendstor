namespace Vendstor.Forms.PointOfSale
{
    partial class PaymentVoid
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PaymentVoid));
            this.ElipBorder = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.VerticalSeperator = new Bunifu.Framework.UI.BunifuSeparator();
            this.lblPaymentStatus = new System.Windows.Forms.Label();
            this.btnDone = new Bunifu.Framework.UI.BunifuFlatButton();
            this.text_SaleSummary = new System.Windows.Forms.Label();
            this.bunifuSeparator2 = new Bunifu.Framework.UI.BunifuSeparator();
            this.btnPrintReceipt = new Bunifu.Framework.UI.BunifuFlatButton();
            this.imgVectorSuccess = new Bunifu.Framework.UI.BunifuImageButton();
            this.pnlPayment = new System.Windows.Forms.Panel();
            this.receiptPreview = new Microsoft.Reporting.WinForms.ReportViewer();
            this.pnlReceiptPreview = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.imgVectorSuccess)).BeginInit();
            this.pnlPayment.SuspendLayout();
            this.pnlReceiptPreview.SuspendLayout();
            this.SuspendLayout();
            // 
            // ElipBorder
            // 
            this.ElipBorder.ElipseRadius = 5;
            this.ElipBorder.TargetControl = this;
            // 
            // VerticalSeperator
            // 
            this.VerticalSeperator.BackColor = System.Drawing.Color.Transparent;
            this.VerticalSeperator.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(246)))));
            this.VerticalSeperator.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(246)))));
            this.VerticalSeperator.LineThickness = 1;
            this.VerticalSeperator.Location = new System.Drawing.Point(392, 1);
            this.VerticalSeperator.Margin = new System.Windows.Forms.Padding(4);
            this.VerticalSeperator.Name = "VerticalSeperator";
            this.VerticalSeperator.Size = new System.Drawing.Size(10, 560);
            this.VerticalSeperator.TabIndex = 0;
            this.VerticalSeperator.Transparency = 255;
            this.VerticalSeperator.Vertical = true;
            // 
            // lblPaymentStatus
            // 
            this.lblPaymentStatus.Font = new System.Drawing.Font("Poppins", 25F);
            this.lblPaymentStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblPaymentStatus.Location = new System.Drawing.Point(0, 240);
            this.lblPaymentStatus.Name = "lblPaymentStatus";
            this.lblPaymentStatus.Size = new System.Drawing.Size(483, 60);
            this.lblPaymentStatus.TabIndex = 57;
            this.lblPaymentStatus.Text = "Payment Received";
            this.lblPaymentStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnDone
            // 
            this.btnDone.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.btnDone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.btnDone.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDone.BorderRadius = 5;
            this.btnDone.ButtonText = "Done (ESC)";
            this.btnDone.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDone.DisabledColor = System.Drawing.Color.Gray;
            this.btnDone.Iconcolor = System.Drawing.Color.Transparent;
            this.btnDone.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnDone.Iconimage")));
            this.btnDone.Iconimage_right = null;
            this.btnDone.Iconimage_right_Selected = null;
            this.btnDone.Iconimage_Selected = null;
            this.btnDone.IconMarginLeft = 10;
            this.btnDone.IconMarginRight = 0;
            this.btnDone.IconRightVisible = true;
            this.btnDone.IconRightZoom = 0D;
            this.btnDone.IconVisible = true;
            this.btnDone.IconZoom = 30D;
            this.btnDone.IsTab = false;
            this.btnDone.Location = new System.Drawing.Point(53, 398);
            this.btnDone.Margin = new System.Windows.Forms.Padding(4);
            this.btnDone.Name = "btnDone";
            this.btnDone.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.btnDone.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.btnDone.OnHoverTextColor = System.Drawing.Color.White;
            this.btnDone.selected = false;
            this.btnDone.Size = new System.Drawing.Size(377, 47);
            this.btnDone.TabIndex = 63;
            this.btnDone.Text = "Done (ESC)";
            this.btnDone.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnDone.Textcolor = System.Drawing.Color.White;
            this.btnDone.TextFont = new System.Drawing.Font("Poppins Light", 13.5F);
            this.btnDone.Click += new System.EventHandler(this.BtnDone_Click);
            // 
            // text_SaleSummary
            // 
            this.text_SaleSummary.AutoSize = true;
            this.text_SaleSummary.Font = new System.Drawing.Font("Poppins", 15F);
            this.text_SaleSummary.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.text_SaleSummary.Location = new System.Drawing.Point(15, 23);
            this.text_SaleSummary.Name = "text_SaleSummary";
            this.text_SaleSummary.Size = new System.Drawing.Size(162, 35);
            this.text_SaleSummary.TabIndex = 62;
            this.text_SaleSummary.Text = "Sale Summary";
            // 
            // bunifuSeparator2
            // 
            this.bunifuSeparator2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator2.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(246)))));
            this.bunifuSeparator2.LineThickness = 2;
            this.bunifuSeparator2.Location = new System.Drawing.Point(22, 53);
            this.bunifuSeparator2.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuSeparator2.Name = "bunifuSeparator2";
            this.bunifuSeparator2.Size = new System.Drawing.Size(151, 10);
            this.bunifuSeparator2.TabIndex = 75;
            this.bunifuSeparator2.Transparency = 255;
            this.bunifuSeparator2.Vertical = false;
            // 
            // btnPrintReceipt
            // 
            this.btnPrintReceipt.Activecolor = System.Drawing.Color.Transparent;
            this.btnPrintReceipt.BackColor = System.Drawing.Color.Transparent;
            this.btnPrintReceipt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPrintReceipt.BorderRadius = 5;
            this.btnPrintReceipt.ButtonText = " Print Receipt (P)";
            this.btnPrintReceipt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrintReceipt.DisabledColor = System.Drawing.Color.Transparent;
            this.btnPrintReceipt.Iconcolor = System.Drawing.Color.Transparent;
            this.btnPrintReceipt.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnPrintReceipt.Iconimage")));
            this.btnPrintReceipt.Iconimage_right = null;
            this.btnPrintReceipt.Iconimage_right_Selected = null;
            this.btnPrintReceipt.Iconimage_Selected = null;
            this.btnPrintReceipt.IconMarginLeft = 4;
            this.btnPrintReceipt.IconMarginRight = 0;
            this.btnPrintReceipt.IconRightVisible = true;
            this.btnPrintReceipt.IconRightZoom = 0D;
            this.btnPrintReceipt.IconVisible = true;
            this.btnPrintReceipt.IconZoom = 45D;
            this.btnPrintReceipt.IsTab = false;
            this.btnPrintReceipt.Location = new System.Drawing.Point(148, 306);
            this.btnPrintReceipt.Margin = new System.Windows.Forms.Padding(4);
            this.btnPrintReceipt.Name = "btnPrintReceipt";
            this.btnPrintReceipt.Normalcolor = System.Drawing.Color.Transparent;
            this.btnPrintReceipt.OnHovercolor = System.Drawing.Color.Transparent;
            this.btnPrintReceipt.OnHoverTextColor = System.Drawing.SystemColors.ControlText;
            this.btnPrintReceipt.selected = false;
            this.btnPrintReceipt.Size = new System.Drawing.Size(186, 57);
            this.btnPrintReceipt.TabIndex = 76;
            this.btnPrintReceipt.Text = " Print Receipt (P)";
            this.btnPrintReceipt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnPrintReceipt.Textcolor = System.Drawing.SystemColors.ControlText;
            this.btnPrintReceipt.TextFont = new System.Drawing.Font("Poppins Light", 11.5F);
            this.btnPrintReceipt.Click += new System.EventHandler(this.BtnPrintReceipt_Click);
            // 
            // imgVectorSuccess
            // 
            this.imgVectorSuccess.BackColor = System.Drawing.Color.Transparent;
            this.imgVectorSuccess.Image = ((System.Drawing.Image)(resources.GetObject("imgVectorSuccess.Image")));
            this.imgVectorSuccess.ImageActive = null;
            this.imgVectorSuccess.Location = new System.Drawing.Point(76, 41);
            this.imgVectorSuccess.Name = "imgVectorSuccess";
            this.imgVectorSuccess.Size = new System.Drawing.Size(331, 187);
            this.imgVectorSuccess.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgVectorSuccess.TabIndex = 182;
            this.imgVectorSuccess.TabStop = false;
            this.imgVectorSuccess.Zoom = 10;
            // 
            // pnlPayment
            // 
            this.pnlPayment.Controls.Add(this.imgVectorSuccess);
            this.pnlPayment.Controls.Add(this.btnDone);
            this.pnlPayment.Controls.Add(this.lblPaymentStatus);
            this.pnlPayment.Controls.Add(this.btnPrintReceipt);
            this.pnlPayment.Location = new System.Drawing.Point(409, 12);
            this.pnlPayment.Name = "pnlPayment";
            this.pnlPayment.Size = new System.Drawing.Size(483, 537);
            this.pnlPayment.TabIndex = 183;
            // 
            // receiptPreview
            // 
            this.receiptPreview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(246)))));
            this.receiptPreview.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.receiptPreview.LocalReport.ReportEmbeddedResource = "Vendstor.Templates.MiniReceipt.rdlc";
            this.receiptPreview.Location = new System.Drawing.Point(7, 16);
            this.receiptPreview.Name = "receiptPreview";
            this.receiptPreview.ServerReport.BearerToken = null;
            this.receiptPreview.Size = new System.Drawing.Size(358, 464);
            this.receiptPreview.TabIndex = 184;
            // 
            // pnlReceiptPreview
            // 
            this.pnlReceiptPreview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(246)))));
            this.pnlReceiptPreview.Controls.Add(this.receiptPreview);
            this.pnlReceiptPreview.Location = new System.Drawing.Point(11, 61);
            this.pnlReceiptPreview.Name = "pnlReceiptPreview";
            this.pnlReceiptPreview.Size = new System.Drawing.Size(373, 496);
            this.pnlReceiptPreview.TabIndex = 184;
            // 
            // PaymentVoid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(904, 561);
            this.Controls.Add(this.pnlReceiptPreview);
            this.Controls.Add(this.pnlPayment);
            this.Controls.Add(this.bunifuSeparator2);
            this.Controls.Add(this.text_SaleSummary);
            this.Controls.Add(this.VerticalSeperator);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "PaymentVoid";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vendstor - Payment Void";
            this.Load += new System.EventHandler(this.OnLoad);
            ((System.ComponentModel.ISupportInitialize)(this.imgVectorSuccess)).EndInit();
            this.pnlPayment.ResumeLayout(false);
            this.pnlReceiptPreview.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse ElipBorder;
        private Bunifu.Framework.UI.BunifuSeparator VerticalSeperator;
        private System.Windows.Forms.Label lblPaymentStatus;
        private Bunifu.Framework.UI.BunifuFlatButton btnDone;
        private System.Windows.Forms.Label text_SaleSummary;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator2;
        private Bunifu.Framework.UI.BunifuFlatButton btnPrintReceipt;
        private Bunifu.Framework.UI.BunifuImageButton imgVectorSuccess;
        private System.Windows.Forms.Panel pnlPayment;
        private Microsoft.Reporting.WinForms.ReportViewer receiptPreview;
        private System.Windows.Forms.Panel pnlReceiptPreview;
    }
}