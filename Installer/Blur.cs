
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Installer
{
    /**
     * Source : StackOverFlow : [Hans Passant]
     * Edited By : Franz Nkemaka
     * **/

    class Blur : Form
    {
        public Blur(Form frmToCover, double opacity)
        {
                this.BackColor = Color.DarkGray;
                this.Opacity = opacity;      // Tweak as desired
                this.FormBorderStyle = FormBorderStyle.None;
                this.ControlBox = false;
                this.ShowInTaskbar = false;
                this.StartPosition = FormStartPosition.Manual;
                this.AutoScaleMode = AutoScaleMode.None;
                this.Location = frmToCover.PointToScreen(Point.Empty);
                this.ClientSize = frmToCover.ClientSize;

                frmToCover.LocationChanged += Cover_LocationChanged;
                frmToCover.ClientSizeChanged += Cover_ClientSizeChanged;

                this.Show(frmToCover);
                frmToCover.Focus();

                // Disable Aero transitions, the plexiglass gets too visible
                if (Environment.OSVersion.Version.Major >= 6)
                {
                    int value = 1;
                    DwmSetWindowAttribute(frmToCover.Handle, DWMWA_TRANSITIONS_FORCEDISABLED, ref value, 4);
                }            
        }
        private void Cover_LocationChanged(object sender, EventArgs e)
        {
            // Ensure the plexiglass follows the owner
            this.Location = this.Owner.PointToScreen(Point.Empty);
        }
        private void Cover_ClientSizeChanged(object sender, EventArgs e)
        {
            // Ensure the plexiglass keeps the owner covered
            this.ClientSize = this.Owner.ClientSize;
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            // Restore owner
            this.Owner.LocationChanged -= Cover_LocationChanged;
            this.Owner.ClientSizeChanged -= Cover_ClientSizeChanged;
            if (!this.Owner.IsDisposed && Environment.OSVersion.Version.Major >= 6)
            {
                int value = 1;
                DwmSetWindowAttribute(this.Owner.Handle, DWMWA_TRANSITIONS_FORCEDISABLED, ref value, 4);
            }
            base.OnFormClosing(e);
        }
        protected override void OnActivated(EventArgs e)
        {
            // Always keep the owner activated instead
            this.BeginInvoke(new Action(() => this.Owner.Activate()));
        }
        private const int DWMWA_TRANSITIONS_FORCEDISABLED = 3;
        [DllImport("dwmapi.dll")]
        private static extern int DwmSetWindowAttribute(IntPtr hWnd, int attr, ref int value, int attrLen);

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // Blur
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(246)))));
            this.ClientSize = new System.Drawing.Size(185, 104);
            this.Name = "Blur";
            this.Text = "Blur";
            this.Click += new System.EventHandler(this.Blur_Click);
            this.ResumeLayout(false);

        }
        private void Blur_Click(object sender, EventArgs e)
        {
           
        }
    }
}
