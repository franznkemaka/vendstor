using System;
using System.Drawing;
using System.Windows.Forms;

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
    public partial class Product : Form
    {
        #region Variables

        public Backend.Objects.Product ProductObject = new Backend.Objects.Product();
        Backend.Objects.Product product = new Backend.Objects.Product();
        Backend.Objects.User user = new Backend.Objects.User();
        Backend.Objects.Store store = new Backend.Objects.Store();

        public EventHandler OnCreate;
        public EventHandler OnDelete;
        public Enums.ActionDialog ActionDialog { get; set; }
        public Enums.Task Task { get; set; }

        private Image BarcodeImage { get; set; }
        enum PanelIndex { First, Second }
        private string LocalImagePath = null;
        private bool IsDropDownUpdated = false;

        Size ControlDefaultSize = new Size(888, 550);

        Point ActiveField = new Point(12, 12);
        Point InActiveField = new Point(12, 556);

        Color SoftColor;
        Color ColorGray = Color.FromArgb(209, 212, 221);

        string Currency
        {
            get { return store.Currency; }
        }

        #endregion

        #region Constructors

        public Product()
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
                Data = product,
            };
        }


        private void BtnScanCode_Click(object sender, EventArgs e)
        {
            Blur blur = new Blur(this, UIConstants.ThirdFormBlurOpacity);
            blur.Show();

            var response = new Scanner { TopMost = true }.ShowWithResponse();
            var scanToken = (Backend.Objects.ScanToken)response.Data;
            if (scanToken is object)
                txtCustomBarcode.Text = scanToken.Token.ToString();

            blur.Close();
        }

        private void BtnAction_Click(object sender, EventArgs e)
        {
            if (!IsInputValid())
                return;

            GetDropDownValues();

            if (Task == Enums.Task.Update || Task == Enums.Task.Get)
            {
                ActionDialog = Enums.ActionDialog.Updated;
                UpdateProduct();
            }
            else if (Task == Enums.Task.Create)
            {
                ActionDialog = Enums.ActionDialog.Created;
                CreateProduct();
            }

            if (ActionDialog != Enums.ActionDialog.Error)
                this.Close();
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
                Message = $"Are you sure you want to permanently delete { product.Name }, this product will be deleted immediately with all its sales. You can't undo this action.",
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


        private void BtnSelectImage_Click(object sender, EventArgs e)
        {
            //Open File Dialog   
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                //Image Filters  
                Filter = "Vendstor Image Files (*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                //Display Image in ImageBox
                imgProductImage.Image = new Bitmap(openFileDialog.FileName);
                LocalImagePath = openFileDialog.FileName;
            }
        }

        private void BtnDeleteImage_Click(object sender, EventArgs e)
        {
            DeleteProductImage();

            //Reset LocalImagePath
            LocalImagePath = null;
        }

        void GetDropDownValues()
        {
            if (IsDropDownUpdated)
            {
                product.Supplier.Id = ProductSupplier.GetIdByName(dpdSupplier.selectedValue);
                product.Brand.Id = ProductBrand.GetIdByName(dpdProductBrand.selectedValue);
                product.Type.Id = ProductType.GetIdByName(dpdProductType.selectedValue);
                product.Tax.Id = Tax.GetIdByName(dpdTax.selectedValue);
            }
        }

        private void DropDowns_onItemSelected(object sender, EventArgs e)
        {
            IsDropDownUpdated = true;
        }

        private void ImgProductBarcode_Click(object sender, EventArgs e)
        {
            // Update Barocode
            RenderBarcode(txtCustomBarcode.Text);
        }
        private void TxtCustomBarcode_OnValueChanged(object sender, EventArgs e)
        {
            // Set Barcode
            //product.Barcode = txtCustomBarcode.Text;
        }

        private void PnlProductColor_Click(object sender, EventArgs e)
        {
            Blur blur = new Blur(this, UIConstants.MinBlurOpacity);
            blur.Show();

            var color = (pnlProductColor.BackColor == SoftColor) ? Color.Transparent : pnlProductColor.BackColor;
            ColorPicker colorPicker = new ColorPicker
            {
                ColorValue = color
            };

            //Show Picker with Color as results
            var pickedColor = colorPicker.ShowWithResult();

            // Upadate
            pnlProductColor.BackColor = pickedColor;
            product.Color = pickedColor;

            blur.Close();
        }


        private void TxtSupplyPrice_OnValueChanged(object sender, EventArgs e)
        {
            lblSupplyPrice.Text = txtSupplyPrice.Text + " " + Currency;
        }

        private void TxtRetailPrice_KeyDown(object sender, KeyEventArgs e)
        {
            // Update Markup If Pressed Enter
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    var markupPtg = decimal.Parse(txtSupplyPrice.Text) / decimal.Parse(txtRetailPrice.Text) * 100;
                    txtMarkupPtg.Text = StringUtil.ToRoundedString(markupPtg);
                }
                catch { return; }
            }
        }

        private void TxtMarkupPercentage_KeyDown(object sender, KeyEventArgs e)
        {
            // Update RetailPrice If Enter Pressed
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    var markupPtg = decimal.Parse(txtMarkupPtg.Text);
                    var supplyPrice = decimal.Parse(txtSupplyPrice.Text);
                    var retailPrice = (markupPtg * supplyPrice / 100) + supplyPrice;
                    txtRetailPrice.Text = StringUtil.ToRoundedString(retailPrice);
                }
                catch { return; }
            }
        }

        private void TxtTaxPtg_KeyDown(object sender, KeyEventArgs e)
        {
            // Update RetailPrice If Enter pressed
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    var grossPrice = Convert.ToDecimal(txtRetailPrice.Text);
                    var taxRate = Convert.ToDecimal(txtTaxPtg.Text);
                    var netPrice = (grossPrice * taxRate / 100) + grossPrice;
                    txtRetailPrice.Text = StringUtil.ToRoundedString(netPrice);
                }
                catch { return; }
            }
        }

        private void ImgbtnGoSecondFields_Click(object sender, EventArgs e)
        {
            ToPanel(PanelIndex.Second);
        }

        private void ImgbtnGoFirstFields_Click(object sender, EventArgs e)
        {
            ToPanel(PanelIndex.First);
        }

        private void Imgbtn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion

        #region  Methods


        void Initialize()
        {
            user = Util.Data.GetUser();
            store = Util.Data.GetStore();
            product = ProductObject;

            //Get Task
            if (Task == Enums.Task.Get || Task == Enums.Task.Update)
            {
                GetProduct();
            }
            else if (Task == Enums.Task.Create)
            {
                product = new Backend.Objects.Product
                {
                    Supplier = new Backend.Objects.ProductSupplier(),
                    Brand = new Backend.Objects.ProductBrand(),
                    Type = new Backend.Objects.ProductType(),
                    Tax = new Backend.Objects.Tax()
                };

                txtCustomBarcode.Text = ServerUtil.RandomDigits(13);
                btnDelete.Visible = false;
            }

            sign_currency1.Text = sign_currency2.Text = store.CurrencySign;

            // Add DropDown Items           
            SetDropDownItems();

            Translate();
        }


        void GetProduct()
        {
            if (QueryController.Products.Product.IsValid(product))
            {
                lblTitle.Text = product.Name;
                txtProductName.Text = product.Name;
                rtxtDescription.Text = product.Description;
                txtCustomBarcode.Text = product.Barcode;

                lblSupplyPrice.Text = txtSupplyPrice.Text = product.SupplyPrice.ToString();
                txtRetailPrice.Text = product.RetailPrice.ToString();
                txtMarkupPtg.Text = product.Markup.ToString();
                ckbIsBalanceRequired.Checked = product.IsBalanceRequired;

                imgProductImage.Image = product.Image;
                cardProductImage.color = product.Color;
                pnlProductColor.BackColor = product.Color;

                //Render Barcode
                RenderBarcode(product.Barcode);
            }
            else
                Util.MessageParser.Alert("Product", Util.AlertParserType.NotFound);
        }

        void UpdateProduct()
        {
            if (QueryController.Products.Product.IsValid(product))
            {
                SetProductProperties();
                var response = QueryController.Products.Product.Update(product);
                if (response.StatusCode == 204)
                {
                    UpdateProductImage();
                    ActionDialog = Enums.ActionDialog.Updated;
                    this.Close();

                    Util.MessageParser.Alert("Product", Util.AlertParserType.Updated);
                }
                else
                    Util.MessageParser.Alert("Product", Util.AlertParserType.ErrorUpdating);
            }
            else
                Util.MessageParser.Alert("Product", Util.AlertParserType.NotFound);
        }

        void CreateProduct()
        {
            SetProductProperties();
            var response = QueryController.Products.Product.Create(product);
            if (response.StatusCode == 201)
            {
                var _product = (Backend.Objects.Product)response.Data;
                // Update Image
                if (LocalImagePath != null)
                    UploadProductImage(_product);

                this.OnCreate(_product, null);
                this.Close();

                Util.MessageParser.Alert("Product", Util.AlertParserType.Created);
            }
            else
                Util.MessageParser.Alert("Product", Util.AlertParserType.ErrorCreating);
        }

        void DeleteProduct()
        {
            // Delete Image
            DeleteProductImage();

            if (QueryController.Products.Product.IsValid(product))
            {
                var response = QueryController.Products.Product.Delete(product);
                if (response.StatusCode == 204)
                {
                    ActionDialog = Enums.ActionDialog.Deleted;
                    this.Close();
                    Util.MessageParser.Alert("Product", Util.AlertParserType.Deleted);
                }
                else
                    Util.MessageParser.Alert("Product", Util.AlertParserType.ErrorDeleting);
            }
            else
                Util.MessageParser.Alert("Product", Util.AlertParserType.NotFound);
        }

        void SetProductProperties()
        {
            product.Name = txtProductName.Text;
            product.Description = rtxtDescription.Text;
            product.Barcode = txtCustomBarcode.Text;
            product.SupplyPrice = decimal.Parse(txtSupplyPrice.Text);
            product.RetailPrice = decimal.Parse(txtRetailPrice.Text);
            product.Markup = decimal.Parse(txtMarkupPtg.Text);
        }

        void DeleteProductImage()
        {
            if (Validation.IsTokenValid(product.ImageBlobId, 30))
            {
                var file = (Backend.Objects.File)QueryController.Blob.Get(product.ImageBlobId).Data;
                QueryController.Blob.Delete(file);
            }
            imgProductImage.Image = ImageUtil.DrawLetter(product.Name, backgroundColor: product.Color);
        }

        void UpdateProductImage()
        {
            if (LocalImagePath != null)
            {
                //Delete Old Image
                if (Validation.IsTokenValid(product.ImageBlobId, 30))
                    DeleteProductImage();
                //Upload new Image
                UploadProductImage(product);
            }
        }

        void UploadProductImage(Backend.Objects.Product product)
        {
            Backend.Objects.File file = new Backend.Objects.File
            {
                SystemFileName = LocalImagePath,
                Extension = ".jpg",
                ServerFolder = ServerConstants.ServerFolderPath,
            };
            // Returns BlobId
            var response = QueryController.Blob.Create(file);
            var _file = (Backend.Objects.File)response.Data;
            // Update ImageBlobId
            QueryController.Products.Product.UpdateImage(product, _file);
            product.Image = imgProductImage.Image;
        }

        void SetDropDownItems()
        {
            // Suppliers
            var suppliersResponse = QueryController.Products.Supplier.GetSuppliers();
            if (suppliersResponse.StatusCode == 200)
                foreach (Backend.Objects.ProductSupplier supplier in suppliersResponse.DataArray)
                    dpdSupplier.AddItem(supplier.Name);

            // Brands
            var brandsResponse = QueryController.Products.Brand.GetBrands();
            if (brandsResponse.StatusCode == 200)
                foreach (Backend.Objects.ProductBrand brand in brandsResponse.DataArray)
                    dpdProductBrand.AddItem(brand.Name);

            // Types
            var typesResponse = QueryController.Products.Type.GetTypes();
            if (typesResponse.StatusCode == 200)
                foreach (Backend.Objects.ProductType type in typesResponse.DataArray)
                    dpdProductType.AddItem(type.Name);

            // Taxes
            var taxesResponse = QueryController.Tax.GetTaxes(store);
            if (taxesResponse.StatusCode == 200)
                foreach (Backend.Objects.Tax tax in taxesResponse.DataArray)
                    dpdTax.AddItem(tax.Name);

            // Default (none)
            dpdSupplier.selectedIndex = dpdTax.selectedIndex = dpdProductType.selectedIndex = dpdProductBrand.selectedIndex = 0;
        }

        void RenderBarcode(string code)
        {
            if (string.IsNullOrEmpty(code))
                return;
            BarcodeImage = CodeGenerator.GenerateBarcode(code);
            imgProductBarcode.Image = BarcodeImage;
        }

        bool IsInputValid()
        {
            if (!Validation.IsStringValid(txtProductName.Text, 2, 100))
                return false;
            else
                return true;
        }

        void InitializeUI()
        {
            SoftColor = UserInterface.SoftColor;
            Color HoverColor = Color.FromArgb(200, SoftColor);
            UserInterface.SetFlatButtonColor(btnDeleteImage, SoftColor);
            UserInterface.SetFlatButtonColor(btnSelectImage, SoftColor);
            UserInterface.SetFlatButtonColor(btnScanCode, SoftColor);
            UserInterface.SetFlatButtonColor(btnSave, SoftColor);
            txtProductName.BorderColorFocused = txtSupplyPrice.BorderColorFocused = txtCustomBarcode.BorderColorFocused =
                txtMarkupPtg.BorderColorFocused = txtRetailPrice.BorderColorFocused = SoftColor;
            //Change Value Color
            ckbIsBalanceRequired.CheckedOnColor = ckbIsBalanceRequired.CheckedOnColor = SwitchSellOnPOS.OnColor = SoftColor;
            txtProductName.BorderColorMouseHover = txtSupplyPrice.BorderColorMouseHover = txtCustomBarcode.BorderColorMouseHover =
                txtMarkupPtg.BorderColorMouseHover = txtRetailPrice.BorderColorMouseHover = SoftColor;
            //Color Images
            imgbtn_Exit.Image = ImageUtil.ColorImage(imgbtn_Exit.Image, ColorGray);
            imgbtnGoFirstFields.Image = ImageUtil.ColorImage(imgbtnGoFirstFields.Image, ColorGray);
            imgbtnGoSecondFields.Image = ImageUtil.ColorImage(imgbtnGoSecondFields.Image, ColorGray);
            //Default Location
            imgbtn_Exit.Location = new Point(833, 9);
            this.Size = ControlDefaultSize;

            pnlProductColor.BackColor = SoftColor;
        }

        void ToPanel(PanelIndex panelIndex)
        {
            if (panelIndex == PanelIndex.First)
            {
                //Change Panel Location
                pnlFirstFields.Location = ActiveField;
                pnlSecondFields.Location = InActiveField;
            }
            else if (panelIndex == PanelIndex.Second)
            {
                //Change Panel Location
                pnlFirstFields.Location = InActiveField;
                pnlSecondFields.Location = ActiveField;
            }
        }

        #endregion

        #region Translate 

        void Translate()
        {
            Translation.ForceUpdate();

            if (Translation.IsPossible())
            {
                //Translate Strings 
                foreach (Control control in pnlFirstFields.Controls)
                    if (control is Label && !control.Name.Contains("lblTitle"))
                        Translation.TranslateControl(control);

                foreach (Control control in pnlSecondFields.Controls)
                    if (control is Label && !control.Name.Contains("lbl") && !control.Name.Contains("sign_"))
                        Translation.TranslateControl(control);

                Translation.TranslateControl(btnDelete);
                Translation.TranslateControl(btnSave);
                Translation.TranslateControl(btnSelectImage);
                Translation.TranslateControl(text_BackToFields);
                Translation.TranslateControl(text_ProductImage);

                if (Task == Enums.Task.Create)
                    lblTitle.Text = Translation.Translate("New Product");
            }
        }

        #endregion

        #region OnClose

        #endregion

      
    }
}

#region Backup

/*
// Supplier
if (dpdSupplier.selectedValue.ToLower() == "(none)" || dpdSupplier.selectedIndex == 0)
    product.Supplier.Id = "";
else
    product.Supplier.Id = ProductSupplier.GetIdByName(dpdSupplier.selectedValue);

// Brand 
if (dpdProductBrand.selectedValue.ToLower() == "(none)" || dpdProductBrand.selectedIndex == 0)
    product.Brand.Id = "";
else
    product.Brand.Id = ProductBrand.GetIdByName(dpdProductBrand.selectedValue);

// Type 
if (dpdProductType.selectedValue.ToLower() == "(none)" || dpdProductType.selectedIndex == 0)
    product.Type.Id = "";
else
    product.Type.Id = ProductType.GetIdByName(dpdProductType.selectedValue);

// Tax 
if (dpdTax.selectedValue.ToLower() == "(none)" || dpdTax.selectedIndex == 0)
    product.Tax.Id = "";
else
    product.Tax.Id = Tax.GetIdByName(dpdTax.selectedValue);*/
/*
// Supplier
if (dpdSupplier.selectedValue.ToLower() != "(none)" || dpdSupplier.selectedIndex != 0)
product.Supplier.Id = ProductSupplier.GetIdByName(dpdSupplier.selectedValue);

// Brand 
if (dpdProductBrand.selectedValue.ToLower() != "(none)" || dpdProductBrand.selectedIndex != 0)
product.Brand.Id = ProductBrand.GetIdByName(dpdProductBrand.selectedValue);

// Type 
if (dpdProductType.selectedValue.ToLower() != "(none)" || dpdProductType.selectedIndex != 0)
product.Type.Id = ProductType.GetIdByName(dpdProductType.selectedValue);

// Tax 
if (dpdTax.selectedValue.ToLower() != "(none)" || dpdTax.selectedIndex != 0)
product.Tax.Id = Tax.GetIdByName(dpdTax.selectedValue);*/

#endregion