using System;
using System.Drawing;
using System.Windows.Forms;

//Vendstor
using Vendstor.Backend;
using Vendstor.Backend.Utils;
using Vendstor.Backend.Database.Queries;

namespace Vendstor.UserControls.Dashboard.Setup
{
    public partial class PaymentTypes : UserControl
    {
        #region Variables

        Backend.Objects.Store Store = new Backend.Objects.Store();
        Backend.Objects.User User = new Backend.Objects.User();

        Color SoftColor;

        #endregion

        #region Constructors

        public PaymentTypes()
        {
            InitializeComponent();

            InitializeUI();
        }

        #endregion

        #region OnLoad

        private void OnLoad(object sender, EventArgs e)
        {
            Initialize();
        }

        #endregion

        #region Event Handler


        #endregion

        #region Control - Event Handler

        private void PaymentTypeValueChanged(object sender, EventArgs e)
        {
            //
        }
        private void PaymentTypeClick(object sender, EventArgs e)
        {
            if (Util.Func.IsUserAllowed(User, Util.PermissionAlertType.Message))
            {
                UpdatePaymentTypes();
            }
        }

        private void ImgbtnForceUpdate_Click(object sender, EventArgs e)
        {
            //Force Update
            Initialize();
        }

        #endregion

        #region  Methods

        public void InitializeUI()
        {
            SoftColor = UserInterface.SoftColor;
            imgbtnForceUpdate.Image = ImageUtil.ColorImage(imgbtnForceUpdate.Image, Color.DimGray);
        }

        void Initialize()
        {
            Store = Util.Data.GetStore();
            User = Util.Data.GetUser();
            GetPaymentTypes();
            Translate();
        }

        void GetPaymentTypes()
        {
            switchPaymentCash.Value = true;
            switchPaymentCreditCard.Value = Store.PaymentTypes.CreditCard;
            switchPaymentStoreCredit.Value = Store.PaymentTypes.StoreCredit;
        }

        void UpdatePaymentTypes()
        {            
            Store.PaymentTypes.CreditCard = switchPaymentCreditCard.Value;
            Store.PaymentTypes.StoreCredit = switchPaymentStoreCredit.Value;
            QueryController.PaymentType.Update(Store);
            Util.Data.SynchronizeStore(Store.Id);
        }

        #endregion

        #region Translate

        void Translate()
        {
            if (Translation.IsPossible())
            {
                //Translate Strings 
                foreach (Control c in cardCash.Controls)
                    if (c is Label)
                        c.Text = Translation.Translate(c.Text);

                foreach (Control c in cardCreditCard.Controls)
                    if (c is Label)
                        c.Text = Translation.Translate(c.Text);

                foreach (Control c in cardStoreCredit.Controls)
                    if (c is Label)
                        c.Text = Translation.Translate(c.Text);

                foreach (Control c in cardPayPal.Controls)
                    if (c is Label)
                        c.Text = Translation.Translate(c.Text);

                text_DescriptionOnAccount.Text = Translation.Translate(text_DescriptionOnAccount.Text);
                text_Payment5.Text = Translation.Translate(text_Payment5.Text);
                text_Payment6.Text = Translation.Translate(text_Payment6.Text);

            }

        }

        #endregion

        #region OnClose


        #endregion

      
    }
}
