namespace Vendstor.Models
{
    partial class UserInsightModel
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
            this.lblAmount = new System.Windows.Forms.Label();
            this.Seperator = new Bunifu.Framework.UI.BunifuSeparator();
            this.lblType = new System.Windows.Forms.Label();
            this.lblSalesCount = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblAmount
            // 
            this.lblAmount.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblAmount.AutoSize = true;
            this.lblAmount.BackColor = System.Drawing.Color.Transparent;
            this.lblAmount.Font = new System.Drawing.Font("Poppins", 20F);
            this.lblAmount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblAmount.Location = new System.Drawing.Point(170, 26);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(66, 48);
            this.lblAmount.TabIndex = 60;
            this.lblAmount.Text = "0 €";
            // 
            // Seperator
            // 
            this.Seperator.BackColor = System.Drawing.Color.Transparent;
            this.Seperator.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(246)))));
            this.Seperator.LineThickness = 1;
            this.Seperator.Location = new System.Drawing.Point(1, 74);
            this.Seperator.Name = "Seperator";
            this.Seperator.Size = new System.Drawing.Size(320, 10);
            this.Seperator.TabIndex = 57;
            this.Seperator.Transparency = 255;
            this.Seperator.Vertical = false;
            // 
            // lblType
            // 
            this.lblType.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblType.AutoSize = true;
            this.lblType.BackColor = System.Drawing.Color.Transparent;
            this.lblType.Font = new System.Drawing.Font("Poppins Light", 12F);
            this.lblType.ForeColor = System.Drawing.Color.DimGray;
            this.lblType.Location = new System.Drawing.Point(10, 9);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(65, 28);
            this.lblType.TabIndex = 58;
            this.lblType.Text = "Today ";
            // 
            // lblSalesCount
            // 
            this.lblSalesCount.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblSalesCount.AutoSize = true;
            this.lblSalesCount.BackColor = System.Drawing.Color.Transparent;
            this.lblSalesCount.Font = new System.Drawing.Font("Poppins Light", 12F);
            this.lblSalesCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(167)))), ((int)(((byte)(82)))));
            this.lblSalesCount.Location = new System.Drawing.Point(176, 5);
            this.lblSalesCount.Name = "lblSalesCount";
            this.lblSalesCount.Size = new System.Drawing.Size(68, 28);
            this.lblSalesCount.TabIndex = 59;
            this.lblSalesCount.Text = "0 Sales";
            // 
            // UserInsightModel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lblAmount);
            this.Controls.Add(this.Seperator);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.lblSalesCount);
            this.Name = "UserInsightModel";
            this.Size = new System.Drawing.Size(323, 88);
            this.Load += new System.EventHandler(this.OnLoad);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAmount;
        private Bunifu.Framework.UI.BunifuSeparator Seperator;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblSalesCount;
    }
}
