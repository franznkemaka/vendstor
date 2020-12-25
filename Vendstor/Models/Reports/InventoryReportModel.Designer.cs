namespace Vendstor.Models.Reports
{
    partial class InventoryReportModel
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
            this.GridTitle_Separator3 = new Bunifu.Framework.UI.BunifuSeparator();
            this.GridTitle_Separator2 = new Bunifu.Framework.UI.BunifuSeparator();
            this.GridTitle_Separator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.lblItemValue = new System.Windows.Forms.Label();
            this.lblCurrentStock = new System.Windows.Forms.Label();
            this.lblStockValue = new System.Windows.Forms.Label();
            this.lblProductName = new System.Windows.Forms.Label();
            this.lblProductBarcode = new System.Windows.Forms.Label();
            this.GridSeperator_Collapse = new Bunifu.Framework.UI.BunifuSeparator();
            this.SuspendLayout();
            // 
            // GridTitle_Separator3
            // 
            this.GridTitle_Separator3.BackColor = System.Drawing.Color.Transparent;
            this.GridTitle_Separator3.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.GridTitle_Separator3.LineThickness = 1;
            this.GridTitle_Separator3.Location = new System.Drawing.Point(608, 11);
            this.GridTitle_Separator3.Margin = new System.Windows.Forms.Padding(8);
            this.GridTitle_Separator3.Name = "GridTitle_Separator3";
            this.GridTitle_Separator3.Size = new System.Drawing.Size(8, 28);
            this.GridTitle_Separator3.TabIndex = 184;
            this.GridTitle_Separator3.Transparency = 255;
            this.GridTitle_Separator3.Vertical = true;
            this.GridTitle_Separator3.Visible = false;
            // 
            // GridTitle_Separator2
            // 
            this.GridTitle_Separator2.BackColor = System.Drawing.Color.Transparent;
            this.GridTitle_Separator2.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.GridTitle_Separator2.LineThickness = 1;
            this.GridTitle_Separator2.Location = new System.Drawing.Point(472, 14);
            this.GridTitle_Separator2.Margin = new System.Windows.Forms.Padding(8);
            this.GridTitle_Separator2.Name = "GridTitle_Separator2";
            this.GridTitle_Separator2.Size = new System.Drawing.Size(8, 28);
            this.GridTitle_Separator2.TabIndex = 183;
            this.GridTitle_Separator2.Transparency = 255;
            this.GridTitle_Separator2.Vertical = true;
            this.GridTitle_Separator2.Visible = false;
            // 
            // GridTitle_Separator1
            // 
            this.GridTitle_Separator1.BackColor = System.Drawing.Color.Transparent;
            this.GridTitle_Separator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.GridTitle_Separator1.LineThickness = 1;
            this.GridTitle_Separator1.Location = new System.Drawing.Point(312, 14);
            this.GridTitle_Separator1.Margin = new System.Windows.Forms.Padding(7);
            this.GridTitle_Separator1.Name = "GridTitle_Separator1";
            this.GridTitle_Separator1.Size = new System.Drawing.Size(8, 28);
            this.GridTitle_Separator1.TabIndex = 182;
            this.GridTitle_Separator1.Transparency = 255;
            this.GridTitle_Separator1.Vertical = true;
            this.GridTitle_Separator1.Visible = false;
            // 
            // lblItemValue
            // 
            this.lblItemValue.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblItemValue.AutoSize = true;
            this.lblItemValue.Font = new System.Drawing.Font("Poppins", 11F);
            this.lblItemValue.Location = new System.Drawing.Point(620, 10);
            this.lblItemValue.Name = "lblItemValue";
            this.lblItemValue.Size = new System.Drawing.Size(115, 26);
            this.lblItemValue.TabIndex = 181;
            this.lblItemValue.Text = "€ _ItemValue";
            // 
            // lblCurrentStock
            // 
            this.lblCurrentStock.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblCurrentStock.AutoSize = true;
            this.lblCurrentStock.Font = new System.Drawing.Font("Poppins", 11F);
            this.lblCurrentStock.Location = new System.Drawing.Point(330, 12);
            this.lblCurrentStock.Name = "lblCurrentStock";
            this.lblCurrentStock.Size = new System.Drawing.Size(122, 26);
            this.lblCurrentStock.TabIndex = 180;
            this.lblCurrentStock.Text = "_CurrentStock";
            // 
            // lblStockValue
            // 
            this.lblStockValue.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblStockValue.AutoSize = true;
            this.lblStockValue.Font = new System.Drawing.Font("Poppins", 11F);
            this.lblStockValue.Location = new System.Drawing.Point(489, 10);
            this.lblStockValue.Name = "lblStockValue";
            this.lblStockValue.Size = new System.Drawing.Size(123, 26);
            this.lblStockValue.TabIndex = 179;
            this.lblStockValue.Text = "€ _StockValue";
            // 
            // lblProductName
            // 
            this.lblProductName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblProductName.AutoSize = true;
            this.lblProductName.Font = new System.Drawing.Font("Poppins Light", 11F);
            this.lblProductName.Location = new System.Drawing.Point(32, 3);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(122, 26);
            this.lblProductName.TabIndex = 178;
            this.lblProductName.Text = "_ProductName";
            // 
            // lblProductBarcode
            // 
            this.lblProductBarcode.AutoSize = true;
            this.lblProductBarcode.Font = new System.Drawing.Font("Poppins Light", 9F);
            this.lblProductBarcode.ForeColor = System.Drawing.Color.DarkGray;
            this.lblProductBarcode.Location = new System.Drawing.Point(33, 28);
            this.lblProductBarcode.Name = "lblProductBarcode";
            this.lblProductBarcode.Size = new System.Drawing.Size(67, 21);
            this.lblProductBarcode.TabIndex = 185;
            this.lblProductBarcode.Text = "_Barcode";
            // 
            // GridSeperator_Collapse
            // 
            this.GridSeperator_Collapse.BackColor = System.Drawing.Color.Transparent;
            this.GridSeperator_Collapse.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.GridSeperator_Collapse.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(246)))));
            this.GridSeperator_Collapse.LineThickness = 1;
            this.GridSeperator_Collapse.Location = new System.Drawing.Point(0, 48);
            this.GridSeperator_Collapse.Margin = new System.Windows.Forms.Padding(4);
            this.GridSeperator_Collapse.Name = "GridSeperator_Collapse";
            this.GridSeperator_Collapse.Size = new System.Drawing.Size(760, 4);
            this.GridSeperator_Collapse.TabIndex = 186;
            this.GridSeperator_Collapse.Transparency = 255;
            this.GridSeperator_Collapse.Vertical = false;
            // 
            // InventoryReportModel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.GridSeperator_Collapse);
            this.Controls.Add(this.lblProductBarcode);
            this.Controls.Add(this.GridTitle_Separator3);
            this.Controls.Add(this.GridTitle_Separator2);
            this.Controls.Add(this.GridTitle_Separator1);
            this.Controls.Add(this.lblItemValue);
            this.Controls.Add(this.lblCurrentStock);
            this.Controls.Add(this.lblStockValue);
            this.Controls.Add(this.lblProductName);
            this.Name = "InventoryReportModel";
            this.Size = new System.Drawing.Size(760, 52);
            this.Load += new System.EventHandler(this.OnLoad);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuSeparator GridTitle_Separator3;
        private Bunifu.Framework.UI.BunifuSeparator GridTitle_Separator2;
        private Bunifu.Framework.UI.BunifuSeparator GridTitle_Separator1;
        private System.Windows.Forms.Label lblItemValue;
        private System.Windows.Forms.Label lblCurrentStock;
        private System.Windows.Forms.Label lblStockValue;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.Label lblProductBarcode;
        private Bunifu.Framework.UI.BunifuSeparator GridSeperator_Collapse;
    }
}
