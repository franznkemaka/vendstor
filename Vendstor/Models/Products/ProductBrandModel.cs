using System;
using System.Drawing;
using System.Windows.Forms;

//Vendstor
using Vendstor.Forms;
using Vendstor.Modals;
using Vendstor.Forms.Products;

using Vendstor.Backend;
using Vendstor.Backend.Data;
using Vendstor.Backend.Utils;
using Vendstor.Backend.Constants;
using Vendstor.Backend.Database.Queries;

namespace Vendstor.Models.Products
{
    public partial class ProductBrandModel : UserControl
    {
        #region Variables

        public Backend.Objects.ProductBrand Brand { get; set; }
        public Backend.Objects.User User { get; set; }

        public EventHandler OnDelete;

        Color SoftColor;

        #endregion

        #region Constructors

        public ProductBrandModel()
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

        private void OnClick(object sender, EventArgs e)
        {
            DisplayCustomerGroup(Enums.Task.Update);
        }

        void DisplayCustomerGroup(Enums.Task task)
        {
            //Add Blur 
            Blur blur = new Blur(this.ParentForm, UIConstants.FormBlurOpacity);
            blur.Show();

            Brand brand = new Brand
            {
                ProductBrand = Brand,
                Task = task,
                TopMost = true
            };

            // Update If Updated
            var formResponse = brand.ShowWithResponse();
            if (formResponse.ActionDialog == Enums.ActionDialog.Updated)
            {
                Brand = (Backend.Objects.ProductBrand)formResponse.Data;

                //Force Update
                this.Initialize();
            }

            //Remove Blur 
            blur.Close();
        }


        #endregion

        #region Control - Event Handler

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            DisplayCustomerGroup(Enums.Task.Update);
        }

        private void BtnViewProducts_Click(object sender, EventArgs e)
        {
            
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            Blur blur = new Blur(this.ParentForm, UIConstants.ThirdFormBlurOpacity);
            blur.Show();

            MessageDialog messageDialog = new MessageDialog
            {
                DialogButtonsIndex = MessageDialog.DialogButtons.Two,
                DialogIconIndex = MessageDialog.DialogIcon.Sorry,
                SecondBtnText = "No",
                ThirdBtnText = "Yes",
                ThirdBtnColor = Color.Tomato,
                Title = "Are you sure ?",
                Message = $"Are you sure you want to permanently delete { Brand.Name }, this brand will be deleted immediately. You can't undo this action.",
                TopMost = true,
            };

            var dialogResult = messageDialog.ShowWithEvent();
            if (dialogResult == MessageDialog.OnClickEvent.ThirdButton)
            {
                //Delete
                DeleteBrand();
            }

            blur.Close();
        }


        #endregion

        #region  Methods

        void Initialize()
        {
            //Get 
            if (Brand is object)
            {
                lblBrandName.Text = Brand.Name;
                lblDescription.Text = Brand.Description;

                lblProductsCount.Text = Brand.ProductsCount.ToString();
            }
            else
                Alert.Show("Error", $"Something wrong occured", Alert.AlertType.Error);

            //Hide Delete Button if not allowed
            if (!Util.Func.IsUserAllowed(User))
                btnDelete.Visible = false;
        }

        void DeleteBrand()
        {
            if (QueryController.Products.Brand.IsValid(Brand))
            {
                var response = QueryController.Products.Brand.Delete(Brand);
                if (response.StatusCode == 204)
                {
                    // Delete -> Nothing to show
                    this.OnDelete(this, null);
                    this.Hide();
                    Util.MessageParser.Alert("Brand", Util.AlertParserType.Deleted);
                }
                else
                    Util.MessageParser.Alert("Brand", Util.AlertParserType.ErrorDeleting);
            }
            else
                Util.MessageParser.Alert("Brand", Util.AlertParserType.NotFound);
        }

        void InitializeUI()
        {
            SoftColor = UserInterface.SoftColor;
            btnViewProducts.BackColor = btnViewProducts.Activecolor = btnViewProducts.Normalcolor = btnEdit.BackColor = btnEdit.Activecolor =
               btnEdit.Normalcolor = SoftColor;
            btnViewProducts.OnHovercolor = btnEdit.OnHovercolor = Color.FromArgb(200, SoftColor);
        }

        #endregion

        #region OnClose


        #endregion
    }
}
