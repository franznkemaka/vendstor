namespace Vendstor.UserControls.Dashboard.Reports
{
    partial class Dashboard
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
            this.comingSoon = new Vendstor.UserControls.ComingSoon();
            this.SuspendLayout();
            // 
            // comingSoon
            // 
            this.comingSoon.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.comingSoon.Location = new System.Drawing.Point(227, 131);
            this.comingSoon.Name = "comingSoon";
            this.comingSoon.Size = new System.Drawing.Size(674, 335);
            this.comingSoon.TabIndex = 0;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(246)))));
            this.Controls.Add(this.comingSoon);
            this.Name = "Dashboard";
            this.Size = new System.Drawing.Size(1128, 597);
            this.ResumeLayout(false);

        }

        #endregion

        private ComingSoon comingSoon;
    }
}
