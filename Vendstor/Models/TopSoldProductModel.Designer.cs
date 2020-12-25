namespace Vendstor.Models
{
    partial class TopSoldProductModel
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
            this.imgMedal = new Bunifu.Framework.UI.BunifuImageButton();
            this.lblProductName = new System.Windows.Forms.Label();
            this.lblComment = new System.Windows.Forms.Label();
            this.lblProductPrice = new System.Windows.Forms.Label();
            this.imgProductImage = new Bunifu.Framework.UI.BunifuImageButton();
            this.Seperator = new Bunifu.Framework.UI.BunifuSeparator();
            ((System.ComponentModel.ISupportInitialize)(this.imgMedal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgProductImage)).BeginInit();
            this.SuspendLayout();
            // 
            // imgMedal
            // 
            this.imgMedal.BackColor = System.Drawing.Color.Transparent;
            this.imgMedal.ImageActive = null;
            this.imgMedal.Location = new System.Drawing.Point(34, 21);
            this.imgMedal.Name = "imgMedal";
            this.imgMedal.Size = new System.Drawing.Size(45, 38);
            this.imgMedal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgMedal.TabIndex = 0;
            this.imgMedal.TabStop = false;
            this.imgMedal.Zoom = 10;
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblProductName.Location = new System.Drawing.Point(85, 14);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(72, 28);
            this.lblProductName.TabIndex = 2;
            this.lblProductName.Text = "_Name";
            // 
            // lblComment
            // 
            this.lblComment.AutoSize = true;
            this.lblComment.Font = new System.Drawing.Font("Poppins Light", 10F);
            this.lblComment.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(206)))), ((int)(((byte)(104)))));
            this.lblComment.Location = new System.Drawing.Point(136, 42);
            this.lblComment.Name = "lblComment";
            this.lblComment.Size = new System.Drawing.Size(92, 25);
            this.lblComment.TabIndex = 12;
            this.lblComment.Text = "_Comment";
            // 
            // lblProductPrice
            // 
            this.lblProductPrice.AutoSize = true;
            this.lblProductPrice.Font = new System.Drawing.Font("Poppins", 10F);
            this.lblProductPrice.ForeColor = System.Drawing.Color.DarkGray;
            this.lblProductPrice.Location = new System.Drawing.Point(85, 42);
            this.lblProductPrice.Name = "lblProductPrice";
            this.lblProductPrice.Size = new System.Drawing.Size(45, 25);
            this.lblProductPrice.TabIndex = 14;
            this.lblProductPrice.Text = "€ 00";
            // 
            // imgProductImage
            // 
            this.imgProductImage.BackColor = System.Drawing.Color.Transparent;
            this.imgProductImage.ErrorImage = null;
            this.imgProductImage.ImageActive = null;
            this.imgProductImage.Location = new System.Drawing.Point(364, 21);
            this.imgProductImage.Name = "imgProductImage";
            this.imgProductImage.Size = new System.Drawing.Size(45, 38);
            this.imgProductImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgProductImage.TabIndex = 15;
            this.imgProductImage.TabStop = false;
            this.imgProductImage.Zoom = 10;
            // 
            // Seperator
            // 
            this.Seperator.BackColor = System.Drawing.Color.Transparent;
            this.Seperator.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(246)))));
            this.Seperator.LineThickness = 1;
            this.Seperator.Location = new System.Drawing.Point(32, 65);
            this.Seperator.Name = "Seperator";
            this.Seperator.Size = new System.Drawing.Size(384, 10);
            this.Seperator.TabIndex = 16;
            this.Seperator.Transparency = 255;
            this.Seperator.Vertical = false;
            // 
            // TopSoldProductModel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.Seperator);
            this.Controls.Add(this.imgProductImage);
            this.Controls.Add(this.lblProductPrice);
            this.Controls.Add(this.lblComment);
            this.Controls.Add(this.lblProductName);
            this.Controls.Add(this.imgMedal);
            this.Name = "TopSoldProductModel";
            this.Size = new System.Drawing.Size(433, 80);
            this.Load += new System.EventHandler(this.OnLoad);
            ((System.ComponentModel.ISupportInitialize)(this.imgMedal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgProductImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuImageButton imgMedal;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.Label lblComment;
        private System.Windows.Forms.Label lblProductPrice;
        private Bunifu.Framework.UI.BunifuImageButton imgProductImage;
        private Bunifu.Framework.UI.BunifuSeparator Seperator;
    }
}
