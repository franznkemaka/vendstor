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
    public partial class ProductTypeModel : UserControl
    {
        #region Variables

        public Backend.Objects.ProductType Type { get; set; }
        public Backend.Objects.User User { get; set; }

        public EventHandler OnDelete;

        Color SoftColor;

        #endregion

        #region Constructors

        public ProductTypeModel()
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

            Forms.Products.Type type = new Forms.Products.Type
            {
                ProductType = Type,
                Task = task,
                TopMost = true
            };

            // Update If Updated
            var formResponse = type.ShowWithResponse();
            if (formResponse.ActionDialog == Enums.ActionDialog.Updated)
            {
                Type = (Backend.Objects.ProductType)formResponse.Data;

                //Force Update
                this.Initialize();
            }

            //Remove Blur 
            blur.Close();
        }

        private void OnSizeChanged(object sender, EventArgs e)
        {

        }

        #endregion

        #region Control - Event Handler


        private void BtnEditType_Click(object sender, EventArgs e)
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
                Message = $"Are you sure you want to permanently delete { Type.Name }, this type will be deleted immediately. You can't undo this action.",
                TopMost = true,
            };

            var dialogResult = messageDialog.ShowWithEvent();
            if (dialogResult == MessageDialog.OnClickEvent.ThirdButton)
            {
                //Delete
                DeleteType();
            }

            blur.Close();
        }

        #endregion

        #region  Methods

        void Initialize()
        {
            //Get 
            if (Type is object)
            {
                lblTypeName.Text = Type.Name;
                lblProductsCount.Text = Type.ProductsCount.ToString();
            }
            else
                Alert.Show("Error", $"Something wrong occured", Alert.AlertType.Error);

            //Hide Delete Button if not allowed
            if (!Util.Func.IsUserAllowed(User))
                btnDelete.Visible = false;
        }

        void DeleteType()
        {
            if (QueryController.Products.Type.IsValid(Type))
            {
                var response = QueryController.Products.Type.Delete(Type);
                if (response.StatusCode == 204)
                {
                    // Delete -> Nothing to show
                    this.OnDelete(this, null);
                    this.Hide();
                    Util.MessageParser.Alert("Type", Util.AlertParserType.Deleted);
                }
                else
                    Util.MessageParser.Alert("Type", Util.AlertParserType.ErrorDeleting);
            }
            else
                Util.MessageParser.Alert("Type", Util.AlertParserType.NotFound);
        }

        void InitializeUI()
        {
            // Get Color from Class According Properties.Settings
            SoftColor = UserInterface.SoftColor;

            //Change Color
            //Change Color
            btnViewProducts.BackColor = btnViewProducts.Activecolor = btnViewProducts.Normalcolor = btnEditType.BackColor = btnEditType.Activecolor =
               btnEditType.Normalcolor = SoftColor;

            //HoverColor
            btnViewProducts.OnHovercolor = btnEditType.OnHovercolor = Color.FromArgb(200, SoftColor);
        }

        #endregion

        #region OnClose


        #endregion
    }
}
