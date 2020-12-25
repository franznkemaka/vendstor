using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;

//Vendstor
using Vendstor.Modals;
using Vendstor.Models.Products;

using Vendstor.Backend;
using Vendstor.Backend.Data;
using Vendstor.Backend.Utils;
using Vendstor.Backend.Constants;
using Vendstor.Backend.Libraries;
using Vendstor.Backend.Database.Queries;

namespace Vendstor.Forms.Discounts
{
    public partial class Discount : Form
    {
        #region Variables

        public Backend.Objects.Discount DiscountObject = new Backend.Objects.Discount();

        Backend.Objects.Discount discount = new Backend.Objects.Discount();
        List<object> ProductDiscounts = new List<object>();

        Backend.Objects.User User = new Backend.Objects.User();
        Backend.Objects.Store Store = new Backend.Objects.Store();

        public EventHandler OnCreate;
        public EventHandler OnDelete;
        public Enums.Task Task { get; set; }
        public string RootForm { get; set; }

        enum PanelIndex { First, Second }
        Enums.ActionDialog ActionDialog { get; set; }

        string DiscountType { get; set; }

        Size ControlDefaultSize = new Size(888, 550);
        Point ActiveField = new Point(12, 12);
        Point InActiveField = new Point(12, 556);

        Color SoftColor;
        Color ColorGray = Color.FromArgb(209, 212, 221);

        Image DefaultImage = Properties.Resources.delete_w;

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
                Data = discount,
            };
        }

        private void BtnAction_Click(object sender, EventArgs e)
        {
            if (!IsInputValid())
                return;

            if (Task == Enums.Task.Update || Task == Enums.Task.Get)
            {
                ActionDialog = Enums.ActionDialog.Updated;
                UpdateDiscount();
            }
            else if (Task == Enums.Task.Create)
            {
                ActionDialog = Enums.ActionDialog.Created;
                CreateDiscount();
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
                Message = $"Are you sure you want to permanently delete { discount.Name }, this discount will be deleted immediately with all its discounts. You can't undo this action.",
                TopMost = true,
            };

            var dialogResult = messageDialog.ShowWithEvent();
            if (dialogResult == MessageDialog.OnClickEvent.ThirdButton)
            {
                ActionDialog = Enums.ActionDialog.Deleted;
                //Delete
                DeleteDiscount();
            }

            blur.Close();
        }

        private void BtnAddProduct_Click(object sender, EventArgs e)
        {
            Blur blur = new Blur(this, UIConstants.FormBlurOpacity);
            blur.Show();

            new SearchItems
            {
                ItemTypeIndex = SearchItems.ItemType.Product,
                User = Util.Data.GetUser(),
                Store = Util.Data.GetStore(),
                OnAdd = OnAddProduct,
            }.ShowDialog();

            blur.Close();
        }

        private void UpdateCardOn_TextChanged(object sender, EventArgs e)
        {
            lblDiscountDescription_Card.Text = rtxtShortDescription.Text;
            lblDiscountName_Card.Text = txtDiscountName.Text;
        }
        
        private void ProductDiscountsGrid_Click(object sender, EventArgs e)
        {
            //Update Items
            if(Task == Enums.Task.Update || Task == Enums.Task.Get)
                GetDiscountProducts();
        }

        private void OnDiscountTypeButton_Click(object sender, EventArgs e)
        {
            Control control = (Control)sender;
            SetDicountType(control.Name);
        }

        private void ImgbtnGoSecondFields_Click(object sender, EventArgs e)
        {
            ToPanel(PanelIndex.Second);
        }

        private void ImgbtnGoFirstFields_Click(object sender, EventArgs e)
        {
            ToPanel(PanelIndex.First);
        }

        private void ImgbtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        #endregion

        #region  Methods
        
        void Initialize()
        {
            User = Util.Data.GetUser();
            Store = Util.Data.GetStore();
            discount = DiscountObject;

            //Get Task
            if (Task == Enums.Task.Get || Task == Enums.Task.Update)
            {
                GetDiscount();
                GetDiscountProducts();
            }
            else if (Task == Enums.Task.Create)
            {
                discount = new Backend.Objects.Discount { Type = null };
                txtDiscountValue.Text = "0";
                btnDelete.Visible = false;
            }

            Translate();
        }

        void GetDiscount()
        {
            if (QueryController.Products.Discount.IsValid(discount))
            {
                txtDiscountName.Text = discount.Name;
                rtxtShortDescription.Text = discount.Description;
                txtDiscountValue.Text = discount.Value.ToString();
                dpStartDate.Value = discount.StartDate;
                dpEndDate.Value = discount.EndDate;

                SetDicountType(discount.Type);
            }
            else
                Util.MessageParser.Alert("Discount", Util.AlertParserType.NotFound);
        }

        void UpdateDiscount()
        {
            if (QueryController.Products.Discount.IsValid(discount))
            {
                SetDiscountProperties();
                var response = QueryController.Products.Discount.Update(discount);
                if (response.StatusCode == 204)
                {
                    ActionDialog = Enums.ActionDialog.Updated;
                    this.Close();
                    Util.MessageParser.Alert("Discount", Util.AlertParserType.Updated);
                }
                else
                    Util.MessageParser.Alert("Discount", Util.AlertParserType.ErrorUpdating);
            }
            else
                Util.MessageParser.Alert("Discount", Util.AlertParserType.NotFound);
        }
      
        void CreateDiscount()
        {
            SetDiscountProperties();
            var response = QueryController.Products.Discount.Create(discount);
            if (response.StatusCode == 201)
            {
                this.OnCreate(discount, null);
                Util.MessageParser.Alert("Discount", Util.AlertParserType.Created);
            }
            else
                Util.MessageParser.Alert("Discount", Util.AlertParserType.ErrorCreating);
        }

        void DeleteDiscount()
        {
            if (QueryController.Products.Discount.IsValid(discount))
            {
                var response = QueryController.Products.Discount.Delete(discount);
                if (response.StatusCode == 204)
                {
                    this.OnDelete(null, null);
                    ActionDialog = Enums.ActionDialog.Deleted;
                    Util.MessageParser.Alert("Discount", Util.AlertParserType.Deleted);
                }
                else
                    Util.MessageParser.Alert("Discount", Util.AlertParserType.ErrorDeleting);
            }
            else
                Util.MessageParser.Alert("Discount", Util.AlertParserType.NotFound);
        }

        void GetDiscountProducts()
        {
            var response = QueryController.Products.Discount.GetDiscountProducts(discount);
            if(response.StatusCode == 200)
            {
                ProductDiscountsGrid.Controls.Clear();
                ProductDiscounts = response.DataArray;
                foreach (Backend.Objects.DiscountProduct productDiscount in response.DataArray)
                {
                    //Get Product Self
                    var productResponse = QueryController.Products.Product.Get(new Backend.Objects.Product { Id = productDiscount.ProductId });
                    if(productResponse.StatusCode == 200)
                        AddProductToGrid((Backend.Objects.Product)productResponse.Data);
                }                    
            }
        }

        bool AddProductDiscount(Backend.Objects.DiscountProduct product)
        {
            var response = QueryController.Products.Discount.AddProduct(product);
            if (response.StatusCode == 201)
                Alert.Show("Product added to Discount", $"Product was successfully added to Discount ",
                    Alert.AlertType.Success, isMini: false);

            else if (response.StatusCode == 409)
            {
                Alert.Show("Product already Used", $"This Product is already in a Discount please remove it before adding it here",
                   Alert.AlertType.Warning, isMini: false);
                return false;
            }
               
            else
                return false;
            return true;
        }

        bool RemoveProductDiscount(Backend.Objects.DiscountProduct product)
        {
            var response = QueryController.Products.Discount.RemoveProduct(product);
            if (response.StatusCode == 204)
            {
                Alert.Show("Product removed From Discount", $"Product was successfully removed from Discount ",
                    Alert.AlertType.Success, isMini: false);
            }
            else
                return false;
            return true;
        }
        
        void AddProductToGrid(Backend.Objects.Product product)
        {
            //Fill Grid [ ItemsGrid ] With Rows
            ProductItemModel productItemModel = new ProductItemModel
            {
                //OnAdd = OnAddProduct,
                OnDelete = OnRemoveProduct,
                Product = product,
                User = User,
                Store = Store,
                CanDelete = true,
            };
            //Add To Grid
            ProductDiscountsGrid.Controls.Add(productItemModel);
        }

        public void OnAddProduct(object sender, EventArgs e)
        {
            var product = (Backend.Objects.Product)sender;
            var productDiscount = ToProductDiscount(product);

            if (AddProductDiscount(productDiscount))
                AddProductToGrid(product);

            //Array
            ProductDiscounts.Add(productDiscount);
        }

        public void OnRemoveProduct(object sender, EventArgs e)
        {
            var productModel = (ProductItemModel)sender;
            var productDiscount = ToProductDiscount(productModel.Product);

            if (RemoveProductDiscount(productDiscount))
                ProductDiscountsGrid.Controls.Remove(productModel);
            
            //Array
            ProductDiscounts.Remove(productDiscount);
        }

        Backend.Objects.DiscountProduct ToProductDiscount(Backend.Objects.Product product)
        {
            return new Backend.Objects.DiscountProduct
            {
                ProductId = product.Id,
                DiscountId = discount.Id,
            };
        }

        void SetDiscountProperties()
        {
            discount.Name = txtDiscountName.Text;
            discount.Description = rtxtShortDescription.Text;
            discount.StartDate = dpStartDate.Value;
            discount.EndDate = dpEndDate.Value;
            discount.Value = decimal.Parse(txtDiscountValue.Text);
            discount.ProductDiscounts = ProductDiscounts;
        }

        bool IsInputValid()
        {
            if (!Validation.IsStringValid(txtDiscountName.Text, 2, 100))
                return false;
            else if (!Validation.IsStringValid(discount.Type, 2, 20))
                return false;
            else
                return true;
        }

        void InitializeUI()
        {
            SoftColor = UserInterface.SoftColor;
            Color HoverColor = Color.FromArgb(200, SoftColor);
            imgbtnExit.Image = ImageUtil.ColorImage(imgbtnExit.Image, ColorGray);
            imgbtnGoFirstFields.Image = ImageUtil.ColorImage(imgbtnGoFirstFields.Image, ColorGray);
            imgbtnGoSecondFields.Image = ImageUtil.ColorImage(imgbtnGoSecondFields.Image, ColorGray);
            UserInterface.SetFlatButtonColor(btnAddProduct, SoftColor);
            UserInterface.SetFlatButtonColor(btnSave, SoftColor);
            //Size
            this.Size = ControlDefaultSize;
            //Default Location
            imgbtnExit.Location = new Point(833, 9);
            //Elipse
            new Bunifu.Framework.UI.BunifuElipse { ElipseRadius = 10 }.TargetControl = imgbtnCash;
            new Bunifu.Framework.UI.BunifuElipse { ElipseRadius = 10 }.TargetControl = imgbtnPercentage;
            ImageUtil.ColorImageButton(imgbtnCash, UserInterface.ColorGray);
            ImageUtil.ColorImageButton(imgbtnPercentage, UserInterface.ColorGray);
        }

        void SetDicountType(string type)
        {
            if (type.ToLower().Contains("percentage"))
            {
                ImageUtil.ColorImageButton(imgbtnPercentage, Color.White);
                imgbtnPercentage.BackColor = SoftColor;
                ImageUtil.ColorImageButton(imgbtnCash, UserInterface.ColorGray);
                imgbtnCash.BackColor = Color.White;
                discount.Type = "Percentage";
            }
            else if (type.ToLower().Contains("cash"))
            {
                ImageUtil.ColorImageButton(imgbtnCash, Color.White);
                imgbtnCash.BackColor = SoftColor;
                ImageUtil.ColorImageButton(imgbtnPercentage, UserInterface.ColorGray);
                imgbtnPercentage.BackColor = Color.White;
                discount.Type = "Cash";
            }
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
                    if (control is Label)
                        Translation.TranslateControl(control);

                Translation.TranslateControl(btnDelete);
                Translation.TranslateControl(btnSave);
                Translation.TranslateControl(text_BackToFields);

                if (Task == Enums.Task.Create)
                    lblTitle.Text = Translation.Translate("New Discount");
            }
        }


        #endregion

        #region OnClose

        #endregion

    }
}
