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
    public partial class ProductSupplierModel : UserControl
    {
        #region Variables

        public Backend.Objects.ProductSupplier Supplier { get; set; }
        public Backend.Objects.User User { get; set; }

        public EventHandler OnDelete;

        Color SoftColor;

        #endregion

        #region Constructors

        public ProductSupplierModel()
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
            Blur blur = new Blur(this.ParentForm, UIConstants.FormBlurOpacity);
            blur.Show();

            SupplierDetails supplierDetails = new SupplierDetails
            {
                Supplier = Supplier,
                Task = Enums.Task.Get,
                TopMost = true
            };

            //Update If Updated
            var formResponse = supplierDetails.ShowWithResponse();
            if (formResponse.ActionDialog == Enums.ActionDialog.Updated)
            {
                Supplier = (Backend.Objects.ProductSupplier)formResponse.Data;

                //Force Update
                this.Initialize();
            }
            else if (formResponse.ActionDialog == Enums.ActionDialog.Deleted)
            {
                // Delete -> Nothing to show
                this.OnDelete(this, e);
                this.Hide();
            }
            
            blur.Close();
        }


        #endregion

        #region Control - Event Handler
        
        private void BtnEditSupplier_Click(object sender, EventArgs e)
        {
            Blur blur = new Blur(this.ParentForm, UIConstants.FormBlurOpacity);
            blur.Show();

            Supplier supplier = new Supplier
            {
                ProductSupplier = Supplier,
                Task = Enums.Task.Update,
                TopMost = true
            };

            // Update If Updated
            var formResponse = supplier.ShowWithResponse();
            if (formResponse.ActionDialog == Enums.ActionDialog.Updated)
            {
                Supplier = (Backend.Objects.ProductSupplier)formResponse.Data;

                //Force Update
                this.Initialize();
            }
            else if (formResponse.ActionDialog == Enums.ActionDialog.Deleted)
            {
                // Delete -> Nothing to show
                this.OnDelete(this, e);
                this.Hide();
            }         

            blur.Close();
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
                Message = $"Are you sure you want to permanently delete { Supplier.Name }, this supplier will be deleted immediately. You can't undo this action.",
                TopMost = true,
            };

            var dialogResult = messageDialog.ShowWithEvent();
            if (dialogResult == MessageDialog.OnClickEvent.ThirdButton)
            {
                //Delete
                DeleteSupplier();
            }

            blur.Close();
        }

        #endregion

        #region  Methods
        
        void Initialize()
        {
            //Get 
            if (Supplier is object)
            {
                lblSupplierName.Text = Supplier.Name;
                lblDescription.Text = Supplier.Description;

                lblMarkupPtg.Text = Supplier.Markup.ToString();
                lblProductsCount.Text = Supplier.ProductsCount.ToString();
            }
            else
                Alert.Show("Error", $"Something wrong occured", Alert.AlertType.Error);

            //Hide Delete Button if not allowed
            if (!Util.Func.IsUserAllowed(User))
            {
                btnViewProducts.Location = btnEditSupplier.Location;
                btnDelete.Visible = btnEditSupplier.Visible = false;
            }
        }

        void DeleteSupplier()
        {
            if (QueryController.Products.Supplier.IsValid(Supplier))
            {
                var response = QueryController.Products.Supplier.Delete(Supplier);
                if (response.StatusCode == 204)
                {
                    // Delete -> Nothing to show
                    this.OnDelete(this, null);
                    this.Hide();
                    Util.MessageParser.Alert("Supplier", Util.AlertParserType.Deleted);
                }
                else
                    Util.MessageParser.Alert("Supplier", Util.AlertParserType.ErrorDeleting);
            }
            else
                Util.MessageParser.Alert("Supplier", Util.AlertParserType.NotFound);
        }

        void InitializeUI()
        {
            SoftColor = UserInterface.SoftColor;
            btnViewProducts.BackColor = btnViewProducts.Activecolor = btnViewProducts.Normalcolor = btnEditSupplier.BackColor = btnEditSupplier.Activecolor =
               btnEditSupplier.Normalcolor = SoftColor;
            btnViewProducts.OnHovercolor = btnEditSupplier.OnHovercolor = Color.FromArgb(200, SoftColor);
        }

        #endregion

        #region OnClose


        #endregion

    }
}
