using System;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Printing;
using Microsoft.Reporting.WinForms;

//Vendstor
using Vendstor.Modals;

using Vendstor.Backend;
using Vendstor.Backend.Data;
using Vendstor.Backend.Utils;
using Vendstor.Backend.Database.Queries;

namespace Vendstor.Forms.Products
{
    public partial class ProductLabel : Form
    {
        #region Variables

        public Backend.Objects.Product Product { get; set; }
        public Backend.Objects.User User { get; set; }
        public Backend.Objects.Store Store { get; set; }

        Color SoftColor;
        Color ColorGray = Color.FromArgb(209, 212, 221);

        #endregion

        #region Constructors

        public ProductLabel()
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

        private void ImgbtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnGenerate_Click(object sender, EventArgs e)
        {
            RenderProductLabel();
        }

        #endregion

        #region  Methods

        void Initialize()
        {
            User = Util.Data.GetUser();
            Store = Util.Data.GetStore();

            GetProduct();
            Translate();
        }

        void GetProduct()
        {
            if (QueryController.Products.Product.IsValid(Product))
            {
                txtStoreName.Text = Store.Name;
                txtStoreAddress.Text = $"{Store.PostCode}  {Store.City}";

                if (Product.Supplier is object)
                {
                    txtSupplierName.Text = Product.Supplier.Name;
                    txtSupplierAddress.Text = $"{ Product.Supplier.PostCode }  { Product.Supplier.City}";
                }
                txtProductName.Text = Product.Name;
                txtProductBarcode.Text = Product.Barcode;
                txtProductPrice.Text = Product.Price.ToString();

                // Render Label
                RenderProductLabel();
            }

            else
                Util.MessageParser.Alert("Product", Util.AlertParserType.NotFound);
        }

        void RenderProductLabel()
        {
            PageSettings pageSettings = new PageSettings();
            pageSettings.Margins.Top = 0;
            pageSettings.Margins.Bottom = 0;
            pageSettings.Margins.Left = 0;
            pageSettings.Margins.Right = 0;

            if (!int.TryParse(txtX.Text, out int widthX))
                widthX = 326;
            if (!int.TryParse(txtY.Text, out int heightY))
                heightY = 120;

            pageSettings.PaperSize = new PaperSize("Custom", widthX, heightY);

            ReportParameter[] parameters = new ReportParameter[]
            {
                // Header
                new ReportParameter("StoreName", txtStoreName.Text),
                new ReportParameter("PostCodeCity", txtStoreAddress.Text),

                new ReportParameter("SupplierName", txtSupplierName.Text),
                new ReportParameter("SupplierPostCodeCity", txtSupplierAddress.Text),

                new ReportParameter("ProductName", txtProductName.Text),
                new ReportParameter("ProductBarcode", txtProductName.Text),
                new ReportParameter("Price", txtProductPrice.Text),
                new ReportParameter("Note", txtNote.Text),
            };
            
            try
            {
                this.labelViewer.SetPageSettings(pageSettings);
                this.labelViewer.LocalReport.SetParameters(parameters);
                this.labelViewer.RefreshReport();
            }
            catch
            {
                Alert.Show("Error Printing", "A Fatal Error occured while rendring Label", Alert.AlertType.Error, isMini: false);
            }
        }

        void InitializeUI()
        {
            SoftColor = UserInterface.SoftColor;
            Color HoverColor = Color.FromArgb(200, SoftColor);
            UserInterface.SetFlatButtonColor(btnGenerate, SoftColor);
            ImageUtil.ColorImageButton(imgbtnExit, ColorGray);
        }

        #endregion

        #region Translate 

        void Translate()
        {
            Translation.ForceUpdate();

            if (Translation.IsPossible())
            {
                //Translate Strings 
                foreach (Control control in this.Controls)
                    if (control is Label && control.Name.Contains("text_"))
                        Translation.TranslateControl(control);
            }
        }

        #endregion

        #region OnClose

        #endregion

      
    }
}
