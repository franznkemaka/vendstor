using System;
using System.Drawing;
using System.Windows.Forms;

//Vendstor
using Vendstor.Backend;
using Vendstor.Backend.Utils;

namespace Vendstor.Forms.PointOfSale
{
    public partial class Weight : Form
    {
        #region Variables

        public decimal Quantity { get; set; }

        Color SoftColor;
        Color ColorGray = Color.FromArgb(209, 212, 221);

        #endregion

        #region Constructors

        public Weight()
        {
            InitializeComponent();

            InitializeUI();
            Util.Methods.SetIcon(this);
        }

        #endregion

        #region OnLoad

        private void OnLoad(object sender, EventArgs e)
        {
            Initialize();
        }

        #endregion

        #region Control - Event Handler

        private void OnClick(object sender, EventArgs e)
        {
            SetQuantitiy(true);
        }
        
        private void TxtQuantity_OnValueChanged(object sender, EventArgs e)
        {
            SetQuantitiy();
            GetQuantitiy();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            SetQuantitiy(true);
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion

        #region  Methods

        void Initialize()
        {
            GetQuantitiy();

            Translate();
        }

        void GetQuantitiy()
        {
            lblQuantity.Text = StringUtil.ToString(Quantity) + " kg";
            Util.Methods.AlignToParent(lblQuantity, pnlWeightDisplay);
        }

        void SetQuantitiy(bool close = false)
        {
            // Update if not Empty or Null
            if (decimal.TryParse(txtQuantity.Text, out decimal quantity))
                Quantity = quantity;

            if (close)
                this.Close();
        }

        void InitializeUI()
        {
            SoftColor = UserInterface.SoftColor;
            UserInterface.SetFlatButtonColor(btnAdd, SoftColor);
        }

        #endregion

        #region Translate

        void Translate()
        {
            if (Translation.IsPossible())
            {
                Translation.TranslateControl(text_Weight);
            }
        }

        #endregion

        #region OnClose

        #endregion

    }
}
