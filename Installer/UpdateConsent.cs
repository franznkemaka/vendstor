using System;
using System.Drawing;
using System.Diagnostics;
using System.Windows.Forms;

namespace Installer
{
    public partial class UpdateConsent : Form
    {
        public UpdateConsent()
        {
            InitializeComponent();
            btnExit.Image = Util.ColorImage(btnExit.Image, Color.FromArgb(209, 212, 221));
            Util.SetIcon(this);
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                // Open InstallerUpdate Url
                Process.Start(Constants.UpdateUrl);
            }
            catch
            {
                this.Close();
            }
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void UpdateConsent_Load(object sender, EventArgs e)
        {

        }
    }
}
