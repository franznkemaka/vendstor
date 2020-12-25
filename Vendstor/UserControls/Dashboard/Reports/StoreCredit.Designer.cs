namespace Vendstor.UserControls.Dashboard.Reports
{
    partial class StoreCredit
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
            this.comingSoon.Location = new System.Drawing.Point(313, 139);
            this.comingSoon.Name = "comingSoon";
            this.comingSoon.Size = new System.Drawing.Size(503, 318);
            this.comingSoon.TabIndex = 0;
            // 
            // StoreCredit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.comingSoon);
            this.Name = "StoreCredit";
            this.Size = new System.Drawing.Size(1128, 597);
            this.ResumeLayout(false);

        }

        #endregion

        private ComingSoon comingSoon;
    }
}
