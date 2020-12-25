using System;
using System.Drawing;
using System.Windows.Forms;

//Vendstor
using Vendstor.Modals;

using Vendstor.Backend;
using Vendstor.Backend.Utils;
using Vendstor.Backend.Database.Queries;

namespace Vendstor.Forms.PointOfSale
{
    public partial class Pay : Form
    {
        #region Variables

        public Backend.Objects.Sale Sale { get; set; }
        public decimal GivenAmount { get; set; }

        public EventHandler OnComplete;

        public string Currency
        {
            get { return Sale.Store.CurrencySign; }
        }
        public decimal RemainingAmount
        {
            get { return Sale.TotalPrice - GivenAmount; }
        }

        public enum PaymentMethod { Cash, CreditCard, StoreCredit };

        Color SoftColor;
        Color ColorGray = Color.FromArgb(209, 212, 221);

        #endregion

        #region Constructors

        public Pay()
        {
            InitializeComponent();

            InitializeUI();
            Util.Methods.SetIcon(this);

            this.TopMost = true;
        }

        #endregion

        #region OnLoad

        private void OnLoad(object sender, EventArgs e)
        {
            Initialize();
        }

        #endregion

        #region Event Handler

        // Emit Parent to reset
        public void OnPaymentCompled(object sender, EventArgs e)
        {
            this.OnComplete(sender, e);
        }
        
        #endregion

        #region Control - Event Handler

        private void BtnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CashPay_Click(object sender, EventArgs e)
        {
            PayProducts(PaymentMethod.Cash);
        }

        private void CreditCardPay_Click(object sender, EventArgs e)
        {
            PayProducts(PaymentMethod.CreditCard);
        }

        private void StoreCreditPay_Click(object sender, EventArgs e)
        {
            PayProducts(PaymentMethod.StoreCredit);
        }

        private void QuickValuePayment(object sender, EventArgs e)
        {
            // Set Amount
            var amount = decimal.Parse(((Control)sender).Tag.ToString());
            SetGivenAmount(amount);
        }

        private void TxtGivenAmount_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F4)
            {
                GivenAmount = 0;
                SetGivenAmount(0);
            }
            else if (e.KeyCode == Keys.Enter)
            {
                if (decimal.TryParse(txtGivenAmount.Text, out decimal amount))
                    SetGivenAmount(amount);
            }
        }

        #endregion

        #region  Methods

        void Initialize()
        {
            // Set Default 0
            SetGivenAmount(0);
            RenderPayButtons();
            GetCustomer();

            Translate();
        }

        void SetGivenAmount(decimal amount)
        {
            GivenAmount += amount;
            lblTotalPrice.Text = StringUtil.ToRoundedString(Sale.TotalPrice) + " " + Currency;
            lblGivenAmount.Text = StringUtil.ToRoundedString(GivenAmount) + " " + Currency;
            txtExchangeAmount.Text = StringUtil.ToRoundedString(RemainingAmount);
        }

        void RenderPayButtons()
        {
            btnCreditCardPay.Enabled = Sale.Store.PaymentTypes.CreditCard;
            if (Sale.Store.PaymentTypes.StoreCredit)
                btnStoreCreditPay.Enabled = !Sale.IsGuest;
            else
                btnStoreCreditPay.Enabled = false;
        }

        void GetCustomer()
        {
            customerPayModel.IsGuest = Sale.IsGuest;
            customerPayModel.Customer = Sale.Customer;
            customerPayModel.Currency = Currency;

            if (Sale.IsGuest)
                Sale.Customer = new Backend.Objects.Customer();

            // Update
            customerPayModel.Initialize();
        }

        void PayProducts(PaymentMethod paymentMethod)
        {
            switch (paymentMethod)
            {
                case PaymentMethod.Cash:

                    if (RemainingAmount <= 0)
                    {
                        Sale.PaymentMethod = "Cash";
                        Sale.Paid = GivenAmount;

                        // Remove Negative Sign
                        Sale.Balance = TrimNegativeSign(RemainingAmount);
                    }
                    else
                        return;

                    break;

                case PaymentMethod.CreditCard:
                    Sale.PaymentMethod = "CreditCard";
                    Sale.Paid = Sale.TotalPrice;
                    Sale.Balance = 0;
                    break;

                case PaymentMethod.StoreCredit:
                    Sale.PaymentMethod = "StoreCredit";
                    Sale.Paid = Sale.TotalPrice;
                    Sale.Balance = 0;

                    // Debit Customer If Ok Proceed
                    if (!DebitCustomer())
                        return;

                    break;
            }
            Purchase();
        }

        bool DebitCustomer()
        {
            var amount = Sale.Paid;
            var response = QueryController.Customers.Customer.Debit(Sale.Customer, amount);
            if (response.StatusCode == 204)
                return true;
            else
            {
                Alert.Show("Error", "An error occured Debitting amount from Customer, please Start-Over", Alert.AlertType.Error, isMini: false);
                return false;
            }
        }
        void Purchase()
        {
            Sale.TaxAAmount = 0;
            Sale.TaxBAmount = 0;
            var response = QueryController.Sale.Create(Sale);
            if (response.StatusCode == 201)
            {
                // Add Items to Sale  & Update Stock
                foreach (Backend.Objects.SaleItem item in Sale.Items)
                {
                    if (!item.IsDiscounted)
                        item.Discount = new Backend.Objects.Discount { Id = null };

                    var itemResponse = QueryController.Sale.AddItem(item, Sale);
                    if (itemResponse.StatusCode != 201)
                        Error();

                    item.Product.Stock -= item.Quantity;
                    var productStockResponse = QueryController.Products.Product.UpdateStock(item.Product);
                    if (productStockResponse.StatusCode != 204)
                        Error();

                    // PR: Use Dynamic Taxes  
                    if(item.Product.Tax is object)
                    {
                        if(item.Product.Tax.Code == "A")
                        {
                            Sale.TaxAAmount += item.TaxAmount;
                            // CHANGED : Not + item.TaxAmount since it's alread included
                            Sale.TaxARevenue += item.TotalPrice;
                        }
                        else if (item.Product.Tax.Code == "B")
                        {
                            Sale.TaxBAmount += item.TaxAmount;
                            // CHANGED : Not + item.TaxAmount since it's alread included
                            Sale.TaxBRevenue += item.TotalPrice ;
                        }
                    }
                }
                // Proceed To Confirmation & Print Receipt
                Proceed();
            }
            else
                Error();
        }

        void Error(bool close = true)
        {
            Alert.Show("Error", "An error occured processing Sale, please Start-Over", Alert.AlertType.Error, isMini: false);

            if (close)
                this.Close();
        }

        void Proceed()
        {
            Blur blur = new Blur(this, 0.30);
            blur.Show();

            this.TopMost = false;
            new PaymentVoid
            {
                Sale = Sale,
                OnComplete = OnPaymentCompled,
                TopMost = true,
            }.ShowDialog();

            blur.Close();
            this.Close();
        }

        decimal TrimNegativeSign(decimal dec)
        {
            return dec / -1;
        }

        void InitializeUI()
        {
            SoftColor = UserInterface.SoftColor;
            btnBack.Image = ImageUtil.ColorImage(btnBack.Image, ColorGray);
            UserInterface.SetFlatButtonColor(btnCashPay, SoftColor);
            UserInterface.SetFlatButtonColor(btnCreditCardPay, SoftColor);
            UserInterface.SetFlatButtonColor(btnStoreCreditPay, SoftColor);
            this.CenterToParent();
        }

        #endregion

        #region Translate

        void Translate()
        {
            if (Translation.IsPossible())
            {
                Translation.TranslateControl(btnCashPay);
                Translation.TranslateControl(btnCreditCardPay);
                Translation.TranslateControl(btnStoreCreditPay);
                Translation.TranslateControl(text_Exchange);
                Translation.TranslateControl(text_Pay);
                Translation.TranslateControl(text_Given);
            }
        }

        #endregion

        #region OnClose

        #endregion      
    }
}
