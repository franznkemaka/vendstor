using System;
using System.Drawing;
using System.Windows.Forms;
using Bunifu.Framework.UI;

//Vendstor
using Vendstor.Backend;
using Vendstor.Backend.Utils;
using Vendstor.Backend.Database.Queries;
using Vendstor.Backend.Libraries;

namespace Vendstor.Forms.PointOfSale
{
    public partial class Discount : Form
    {
        #region Variables

        public Backend.Objects.User User { get; set; }
        public Backend.Objects.Store Store { get; set; }

        public decimal DiscountAmount { get; set; }
        public decimal DiscountPercentage { get; set; }
        public string DiscountName { get; set; }
        public string Currency { get { return Store.CurrencySign;  } }

        public bool IsCashDiscount = true;

        Color SoftColor;
        Color ColorGray = Color.FromArgb(209, 212, 221);

        #endregion

        #region Constructors

        public Discount()
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

        private void Control_Click(object sender, EventArgs e)
        {

        }

        private void TxtDiscountName_OnValueChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtDiscountName.Text))
                DiscountName = txtDiscountName.Text;
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            bool isValid = decimal.TryParse(txtDiscountValue.Text, out decimal discountValue);

            if (txtDiscountValue.Text.Length > 0 && isValid)
            {
                if (IsCashDiscount)
                    DiscountAmount = discountValue;
                else
                    DiscountPercentage = discountValue;
                this.Close();
            }
        }

        private void ImgbtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion

        #region  Methods

        void Initialize()
        {
            ToggleDiscountType();
        }

        private void ImgbtnPtgDiscountType_Click(object sender, EventArgs e)
        {
            IsCashDiscount = false;
            ToggleDiscountType();
        }

        private void ImgbtnCashDiscountType_Click(object sender, EventArgs e)
        {
            IsCashDiscount = true;
            ToggleDiscountType();
        }

        void ToggleDiscountType()
        {
            BunifuElipse DiscountTypeImgElipse = new BunifuElipse { ElipseRadius = 5 };
            Image ColoredImgCashDiscountType = ImageUtil.ColorImage(imgbtnCashDiscountType.Image, SoftColor);
            Image ColoredImgPtgDiscountType = ImageUtil.ColorImage(imgbtnPtgDiscountType.Image, SoftColor);
            Image ImgCashDiscountType = ImageUtil.ColorImage(imgbtnCashDiscountType.Image, Color.White);
            Image ImgPtgDiscountType = ImageUtil.ColorImage(imgbtnPtgDiscountType.Image, Color.White);

            txtDiscountValue.Text = "";

            if (IsCashDiscount)
            {
                //Cash
                lblDiscountType.Text = StringAmount;
                txtDiscountValue.HintText = (DiscountAmount == 0) ? "00,00" : DiscountAmount.ToString();
                lblUnit.Text = Currency;
                txtDiscountValue.Text = DiscountAmount.ToString();

                // Change Both Control Color, Image Oppositely 
                imgbtnCashDiscountType.BackColor = SoftColor;
                imgbtnCashDiscountType.Image = ImgCashDiscountType;

                imgbtnPtgDiscountType.BackColor = Color.White;
                imgbtnPtgDiscountType.Image = ColoredImgPtgDiscountType;

                DiscountTypeImgElipse.TargetControl = imgbtnCashDiscountType;
            }
            else
            {
                // Percentage
                lblDiscountType.Text = stringPercentage;
                txtDiscountValue.HintText = DiscountPercentage.ToString();
                txtDiscountValue.Text = DiscountPercentage.ToString();
                lblUnit.Text = "%";

                //Refresh UI  : Change Both Control Color, Image Oppositely    
                imgbtnCashDiscountType.BackColor = Color.White;
                imgbtnCashDiscountType.Image = ColoredImgCashDiscountType;

                imgbtnPtgDiscountType.BackColor = SoftColor;
                imgbtnPtgDiscountType.Image = ImgPtgDiscountType;

                DiscountTypeImgElipse.TargetControl = imgbtnPtgDiscountType;
            }
            txtDiscountName.Text = DiscountName;
        }

        void InitializeUI()
        {
            SoftColor = UserInterface.SoftColor;
            ImageUtil.ColorImageButton(imgbtnExit, Color.DarkGray);
            UserInterface.SetFlatButtonColor(btnAdd, SoftColor);
            txtDiscountValue.LineFocusedColor = txtDiscountValue.LineMouseHoverColor = txtDiscountName.LineFocusedColor
                = txtDiscountName.LineMouseHoverColor = SoftColor;
        }


        #endregion

        #region Translate

        string StringAmount = "Amount";
        string stringPercentage = "Percentage";

        void Translate()
        {
            if (Translation.IsPossible())
            {
                Translation.TranslateControl(text_Text);
                Translation.TranslateControl(text_disc_type);
                Translation.TranslateControl(text_Name);
                Translation.TranslateControl(btnAdd);

                StringAmount = Translation.Translate(StringAmount);
                stringPercentage = Translation.Translate(stringPercentage);
            }
        }

        #endregion

        #region OnClose

        #endregion

    }
}
