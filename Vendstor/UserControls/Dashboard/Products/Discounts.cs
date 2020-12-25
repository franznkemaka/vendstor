using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;

//Vendstor
using Vendstor.Forms;
using Vendstor.Modals;
using Vendstor.Models.Discounts;
using Vendstor.Forms.Discounts;

using Vendstor.Backend;
using Vendstor.Backend.Data;
using Vendstor.Backend.Utils;
using Vendstor.Backend.Constants;
using Vendstor.Backend.Database.Queries;

namespace Vendstor.UserControls.Dashboard.Products
{
    public partial class Discounts : UserControl
    {
        #region Variables

        Backend.Objects.User user = new Backend.Objects.User();
        Backend.Objects.Store store = new Backend.Objects.Store();
        List<object> discounts = new List<object>();

        Color SoftColor;

        //Size NormalSize = new Size(1128, 597);

        #endregion

        #region Constructors

        public Discounts()
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

        private void OnSizeChanged(object sender, EventArgs e)
        {
            this.ResizeControl();
        }

        #endregion

        #region Control - Event Handler

        private void BtnAddDiscount_Click(object sender, EventArgs e)
        {
            if (!Util.Func.IsUserAllowed(user, Util.PermissionAlertType.Message, this.ParentForm))
                return;

            //Add Blur 
            Blur blur = new Blur(this.ParentForm, UIConstants.FormBlurOpacity);
            blur.Show();

            Forms.Discounts.Discount discount = new Forms.Discounts.Discount
            {
                OnCreate = OnCreateDiscount,
                Task = Enums.Task.Create,
                TopMost = true
            };

            //Update
            var dialogResult = discount.ShowWithResult();

            //Remove Blur
            blur.Close();
        }


        private void DiscountsGrid_DoubleClick(object sender, EventArgs e)
        {
            // FORCE Update
            GetDiscounts();
        }

        #endregion

        #region  Methods

        void Initialize()
        {
            // Get 
            user = Util.Data.GetUser();
            store = Util.Data.GetStore();

            // Get 
            GetDiscounts();

            Translate();
        }

        void GetDiscounts()
        {
            if (QueryController.User.IsIdValid(user.Id))
            {
                var response = QueryController.Products.Discount.GetDiscounts();
                if (response.StatusCode == 200)
                {
                    DiscountsGrid.Controls.Clear();

                    // Render EmptyData if Count == 0 and show no results if searchQueryType is different from none
                    RenderCard(response.DataArray.Count == 0);

                    discounts = response.DataArray;
                    foreach (Backend.Objects.Discount discount in response.DataArray)
                        AddDiscountToGrid(discount);
                }
                // No Content
                else if (response.StatusCode == 204)
                    RenderCard(response.DataArray.Count == 0);
            }
            else
            {
                Alert.Show("User Account Error", "Please login again, an error occured", Alert.AlertType.Error, isMini: false);
            }
        }

        void AddDiscountToGrid(Backend.Objects.Discount discount)
        {
            //Fill Grid [ DiscountsGrid ] With Rows
            DiscountModel discountModel = new DiscountModel
            {
                OnDelete = OnDeleteDiscount,
                Discount = discount,
                OnToggle = OnToggleModel,
                User = user,
                Store = store,
            };
            //Add To Grid
            DiscountsGrid.Controls.Add(discountModel);
        }

        public void OnCreateDiscount(object sender, EventArgs e)
        {
            var newDiscount = (Backend.Objects.Discount)sender;
            AddDiscountToGrid(newDiscount);

            // Update Controls 
            RenderCard(false);
        }

        public void OnDeleteDiscount(object sender, EventArgs e)
        {
            DiscountsGrid.Controls.Remove((DiscountModel)sender);
            // Update Controls 
            if (DiscountsGrid.Controls.Count == 0)
                RenderCard();
        }

        public void OnToggleModel(object sender, EventArgs e)
        {
            // Toggle Controls
            DiscountModel discountModel = (DiscountModel)sender;
            if (discountModel.IsToggled)
            {
                discountModel.Toggle(false);
                //discountModel.IsToggled = false;

                return;
            }

            foreach (DiscountModel control in DiscountsGrid.Controls)
                if (control != discountModel)
                {
                    control.Toggle(false);
                    //control.IsToggled = false;
                }

                else
                {
                    control.Toggle(true);
                    //control.IsToggled = true;
                }
        }

        void InitializeUI()
        {
            SoftColor = UserInterface.SoftColor;
            btnAddDiscount.Activecolor = btnAddDiscount.BackColor = btnAddDiscount.Normalcolor = SoftColor;
            btnAddDiscount.OnHovercolor = Color.FromArgb(200, SoftColor);
        }

        void RenderCard(bool isVisible = true)
        {
            cardFeatures.Visible = isVisible;
            DiscountsGrid.Visible = !isVisible;
        }

        public void ResizeControl()
        {
            UserControlUtil.Func.ResizeControl(DiscountsGrid, this.Size, 3, 100 + 70, 150 + 70);
            // 356
            if (this.Size.Height < 600)
                DiscountsGrid.Size = new Size(1106, 356);
        }

        #endregion

        #region Translate

        void Translate()
        {
            //Check Translator API 
            if (Translation.IsPossible())
            {
                //Translate Strings 
                foreach (Control control in pnlHeader.Controls)
                    Translation.TranslateControl(control);

                foreach (Control control in pnlGridHeader.Controls)
                    if (control is Label)
                        Translation.TranslateControl(control);

                Translation.TranslateControl(btnAddDiscount);
                Translation.TranslateControl(lbText_Card);
                ReCenterCardControls();
            }
        }
        void ReCenterCardControls()
        {
            // ReCenter
            Util.Methods.AlignToParent(lbText_Card, cardFeatures, (int)Util.Methods.AlignIndex.HCenter);
            UserControlUtil.Func.MoveControlTo(btnAddDiscount, new Point(934, 8), new Size(159, 40), new Point(894, 8), new Size(199, 40));
        }

        #endregion

        #region OnClose

        #endregion

    }
}
