using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Vendstor.Backend.Utils;
namespace Vendstor.Forms.PointOfSale
{
    public partial class Calendar : Form
    {
        public Calendar()
        {
            InitializeComponent();
            Util.Methods.SetIcon(this);
        }

        public void ShowWithBlur(Form frm, double blurOpacity)
        {
            Blur blur = new Blur(frm, blurOpacity);
            blur.Show();

            this.ShowDialog();

            blur.Close();
        }
        private void OnClick(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
