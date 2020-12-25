namespace Vendstor.Forms
{
    partial class Printing
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
            this.pnlReceiptPreview = new System.Windows.Forms.Panel();
            this.productLabelViewer = new Microsoft.Reporting.WinForms.ReportViewer();
            this.reedemReceiptViewer = new Microsoft.Reporting.WinForms.ReportViewer();
            this.saleReceiptViewer = new Microsoft.Reporting.WinForms.ReportViewer();
            this.sep = new Bunifu.Framework.UI.BunifuSeparator();
            this.text_Print = new System.Windows.Forms.Label();
            this.btnExit = new Bunifu.Framework.UI.BunifuImageButton();
            this.pnlReceiptPreview.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).BeginInit();
            this.SuspendLayout();
            // 
            // ElipBorder
            // 
            this.ElipBorder.ElipseRadius = 5;
            this.ElipBorder.TargetControl = this;
            // 
            // pnlReceiptPreview
            // 
            this.pnlReceiptPreview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(246)))));
            this.pnlReceiptPreview.Controls.Add(this.productLabelViewer);
            this.pnlReceiptPreview.Controls.Add(this.reedemReceiptViewer);
            this.pnlReceiptPreview.Controls.Add(this.saleReceiptViewer);
            this.pnlReceiptPreview.Location = new System.Drawing.Point(2, 76);
            this.pnlReceiptPreview.Name = "pnlReceiptPreview";
            this.pnlReceiptPreview.Size = new System.Drawing.Size(796, 496);
            this.pnlReceiptPreview.TabIndex = 187;
            // 
            // productLabelViewer
            // 
            this.productLabelViewer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(246)))));
            this.productLabelViewer.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.productLabelViewer.LocalReport.ReportEmbeddedResource = "Vendstor.Templates.ProductLabel.rdlc";
            this.productLabelViewer.Location = new System.Drawing.Point(482, 18);
            this.productLabelViewer.Name = "productLabelViewer";
            this.productLabelViewer.ServerReport.BearerToken = null;
            this.productLabelViewer.Size = new System.Drawing.Size(139, 91);
            this.productLabelViewer.TabIndex = 186;
            this.productLabelViewer.Visible = false;
            // 
            // reedemReceiptViewer
            // 
            this.reedemReceiptViewer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(246)))));
            this.reedemReceiptViewer.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.reedemReceiptViewer.LocalReport.ReportEmbeddedResource = "Vendstor.Templates.ReedemReceipt.rdlc";
            this.reedemReceiptViewer.Location = new System.Drawing.Point(234, 28);
            this.reedemReceiptViewer.Name = "reedemReceiptViewer";
            this.reedemReceiptViewer.ServerReport.BearerToken = null;
            this.reedemReceiptViewer.Size = new System.Drawing.Size(139, 91);
            this.reedemReceiptViewer.TabIndex = 185;
            this.reedemReceiptViewer.Visible = false;
            // 
            // saleReceiptViewer
            // 
            this.saleReceiptViewer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(246)))));
            this.saleReceiptViewer.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.saleReceiptViewer.LocalReport.ReportEmbeddedResource = "Vendstor.Templates.MiniReceipt.rdlc";
            this.saleReceiptViewer.Location = new System.Drawing.Point(31, 28);
            this.saleReceiptViewer.Name = "saleReceiptViewer";
            this.saleReceiptViewer.ServerReport.BearerToken = null;
            this.saleReceiptViewer.Size = new System.Drawing.Size(139, 91);
            this.saleReceiptViewer.TabIndex = 184;
            this.saleReceiptViewer.Visible = false;
            // 
            // sep
            // 
            this.sep.BackColor = System.Drawing.Color.Transparent;
            this.sep.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(246)))));
            this.sep.LineThickness = 2;
            this.sep.Location = new System.Drawing.Point(2, 59);
            this.sep.Margin = new System.Windows.Forms.Padding(4);
            this.sep.Name = "sep";
            this.sep.Size = new System.Drawing.Size(296, 10);
            this.sep.TabIndex = 186;
            this.sep.Transparency = 255;
            this.sep.Vertical = false;
            // 
            // text_Print
            // 
            this.text_Print.AutoSize = true;
            this.text_Print.Font = new System.Drawing.Font("Poppins", 15F);
            this.text_Print.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.text_Print.Location = new System.Drawing.Point(27, 20);
            this.text_Print.Name = "text_Print";
            this.text_Print.Size = new System.Drawing.Size(59, 35);
            this.text_Print.TabIndex = 185;
            this.text_Print.Text = "Print";
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.Image = global::Vendstor.Properties.Resources.close_w1;
            this.btnExit.ImageActive = null;
            this.btnExit.Location = new System.Drawing.Point(768, 20);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(20, 20);
            this.btnExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnExit.TabIndex = 188;
            this.btnExit.TabStop = false;
            this.btnExit.Zoom = 10;
            this.btnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // Printing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 577);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.pnlReceiptPreview);
            this.Controls.Add(this.sep);
            this.Controls.Add(this.text_Print);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Printing";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vendstor - Print Viewer";
            this.Load += new System.EventHandler(this.OnLoad);
            this.pnlReceiptPreview.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse ElipBorder;
        private System.Windows.Forms.Panel pnlReceiptPreview;
        private Microsoft.Reporting.WinForms.ReportViewer saleReceiptViewer;
        private Bunifu.Framework.UI.BunifuSeparator sep;
        private System.Windows.Forms.Label text_Print;
        private Bunifu.Framework.UI.BunifuImageButton btnExit;
        private Microsoft.Reporting.WinForms.ReportViewer productLabelViewer;
        private Microsoft.Reporting.WinForms.ReportViewer reedemReceiptViewer;
    }
}