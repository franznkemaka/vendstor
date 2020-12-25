using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;

//Vendstor
using Vendstor.Forms;
using Vendstor.Modals;
using Vendstor.Forms.Products;
using Vendstor.Models.Products;

using Vendstor.Backend;
using Vendstor.Backend.Data;
using Vendstor.Backend.Utils;
using Vendstor.Backend.Constants;
using Vendstor.Backend.Database.Queries;

namespace Vendstor.UserControls.Dashboard.Products
{
    public partial class Brands : UserControl
    {
        #region Variables
        
        Backend.Objects.User user = new Backend.Objects.User();
        Backend.Objects.Store store = new Backend.Objects.Store();
        List<object> brands = new List<object>();

        Color SoftColor;
        //Size NormalSize = new Size(1128, 597);

        #endregion

        #region Constructors

        public Brands()
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

        private void BtnAddBrand_Click(object sender, EventArgs e)
        {
            //Add Blur 
            Blur blur = new Blur(this.ParentForm, UIConstants.FormBlurOpacity);
            blur.Show();

            Brand brand = new Brand
            {
                OnCreate = OnCreateBrand,
                Task = Enums.Task.Create,
                TopMost = true
            };

            //Update
            var dialogResult = brand.ShowWithResult();
            if (dialogResult == Enums.ActionDialog.Created)
            {
                //Delete To Avoid Duplicate
                //BrandsGrid.Controls.Clear();
                //GetBrands();
            }

            //Remove Blur 
            blur.Close();
        }

        private void BrandsGrid_DoubleClick(object sender, EventArgs e)
        {
            // Update
            GetBrands();
        }

        #endregion

        #region  Methods

        void Initialize()
        {
            // Get 
            user = Util.Data.GetUser();
            store = Util.Data.GetStore();

            // Get 
            GetBrands();

            Translate();
        }

        void GetBrands()
        {
            if (QueryController.User.IsIdValid(user.Id))
            {
                var response = QueryController.Products.Brand.GetBrands();
                if (response.StatusCode == 200)
                {
                    BrandsGrid.Controls.Clear();

                    // Render EmptyData if Count == 0 and show no results if searchQueryType is different from none
                    RenderEmptyData(response.DataArray.Count == 0);

                    brands = response.DataArray;
                    foreach (Backend.Objects.ProductBrand brand in response.DataArray)
                        AddBrandToGrid(brand);
                }
                // No Content
                else if (response.StatusCode == 204)
                    RenderEmptyData(response.DataArray.Count == 0);
            }
            else
            {
                Alert.Show("User Account Error", "Please login again, an error occured", Alert.AlertType.Error, isMini: false);
            }
        }

        void AddBrandToGrid(Backend.Objects.ProductBrand brand)
        {
            //Fill Grid [ BrandsGrid ] With Rows
            ProductBrandModel brandModel = new ProductBrandModel
            {
                OnDelete = OnDeleteBrand,
                Brand = brand,
                User = user,
            };
            //Add To Grid
            BrandsGrid.Controls.Add(brandModel);
        }

        public void OnCreateBrand(object sender, EventArgs e)
        {
            var newBrand = (Backend.Objects.ProductBrand)sender;
            AddBrandToGrid(newBrand);

            // Update Controls 
            RenderEmptyData(false);
        }

        public void OnDeleteBrand(object sender, EventArgs e)
        {
            BrandsGrid.Controls.Remove((ProductBrandModel)sender);
            // Update Controls 
            if (BrandsGrid.Controls.Count == 0)
                RenderEmptyData();
        }

        void InitializeUI()
        {
            SoftColor = UserInterface.SoftColor;
            btnAddBrand.Activecolor = btnAddBrand_Alert.Activecolor = btnAddBrand_Alert.BackColor = btnAddBrand_Alert.Normalcolor =
                btnAddBrand.BackColor = btnAddBrand.Normalcolor = SoftColor;
            btnAddBrand.OnHovercolor = btnAddBrand_Alert.OnHovercolor = Color.FromArgb(200, SoftColor);

            btnAddBrand_Alert.Size = btnAddBrand.Size = new Size((Properties.Settings.Default.SoftLocale.Contains("de"))
                ? 233 : 147, btnAddBrand.Size.Height);
        }

        void RenderEmptyData(bool isEmpty = true)
        {
            cardEmptyData.Visible = isEmpty;
            BrandsGrid.Visible = !isEmpty;
        }
       
        public void ResizeControl()
        {
            UserControlUtil.Func.ResizeControl(BrandsGrid, this.Size, 3, 100 + 70, 150 + 70);
            // 356
            if (this.Size.Height < 600)
                BrandsGrid.Size = new Size(1106, 356);
        }

        #endregion

        #region Translate

        void Translate()
        {
            Translation.ForceUpdate();
            if (Translation.IsPossible())
            {
                //Translate Strings 
                foreach(Control control in pnlHeader.Controls)
                    Translation.TranslateControl(control);

                foreach (Control control in pnlGridTitle.Controls)
                    if(control is Label)
                        Translation.TranslateControl(control);

                //Text
                lblSorry_Alert.Text = Translation.Translate(lblSorry_Alert.Text);
                lblNoBrands_Alert.Text = Translation.Translate(lblNoBrands_Alert.Text);
                btnAddBrand_Alert.Text = Translation.Translate(btnAddBrand_Alert.Text);
                ReCenterCardControls();
            }
        }

        void ReCenterCardControls()
        {
            // ReCenter
            Util.Methods.AlignToParent(btnAddBrand_Alert, cardEmptyData, (int)Util.Methods.AlignIndex.HCenter);
            Util.Methods.AlignToParent(lblSorry_Alert, cardEmptyData, (int)Util.Methods.AlignIndex.HCenter);
            Util.Methods.AlignToParent(lblNoBrands_Alert, cardEmptyData, (int)Util.Methods.AlignIndex.HCenter);
        }

        #endregion

        #region OnClose

        #endregion
    }
}
