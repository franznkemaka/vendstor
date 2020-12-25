using System;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Printing;
using System.Linq;
using System.Data;
using Microsoft.Reporting.WinForms;

using Vendstor.Modals;

using Vendstor.Backend;
using Vendstor.Backend.Utils;
using Vendstor.Backend.Database.Queries;

namespace Vendstor.Forms.PointOfSale
{
    public partial class PaymentVoid : Form
    {
        #region Variables
        public Backend.Objects.Sale Sale { get; set; }

        public EventHandler OnComplete;

        Color SoftColor;
        string Currency
        {
            get { return Sale.Store.CurrencySign; }
        }
        string ToPaymentMethodString
        {
            get
            {
                switch (Sale.PaymentMethod.ToLower())
                {
                    case "creditcard":
                        return "KREDIT KARTE";
                    case "storecredit":
                        return "EINKAUFSKREDIT";
                    default:
                        return "BAR";
                }

            }
        }
        #endregion

        #region Constructors

        public PaymentVoid()
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
            this.receiptPreview.RefreshReport();
        }

        #endregion

        #region Event Handler      

        protected override void OnKeyDown(KeyEventArgs e)
        {
            // Print
            if (e.KeyCode == Keys.P)
                PrintReceipt();

            // Done
            if (e.KeyCode == Keys.Escape)
                Complete();

            base.OnKeyDown(e);
        }

        #endregion

        #region Control - Event Handler

        private void BtnDone_Click(object sender, EventArgs e)
        {
            Complete();
        }

        private void BtnPrintReceipt_Click(object sender, EventArgs e)
        {
            PrintReceipt();
        }

        #endregion

        #region Methods   

        void Initialize()
        {
            Translate();

            lblPaymentStatus.Text = (Sale.Balance > 0)
                ? string.Format("{0} {1} {2}", StringGiveChangeOf, StringUtil.ToRoundedString(Sale.Balance), Currency)
                : StringPaymentReceived;

            RenderReceipt();
        }

        void PrintReceipt()
        {
            var printDialogResult = this.receiptPreview.PrintDialog();
            if (printDialogResult == DialogResult.OK)
                Complete();
        }

        void RenderReceipt()
        {
            var store = Sale.Store;
            var customer = Sale.Customer;
            bool hasNote = !string.IsNullOrEmpty(Sale.Note) && !string.IsNullOrWhiteSpace(Sale.Note);

            PageSettings pageSettings = new PageSettings();
            pageSettings.Margins.Top = 0;
            pageSettings.Margins.Bottom = 0;
            pageSettings.Margins.Left = 0;
            pageSettings.Margins.Right = 0;

            double defaultHeight = 198 ; //mm  + 2 - 2 mm
            defaultHeight -= !hasNote ? 5 : 0;
            
            foreach (Backend.Objects.SaleItemReceipt item in Sale.ItemsReceipt)
                // Add Item height depending on length each 11 char makes a line       
                defaultHeight += item.Name.Length / 11 * ((item.Name.Length > 11) ? 15 : 10);

            // height -> hundreth inch
            int height = (int)Math.Round(defaultHeight * (0.03937) * 100, 1);
            pageSettings.PaperSize = new PaperSize("Custom", 190, height);

            DataTable dtItems = DataUtil.ToDataTable(Sale.ItemsReceipt);
            DataSet dsItems = new DataSet();
            dsItems.Tables.Add(dtItems);
            ReportDataSource reportDataSource = new ReportDataSource
            {
                Name = "Item",
                Value = dsItems.Tables[0]
            };
            this.receiptPreview.LocalReport.DataSources.Add(reportDataSource);

            var postCodeCity = string.Format("{0} {1}", store.PostCode, store.City);
            var firstName = Sale.User.FirstName.FirstOrDefault().ToString().ToUpper();
            var userDisplayName = string.Format("{0}. {1}", firstName, Sale.User.LastName);
            var message = Properties.Settings.Default.ReceiptFooterMessage;

            string customerText = null;
            if (customer is object)
                customerText = !string.IsNullOrEmpty(customer.Id) ? $"KUNDE : {customer.FirstName } {customer.LastName } " : "";

            var note = (!string.IsNullOrEmpty(Sale.Note) && !string.IsNullOrWhiteSpace(Sale.Note)) ? $"MERKE : {Sale.Note } " : "";

            // GetTaxRates
            var taxA = $"A { GetTaxRate(taxCode: "A")} %";
            var taxB = $"B {GetTaxRate(taxCode: "B")} %";

            ReportParameter[] parameters = new ReportParameter[]
            {
                // Header
                new ReportParameter("StoreName", store.Name),
                new ReportParameter("Address",  store.Address),
                new ReportParameter("PostCodeCity", postCodeCity),
                new ReportParameter("PhoneNumber", store.PhoneNumber),

                new ReportParameter("SaleId", Sale.Id),
                new ReportParameter("DateTime", DateTime.Now.ToString()),
                                
                // Amounts
                new ReportParameter("TotalAmount", StringUtil.ToRoundedString(Sale.TotalPrice)),
                new ReportParameter("PaymentMethod",  ToPaymentMethodString),
                new ReportParameter("PaidAmount", StringUtil.ToRoundedString(Sale.Paid)),
                new ReportParameter("BalanceAmount", StringUtil.ToRoundedString(Sale.Balance)),
                new ReportParameter("ItemsCount", Sale.ItemsCount.ToString()),

                // Tax
                new ReportParameter("TaxID", store.TaxID),
                new ReportParameter("TaxA", taxA),
                new ReportParameter("TaxB", taxB),

                new ReportParameter("TaxARevenue", StringUtil.ToRoundedString(Sale.TaxARevenue)),
                new ReportParameter("TaxBRevenue", StringUtil.ToRoundedString(Sale.TaxBRevenue)),
                new ReportParameter("TaxAAmount", StringUtil.ToRoundedString(Sale.TaxAAmount)),
                new ReportParameter("TaxBAmount", StringUtil.ToRoundedString(Sale.TaxBAmount)),
                new ReportParameter("TaxANetto", StringUtil.ToRoundedString(Sale.TaxANetPrice)),
                new ReportParameter("TaxBNetto", StringUtil.ToRoundedString(Sale.TaxBNetPrice)),
                new ReportParameter("Revenue", StringUtil.ToRoundedString(Sale.TaxRevenue)),
                new ReportParameter("TaxAmount", StringUtil.ToRoundedString(Sale.TaxAmount)),
                new ReportParameter("NettoAmount",  StringUtil.ToRoundedString(Sale.TaxNetPrice)),

                
                // ...
                new ReportParameter("Currency", store.CurrencySign),
                new ReportParameter("UserDisplayName", userDisplayName),
                new ReportParameter("Message", message),
                new ReportParameter("Customer", customerText),
                new ReportParameter("Note", note),
            };
            try
            {
                this.receiptPreview.SetPageSettings(pageSettings);
                this.receiptPreview.LocalReport.SetParameters(parameters);
                this.receiptPreview.RefreshReport();
            }
            catch
            {
                Alert.Show("Error Printing", "A Fatal Error occured while refreshing Receipt", Alert.AlertType.Error, isMini: false);
            }
        }

        decimal GetTaxRate(string taxId = null, string taxCode = null)
        {
            Backend.Objects.Tax tax = Tax.GetTax(taxId, taxCode);
            return tax.Rate;
        }

        void Complete()
        {
            this.OnComplete(Sale, null);
            this.Close();
        }

        void InitializeUI()
        {
            SoftColor = UserInterface.SoftColor;
            btnPrintReceipt.Iconimage = ImageUtil.ColorImage(btnPrintReceipt.Iconimage, UserInterface.ColorGray);
            UserInterface.SetFlatButtonColor(btnDone, SoftColor);
            this.CenterToParent();
        }

        #endregion

        #region Translate

        string StringGiveChangeOf = "Give Change Of";
        string StringPaymentReceived = "Payment Received";

        void Translate()
        {
            if (Translation.IsPossible())
            {
                Translation.TranslateControl(text_SaleSummary);
                StringGiveChangeOf = Translation.Translate(StringGiveChangeOf);
                StringPaymentReceived = Translation.Translate(StringPaymentReceived);
            }
        }

        #endregion

        #region OnClose 

        #endregion


    }
}
