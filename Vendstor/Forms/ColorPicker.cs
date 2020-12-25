using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// Vendstor
using Vendstor.Backend.Utils;

namespace Vendstor.Forms
{
    public partial class ColorPicker : Form
    {
        #region Variables

        Color SoftColor;
        public Color ColorValue = Color.Transparent;

        #endregion

        #region Constructors

        public ColorPicker()
        {
            InitializeComponent();

            InitializeUI();
            TopMost = true;
            Util.Methods.SetIcon(this);
        }

        #endregion

        #region OnLoad

        private void OnLoad(object sender, EventArgs e)
        {
            Initialize();
        }

        #endregion


        #region Event Handler

        public Color ShowWithResult()
        {
            this.ShowDialog();
            return ColorValue;
        }

        private void OnClick(object sender, EventArgs e)
        {
            // SetColor
            SetColor(GetColor());
            this.Close();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void OnTrackValueChange(object sender, EventArgs e)
        {

        }

        #endregion

        #region Methods

        void Initialize()
        {
            Color color = ColorValue == Color.Transparent ? SoftColor : ColorValue;

            // SetColor
            SetColor(color);
            SetTrackBarColor(color);
        }

        Color GetColor()
        {
            var r = trackRed.Value;
            var g = trackGreen.Value;
            var b = trackBlue.Value;
            return Color.FromArgb(r, g, b);
        }

        void SetTrackBarColor(Color color)
        {
            trackRed.Value = color.R;
            trackGreen.Value = color.G;
            trackBlue.Value = color.B;
        }

        void SetColor(Color color)
        {
            cardColor.color = cardColor.BackColor = color;
            ColorValue = color;
            lblBlueValue.Text = color.B.ToString();
            lblGreenValue.Text = color.G.ToString();
            lblRedValue.Text = color.R.ToString();
        }

        void InitializeUI()
        {
            SoftColor = UserInterface.SoftColor;
            trackRed.IndicatorColor = trackBlue.IndicatorColor = trackGreen.IndicatorColor = SoftColor;
            ImageUtil.ColorImageButton(btnExit, UserInterface.ColorGray);
        }

        #endregion

        #region OnClose

        #endregion

        private void TimSetColor_Tick(object sender, EventArgs e)
        {
            // SetColor
            SetColor(GetColor());
        }
    }
}
