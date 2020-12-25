using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;

//Vendstor
using Vendstor.Forms;
using Vendstor.Modals;
using Vendstor.Models.Products;

using Vendstor.Backend;
using Vendstor.Backend.Data;
using Vendstor.Backend.Utils;
using Vendstor.Backend.Constants;
using Vendstor.Backend.Database.Queries;

namespace Vendstor.UserControls.Dashboard.Products
{
    public partial class Types : UserControl
    {
        #region Variables

        Backend.Objects.User user = new Backend.Objects.User();
        Backend.Objects.Store store = new Backend.Objects.Store();
        List<object> types = new List<object>();

        Color SoftColor;
        //Size NormalSize = new Size(1128, 597);

        #endregion

        #region Constructors

        public Types()
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
            ResizeControl();
        }

        #endregion

        #region Control - Event Handler

        private void BtnAddType_Click(object sender, EventArgs e)
        {
            ///Add Blur 
            Blur blur = new Blur(this.ParentForm, UIConstants.FormBlurOpacity);
            blur.Show();

            Forms.Products.Type type = new Forms.Products.Type
            {
                OnCreate = OnCreateType,
                Task = Enums.Task.Create,
                TopMost = true
            };

            type.ShowWithResult();

            //Remove Blur 
            blur.Close();
        }


        private void TypesGrid_DoubleClick(object sender, EventArgs e)
        {
            // Update
            GetTypes();
        }

        #endregion

        #region  Methods

        void Initialize()
        {
            // Get 
            user = Util.Data.GetUser();
            store = Util.Data.GetStore();

            // Get 
            GetTypes();

            Translate();
        }

        void GetTypes()
        {
            if (QueryController.User.IsIdValid(user.Id))
            {
                var response = QueryController.Products.Type.GetTypes();
                if (response.StatusCode == 200)
                {
                    TypesGrid.Controls.Clear();

                    // Render EmptyData if Count == 0 and show no results if searchQueryType is different from none
                    RenderEmptyData(response.DataArray.Count == 0);

                    types = response.DataArray;
                    foreach (Backend.Objects.ProductType type in response.DataArray)
                        AddTypeToGrid(type);
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

        void AddTypeToGrid(Backend.Objects.ProductType type)
        {
            //Fill Grid [ BrandsGrid ] With Rows
            ProductTypeModel typeModel = new ProductTypeModel
            {
                OnDelete = OnDeleteType,
                Type = type,
                User = user,
            };
            //Add To Grid
            TypesGrid.Controls.Add(typeModel);
        }

        public void OnCreateType(object sender, EventArgs e)
        {
            var newType = (Backend.Objects.ProductType)sender;
            AddTypeToGrid(newType);

            // Update Controls 
            RenderEmptyData(false);
        }

        public void OnDeleteType(object sender, EventArgs e)
        {
            TypesGrid.Controls.Remove((ProductTypeModel)sender);
            // Update Controls 
            if (TypesGrid.Controls.Count == 0)
                RenderEmptyData();
        }

        void InitializeUI()
        {
            SoftColor = UserInterface.SoftColor;
            //Change Color
            btnAddType.Activecolor = btnAddType.BackColor = btnAddType.Normalcolor = btnAddType_Alert.Activecolor =
                btnAddType_Alert.BackColor = btnAddType_Alert.Normalcolor = SoftColor;
            //HoverColor
            btnAddType.OnHovercolor = btnAddType_Alert.OnHovercolor = Color.FromArgb(200, SoftColor);
            //Size
            btnAddType_Alert.Size = btnAddType.Size = new Size((Properties.Settings.Default.SoftLocale.Contains("de"))
                ? 233 : 147, btnAddType.Size.Height);
        }

        void RenderEmptyData(bool isEmpty = true)
        {
            cardEmptyData.Visible = isEmpty;
            TypesGrid.Visible = !isEmpty;
        }

        public void ResizeControl()
        {
            UserControlUtil.Func.ResizeControl(TypesGrid, this.Size, 3, 100 + 70, 150 + 70);
            // 356
            if (this.Size.Height < 600)
                TypesGrid.Size = new Size(1106, 356);
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

                foreach (Control control in pnlGridTitle.Controls)
                    if (control is Label)
                        Translation.TranslateControl(control);

                lblSorry_Alert.Text = Translation.Translate(lblSorry_Alert.Text);
                lblNoTypes_Alert.Text = Translation.Translate(lblNoTypes_Alert.Text);
                btnAddType_Alert.Text = Translation.Translate(btnAddType_Alert.Text);
                ReCenterCardControls();
            }
        }
        void ReCenterCardControls()
        {
            // ReCenter
            Util.Methods.AlignToParent(btnAddType_Alert, cardEmptyData, (int)Util.Methods.AlignIndex.HCenter);
            Util.Methods.AlignToParent(lblSorry_Alert, cardEmptyData, (int)Util.Methods.AlignIndex.HCenter);
            Util.Methods.AlignToParent(lblNoTypes_Alert, cardEmptyData, (int)Util.Methods.AlignIndex.HCenter);
        }

        #endregion

        #region OnClose

        #endregion
    }
}
