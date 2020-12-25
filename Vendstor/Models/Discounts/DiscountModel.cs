using System;
using System.Drawing;
using System.Windows.Forms;

//Vendstor
using Vendstor.Forms;
using Vendstor.Modals;
using Vendstor.Forms.Discounts;

using Vendstor.Backend;
using Vendstor.Backend.Data;
using Vendstor.Backend.Utils;
using Vendstor.Backend.Constants;
using Vendstor.Backend.Database.Queries;

namespace Vendstor.Models.Discounts
{
    public partial class DiscountModel : UserControl
    {
        #region Variables

        public Backend.Objects.Discount Discount { get; set; }
        public Backend.Objects.User User { get; set; }
        public Backend.Objects.Store Store { get; set; }

        public EventHandler OnDelete;
        public EventHandler OnToggle;

        public bool IsToggled = false;
        int DefaultSizeHeigt = 43;

        Color SoftColor;

        Image expandImage = Properties.Resources.expand_checkout_w;
        Image collapseImage = Properties.Resources.collapse_arrow_w;

        #endregion

        #region Constructors

        public DiscountModel()
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
            ToggleControl();
        }

        private void OnDoubleClick(object sender, EventArgs e)
        {
            DisplayDiscount(Enums.Task.Get);
        }

        private void OnSizeChanged(object sender, EventArgs e)
        {

        }

        #endregion

        #region Control - Event Handler

        private void BtnViewDiscounts_Click(object sender, EventArgs e)
        {
            // Show Form
            Extensions.ShowDialogWithBlur(this.ParentForm, new DiscountProducts
            {
                Discount = Discount,
                User = User,
                Store = Store,
                TopMost = true
            }, UIConstants.FormBlurOpacity);
        }

        private void BtnEditDiscount_Click(object sender, EventArgs e)
        {
            DisplayDiscount(Enums.Task.Update);
        }

        void DisplayDiscount(Enums.Task task)
        {
            //Add Blur 
            Blur blur = new Blur(this.ParentForm, UIConstants.FormBlurOpacity);
            blur.Show();

            Forms.Discounts.Discount product = new Forms.Discounts.Discount
            {
                DiscountObject = Discount,
                OnDelete = OnDeleteDiscount,
                Task = task,
                TopMost = true
            };

            // Update If Updated
            var formResponse = product.ShowWithResponse();
            if (formResponse.ActionDialog == Enums.ActionDialog.Updated)
            {
                Discount = (Backend.Objects.Discount)formResponse.Data;
                //Force Update
                this.Initialize();
            }

            //Remove Blur 
            blur.Close();
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
                Message = $"Are you sure you want to permanently delete { Discount.Name }, this product will be deleted immediately. You can't undo this action.",
                TopMost = true,
            };

            var dialogResult = messageDialog.ShowWithEvent();
            if (dialogResult == MessageDialog.OnClickEvent.ThirdButton)
            {
                //Delete
                DeleteDiscount();
            }

            blur.Close();
        }

        private void ImgbtnToggleControl_Click(object sender, EventArgs e)
        {
            ToggleControl();
        }

        #endregion

        #region  Methods

        void Initialize()
        {
            // Permissions
            if (!Util.Func.IsUserAllowed(User))
                btnDelete.Visible = btnEdit_Header.Visible = btnEditDiscount.Visible = false;


            //Get 
            if (Discount is object && Store is object)
            {
                lblStartDate_Header.Text = Discount.StartDate.ToLongDateString();
                lblEndDate_Header.Text = Discount.EndDate.ToLongDateString();

                lblDiscountName.Text = lblName_Header.Text = Discount.Name;
                lblDiscountDescription.Text = Discount.Description;
                lblType.Text = Discount.Type;

                var sign = (Discount.Type.ToLower() == "cash") ? Store.CurrencySign : "%";
                lblValue.Text = string.Format("{0} {1}", sign, Discount.Value);
            }
            else
                Alert.Show("Error", $"Something wrong occured", Alert.AlertType.Error);

            //Hide Delete Button if not allowed
            if (!Util.Func.IsUserAllowed(User))
            {
                //btnViewDiscounts.Location = btnEditDiscount.Location;
                btnDelete.Visible = btnEditDiscount.Visible = false;
            }
        }

        void DeleteDiscount()
        {
            if (QueryController.Products.Discount.IsValid(Discount))
            {
                var response = QueryController.Products.Discount.Delete(Discount);
                if (response.StatusCode == 204)
                {
                    // Delete -> Nothing to show
                    this.OnDelete(this, null);
                    this.Hide();
                    Util.MessageParser.Alert("Discount", Util.AlertParserType.Deleted);                    
                }
                else
                    Util.MessageParser.Alert("Discount", Util.AlertParserType.ErrorDeleting);
            }
            else
                Util.MessageParser.Alert("Discount", Util.AlertParserType.NotFound);
        }

        void OnDeleteDiscount(object sender, EventArgs e)
        {
            this.OnDelete(this, null);
        }

        void InitializeUI()
        {
            SoftColor = UserInterface.SoftColor;
            Indicator.BackColor = SoftColor;
            //Color Images
            expandImage = ImageUtil.ColorImage(expandImage, UserInterface.ColorGray);
            collapseImage = ImageUtil.ColorImage(collapseImage, UserInterface.ColorGray);
            imgDiscount.Image = ImageUtil.ColorImage(imgDiscount.Image, UserInterface.ColorGray);
            UserInterface.SetFlatButtonColor(btnEdit_Header, SoftColor);
            UserInterface.SetFlatButtonColor(btnViewDiscounts, SoftColor);
            UserInterface.SetFlatButtonColor(btnEditDiscount, SoftColor);
            this.Size = new Size(this.Size.Width, DefaultSizeHeigt);
            imgbtnToggleControl.Image = expandImage;
            btnViewDiscounts.Visible = btnEditDiscount.Visible = btnDelete.Visible = false;
        }

        void ToggleControl()
        {
            this.OnToggle(this, null);
        }

        public void Toggle(bool expand = false)
        {
            //Expand or Collapse UC 
            //ExpandControl = (ExpandControl) ? false : true;
            //IsToggled = (expand) ? false : true;
            IsToggled = expand;
            btnViewDiscounts.Visible = btnEditDiscount.Visible = btnDelete.Visible = expand;
            ResizeControl();
        }

        void ResizeControl()
        {
            int expandSizeHeight = 195;

            //Refresh UI 
            if (IsToggled)
            {
                imgbtnToggleControl.Image = collapseImage;
                //Change  Height Only
                this.Size = new Size(this.Size.Width + 5, expandSizeHeight);
                Indicator.Visible = GridSeperator_Collapse.Visible = true;
            }
            else
            {
                imgbtnToggleControl.Image = expandImage;
                //Change  Height Only
                this.Size = new Size(this.Size.Width - 5, DefaultSizeHeigt);
                Indicator.Visible = false;
            }
            //Refresh
            Indicator.Refresh();
        }

        #endregion

        #region Translate

        void Translate()
        {

        }


        #endregion

        #region OnClose


        #endregion

    }
}
