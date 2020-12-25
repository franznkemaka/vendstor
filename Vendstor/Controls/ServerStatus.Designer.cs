namespace Vendstor.Controls
{
    partial class ServerStatus
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
            this.imgServerStatus = new System.Windows.Forms.PictureBox();
            this.timSignal = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.imgServerStatus)).BeginInit();
            this.SuspendLayout();
            // 
            // imgServerStatus
            // 
            this.imgServerStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.imgServerStatus.Image = global::Vendstor.Properties.Resources.led_green;
            this.imgServerStatus.Location = new System.Drawing.Point(0, 3);
            this.imgServerStatus.Name = "imgServerStatus";
            this.imgServerStatus.Size = new System.Drawing.Size(70, 27);
            this.imgServerStatus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgServerStatus.TabIndex = 96;
            this.imgServerStatus.TabStop = false;
            this.imgServerStatus.Click += new System.EventHandler(this.OnStateClick);
            // 
            // timSignal
            // 
            this.timSignal.Interval = 60000;
            this.timSignal.Tick += new System.EventHandler(this.TimSignal_Tick);
            // 
            // ServerStatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.imgServerStatus);
            this.Name = "ServerStatus";
            this.Size = new System.Drawing.Size(70, 31);
            this.Load += new System.EventHandler(this.OnLoad);
            ((System.ComponentModel.ISupportInitialize)(this.imgServerStatus)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox imgServerStatus;
        private System.Windows.Forms.Timer timSignal;
    }
}
