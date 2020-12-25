using System;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Imaging;

//Vendstor
using Vendstor.Modals;

using Vendstor.Backend;
using Vendstor.Backend.Data;
using Vendstor.Backend.Utils;
using Vendstor.Backend.Constants;
using Vendstor.Backend.Database.Queries;
using Vendstor.Backend.Libraries;

namespace Vendstor.Forms.Products
{
    public partial class ProductDetails : Form
    {
        #region Variables

        public Backend.Objects.Product Product { get; set; }
        Backend.Objects.User User = new Backend.Objects.User();
        Backend.Objects.Store Store = new Backend.Objects.Store();

        public Enums.Task Task { get; set; }
        public string RootForm { get; set; }

        Enums.ActionDialog ActionDialog { get; set; }

        Color SoftColor;
        Color ColorGray = Color.FromArgb(209, 212, 221);

        #endregion

        #region Constructors

        public ProductDetails()
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

        public Enums.ActionDialog ShowWithResult()
        {
            this.ShowDialog();
            return ActionDialog;
        }

        public FormResponse ShowWithResponse()
        {
            this.ShowDialog();
            return new FormResponse
            {
                ActionDialog = ActionDialog,
                Data = Product
            };
        }

        private void ImgbtnExit_Click(object sender, EventArgs e)
        {
            //ActionDialog = Enums.ActionDialog.Closed;
            this.Close();
        }


        private void BtnEditProduct_Click(object sender, EventArgs e)
        {
            Blur blur = new Blur(this, UIConstants.FormBlurOpacity);
            blur.Show();

            Product product = new Product
            {
                ProductObject = Product,
                Task = Enums.Task.Update,
                TopMost = true
            };

            // Update If Updated
            var formResponse = product.ShowWithResponse();
            if (formResponse.ActionDialog == Enums.ActionDialog.Updated)
            {
                ActionDialog = Enums.ActionDialog.Updated;
                Product = (Backend.Objects.Product)formResponse.Data;

                //Force Update
                this.Initialize();
            }
            else if (formResponse.ActionDialog == Enums.ActionDialog.Deleted)
            {
                // Close -> Nothing to show
                ActionDialog = Enums.ActionDialog.Deleted;
                this.Close();
            }

            blur.Close();
        }

        private void BtnPrintLabel_Click(object sender, EventArgs e)
        {
            Blur blur = new Blur(this, UIConstants.MinBlurOpacity);
            blur.Show();

            ProductLabel productLabel = new ProductLabel
            {
                TopMost = true,
                Product = Product,
                User = User,
                Store = Store,
            };
            productLabel.ShowDialog();

            blur.Close();
        }

        private void BtnDuplicate_Click(object sender, EventArgs e)
        {
            // PR : Duplicate Product
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            Blur blur = new Blur(this, UIConstants.MinBlurOpacity);
            blur.Show();

            MessageDialog messageDialog = new MessageDialog
            {
                DialogButtonsIndex = MessageDialog.DialogButtons.Two,
                DialogIconIndex = MessageDialog.DialogIcon.Sorry,
                SecondBtnText = "No",
                ThirdBtnText = "Yes",
                ThirdBtnColor = Color.Tomato,
                Title = "Are you sure ?",
                Message = $"Are you sure you want to permanently delete { Product.Name }, this product will be deleted immediately. You can't undo this action.",
                TopMost = true,
            };

            var dialogResult = messageDialog.ShowWithEvent();
            if (dialogResult == MessageDialog.OnClickEvent.ThirdButton)
            {
                ActionDialog = Enums.ActionDialog.Deleted;
                //Delete
                DeleteProduct();
            }
            blur.Close();
        }

        private void ImgProductBarcode_Click(object sender, EventArgs e)
        {
            // Save locally
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Images|*.png;*.bmp;*.jpg";
            ImageFormat format = ImageFormat.Png;
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                var extension = System.IO.Path.GetExtension(saveFileDialog.FileName);
                switch (extension)
                {
                    case ".jpg":
                        format = ImageFormat.Jpeg;
                        break;
                    case ".bmp":
                        format = ImageFormat.Bmp;
                        break;
                    case ".png":
                        format = ImageFormat.Png;
                        break;
                }
                imgProductBarcode.Image.Save(saveFileDialog.FileName, format);
            }
        }
        #endregion

        #region  Methods

        void Initialize()
        {
            User = Util.Data.GetUser();
            Store = Util.Data.GetStore();

            if (Task == Enums.Task.ReadOnly)
                btnDelete.Visible = btnEditProduct.Visible = btnPrintLabel.Visible = false;

            //Get
            GetProduct();

            Translate();
        }

        void GetProduct()
        {
            if (QueryController.Products.Product.IsValid(Product))
            {
                lblTitle.Text = string.Format("{0}, {1} | {2}", Product.Name, Product.Type.Name, Product.RetailPrice);
                lblProductDescription.Text = Product.Description;
                lblProductId.Text = Product.Id;
                lblProductBarcode.Text = Product.Barcode;
                lblProductType.Text = Product.Type.Name;
                lblProductTax.Text = Product.Tax.Name;
                lblProductSupplier.Text = Product.Supplier.Name;
                lblProductBrand.Text = Product.Brand.Name;
                lblProductSupplyPrice.Text = string.Format("{0} {1}", Store.CurrencySign, Product.SupplyPrice.ToString());
                lblProductMarkupPtg.Text = string.Format("% {0}", Product.SupplyPrice.ToString());
                lblProductRetailPrice.Text = string.Format("{0} {1}", Store.CurrencySign, Product.RetailPrice.ToString());

                imgProductImage.Image = Product.Image;
                cardProductImage.color = Product.Color;

                //Render Barcode
                RenderBarcode(Product.Barcode);
            }
            else
            {
                Alert.Show("Unknown Product", $"The Product you're trying to Get doesn't exist ", Alert.AlertType.Warning);
            }
        }

        void DeleteProduct()
        {
            if (QueryController.Products.Product.IsValid(Product))
            {
                // Delete Product Image
                DeleteProductImage();

                var response = QueryController.Products.Product.Delete(Product);
                if (response.StatusCode == 204)
                {
                    ActionDialog = Enums.ActionDialog.Deleted;
                    this.Close();

                    Alert.Show("Product Deleted", $"{ Product.Name } was successfully deleted", Alert.AlertType.Success);
                }
                else
                    Alert.Show("Unable to delete Product", $"An Error occured while trying to delete { Product.Name } ",
                         Alert.AlertType.Error);
            }
            else
                Alert.Show("Unknown Product", $"The Supplier you're trying to Delete doesn't exist ", Alert.AlertType.Warning);
        }

        void DeleteProductImage()
        {
            if (Validation.IsTokenValid(Product.ImageBlobId, 30))
            {
                var file = (Backend.Objects.File)QueryController.Blob.Get(Product.ImageBlobId).Data;
                QueryController.Blob.Delete(file);
            }
            imgProductImage.Image = ImageUtil.DrawLetter(Product.Name, backgroundColor: Product.Color);
        }

        void RenderBarcode(string token)
        {
            if (string.IsNullOrEmpty(token))
                return;
            imgProductBarcode.Image = CodeGenerator.GenerateBarcode(token);
        }

        void InitializeUI()
        {
            SoftColor = UserInterface.SoftColor;
            Color HoverColor = Color.FromArgb(200, SoftColor);
            UserInterface.SetFlatButtonColor(btnDuplicate, SoftColor);
            UserInterface.SetFlatButtonColor(btnEditProduct, SoftColor);
            UserInterface.SetFlatButtonColor(btnPrintLabel, SoftColor);
            ImageUtil.ColorImageButton(imgbtnExit, ColorGray);

            //Elipse
            new Bunifu.Framework.UI.BunifuElipse { ElipseRadius = 7 }.TargetControl = pnlToolBox;
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
