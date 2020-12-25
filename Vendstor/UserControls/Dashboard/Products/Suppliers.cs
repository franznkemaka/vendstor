using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;

//Vendstor
using Vendstor.Forms;
using Vendstor.Modals;
using Vendstor.Models.Products;
using Vendstor.Forms.Products;

using Vendstor.Backend;
using Vendstor.Backend.Data;
using Vendstor.Backend.Utils;
using Vendstor.Backend.Constants;
using Vendstor.Backend.Database.Queries;

namespace Vendstor.UserControls.Dashboard.Products
{
    public partial class Suppliers : UserControl
    {
        #region Variables

        Backend.Objects.User user = new Backend.Objects.User();
        Backend.Objects.Store store = new Backend.Objects.Store();
        List<object> suppliers = new List<object>();

        Color SoftColor;

        //Size NormalSize = new Size(1128, 597);
        #endregion

        #region Constructors

        public Suppliers()
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

        private void BtnAddSupplier_Click(object sender, EventArgs e)
        {
            if (!Util.Func.IsUserAllowed(user, Util.PermissionAlertType.Message, this.ParentForm))
                return;

            ///Add Blur 
            Blur blur = new Blur(this.ParentForm, UIConstants.FormBlurOpacity);
            blur.Show();

            Supplier supplier = new Supplier
            {
                OnCreate = OnCreateSupplier,
                Task = Enums.Task.Create,
                TopMost = true
            };

            // Update
            var dialogResult = supplier.ShowWithResult();

            // Remove Blur 
            blur.Close();
        }

        private void SuppliersGrid_DoubleClick(object sender, EventArgs e)
        {
            // Update
            GetSuppliers();
        }

        #endregion

        #region  Methods
        
        void Initialize()
        {
            // Get 
            user = Util.Data.GetUser();
            store = Util.Data.GetStore();

            // Get 
            GetSuppliers();

            Translate();
        }

        void GetSuppliers()
        {
            if (QueryController.User.IsIdValid(user.Id))
            {
                var response = QueryController.Products.Supplier.GetSuppliers();
                if (response.StatusCode == 200)
                {
                    SuppliersGrid.Controls.Clear();

                    // Render EmptyData if Count == 0 and show no results if searchQueryType is different from none
                    RenderEmptyData(response.DataArray.Count == 0);

                    suppliers = response.DataArray;
                    foreach (Backend.Objects.ProductSupplier supplier in response.DataArray)
                        AddSupplierToGrid(supplier);
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

        void AddSupplierToGrid(Backend.Objects.ProductSupplier supplier)
        {
            //Fill Grid [ SuppliersGrid ] With Rows
            ProductSupplierModel supplierModel = new ProductSupplierModel
            {
                OnDelete = OnDeleteSupplier,
                Supplier = supplier,
                User = user,
            };
            //Add To Grid
            SuppliersGrid.Controls.Add(supplierModel);
        }

        public void OnCreateSupplier(object sender, EventArgs e)
        {
            var newSupplier = (Backend.Objects.ProductSupplier)sender;
            AddSupplierToGrid(newSupplier);

            // Update Controls 
            RenderEmptyData(false);
        }

        public void OnDeleteSupplier(object sender, EventArgs e)
        {
            SuppliersGrid.Controls.Remove((ProductSupplierModel)sender);
            // Update Controls 
            if (SuppliersGrid.Controls.Count == 0)
                RenderEmptyData();
        }

        void InitializeUI()
        {
            SoftColor = UserInterface.SoftColor;
            btnAddSupplier.Activecolor = btnAddSupplier.BackColor = btnAddSupplier.Normalcolor =  btnAddSupplier_Alert.BackColor = btnAddSupplier_Alert.Activecolor = btnAddSupplier_Alert.Normalcolor = SoftColor;
            btnAddSupplier.OnHovercolor = btnAddSupplier_Alert.OnHovercolor =  Color.FromArgb(200, SoftColor);
        }

        void RenderEmptyData(bool isEmpty = true)
        {
            cardEmptyData.Visible = isEmpty;
            SuppliersGrid.Visible = !isEmpty;
        }

        public void ResizeControl()
        {
            UserControlUtil.Func.ResizeControl(SuppliersGrid, this.Size, 3, 100 + 70, 150 + 70);
            // 356
            if (this.Size.Height < 600)
                SuppliersGrid.Size = new Size(1106, 356);
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

                lblSorry_Alert.Text = Translation.Translate(lblSorry_Alert.Text);
                lblNoSuppliers_Alert.Text = Translation.Translate(lblNoSuppliers_Alert.Text);
                btnAddSupplier_Alert.Text = Translation.Translate(btnAddSupplier_Alert.Text);
                ReCenterCardControls();
            }
        }
        void ReCenterCardControls()
        {
            // ReCenter
            Util.Methods.AlignToParent(btnAddSupplier_Alert, cardEmptyData, (int)Util.Methods.AlignIndex.HCenter);
            Util.Methods.AlignToParent(lblSorry_Alert, cardEmptyData, (int)Util.Methods.AlignIndex.HCenter);
            Util.Methods.AlignToParent(lblNoSuppliers_Alert, cardEmptyData, (int)Util.Methods.AlignIndex.HCenter);


            UserControlUtil.Func.MoveControlTo(btnAddSupplier, new Point(932, 8), new Size(161, 40),
              new Point(887, 8), new Size(206, 40));
        }

        #endregion
        
        #region OnClose

        #endregion
    }
}
