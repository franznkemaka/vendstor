namespace Vendstor.UserControls.Auth
{
    partial class CodeLogin
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
            this.hint_Guide = new System.Windows.Forms.Label();
            this.ElipBorder = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.imgHint = new Bunifu.Framework.UI.BunifuImageButton();
            ((System.ComponentModel.ISupportInitialize)(this.imgHint)).BeginInit();
            this.SuspendLayout();
            // 
            // hint_Guide
            // 
            this.hint_Guide.AutoSize = true;
            this.hint_Guide.BackColor = System.Drawing.Color.Transparent;
            this.hint_Guide.Cursor = System.Windows.Forms.Cursors.Hand;
            this.hint_Guide.Font = new System.Drawing.Font("Poppins ExtraLight", 12F);
            this.hint_Guide.ForeColor = System.Drawing.Color.White;
            this.hint_Guide.Location = new System.Drawing.Point(10, 67);
            this.hint_Guide.MaximumSize = new System.Drawing.Size(540, 0);
            this.hint_Guide.Name = "hint_Guide";
            this.hint_Guide.Size = new System.Drawing.Size(522, 84);
            this.hint_Guide.TabIndex = 47;
            this.hint_Guide.Text = "Use your In-App Scanner to Scan your Card Code !, Once done, the In-App Scanner w" +
    "ill automatically play \"beep\". Please wait for the computer to \"beep\", else your" +
    " card is wrong. ";
            this.hint_Guide.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ElipBorder
            // 
            this.ElipBorder.ElipseRadius = 5;
            this.ElipBorder.TargetControl = this;
            // 
            // imgHint
            // 
            this.imgHint.BackColor = System.Drawing.Color.Transparent;
            this.imgHint.Image = global::Vendstor.Properties.Resources.hint_filled_w;
            this.imgHint.ImageActive = null;
            this.imgHint.Location = new System.Drawing.Point(248, 13);
            this.imgHint.Name = "imgHint";
            this.imgHint.Size = new System.Drawing.Size(46, 29);
            this.imgHint.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgHint.TabIndex = 48;
            this.imgHint.TabStop = false;
            this.imgHint.Zoom = 10;
            // 
            // CodeLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(167)))), ((int)(((byte)(82)))));
            this.Controls.Add(this.imgHint);
            this.Controls.Add(this.hint_Guide);
            this.Name = "CodeLogin";
            this.Size = new System.Drawing.Size(543, 378);
            this.Load += new System.EventHandler(this.OnLoad);
            ((System.ComponentModel.ISupportInitialize)(this.imgHint)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label hint_Guide;
        private Bunifu.Framework.UI.BunifuImageButton imgHint;
        private Bunifu.Framework.UI.BunifuElipse ElipBorder;
    }
}
