using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;

//Vendstor
using Vendstor.Forms;
using Vendstor.Modals;
using Vendstor.Forms.Customers;
using Vendstor.Models.Customers;

using Vendstor.Backend;
using Vendstor.Backend.Data;
using Vendstor.Backend.Utils;
using Vendstor.Backend.Constants;
using Vendstor.Backend.Database.Queries;

namespace Vendstor.UserControls.Dashboard
{
    public partial class Customers : UserControl
    {
        #region Variables     

        Backend.Objects.User User = new Backend.Objects.User();
        Backend.Objects.Store Store = new Backend.Objects.Store();
        Backend.Objects.CustomerSearchQuery SearchQuery = new Backend.Objects.CustomerSearchQuery();

        List<object> customers = new List<object>();
        Color SoftColor;

        #endregion

        #region Constructors

        public Customers()
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

        private void BtnGroups_Click(object sender, EventArgs e)
        {
            Blur blur = new Blur(this.ParentForm, UIConstants.FormBlurOpacity);
            blur.Show();

            CustomerGroups customerGroups = new CustomerGroups
            {
                TopMost = true
            };
            customerGroups.ShowDialog();

            blur.Close();
        }

        private void BtnAddCustomer_Click(object sender, EventArgs e)
        {
            if (!Util.Func.IsUserAllowed(User, Util.PermissionAlertType.Message, this.ParentForm))
                return;

            Blur blur = new Blur(this.ParentForm, UIConstants.FormBlurOpacity);
            blur.Show();

            Forms.Customers.Customer customerForm = new Forms.Customers.Customer
            {
                OnCreate = OnCreateCustomer,
                Task = Enums.Task.Create,
                TopMost = true
            };

            var dialogResult = customerForm.ShowWithResult();
            if (dialogResult == Enums.ActionDialog.Created)
            {
                //Delete To Avoid Duplicate
                CustomersGrid.Controls.Clear();
                GetCustomers();
            }

            blur.Close();
        }
        
        private void BtnFilter_Click(object sender, EventArgs e)
        {
            SearchQuery.Query = txtFilter.Text;
            SetQueryType();

            // Set Group
            if (dpdCustomerGroup.selectedIndex == 0)
                SearchQuery.GroupId = "";
            else
                SearchQuery.GroupId = ProductSupplier.GetIdByName(dpdCustomerGroup.selectedValue);

            //Search
            GetCustomers();
        }

        private void DpdCustomerGroup_onItemSelected(object sender, EventArgs e)
        {
            //IsTextSearchQuery = false;
        }

        #endregion

        #region  Methods

        public void Initialize()
        {
            User = Util.Data.GetUser();
            Store = Util.Data.GetStore();

            GetCustomers();

            // Get Groups
            var response = QueryController.Customers.Group.GetGroups();
            if (response.StatusCode == 200)
                foreach (Backend.Objects.CustomerGroup group in response.DataArray)
                    dpdCustomerGroup.AddItem(group.Name);

            Translate();
        }

        void GetCustomers()
        {
            if (QueryController.User.IsIdValid(User.Id))
            {
                var response = QueryController.Customers.Customer.GetCustomers(SearchQuery);
                if (response.StatusCode == 200)
                {
                    CustomersGrid.Controls.Clear();

                    // Render EmptyData if Count == 0 and show no results if searchQueryType is different from none
                    RenderEmptyData(response.DataArray.Count == 0, (SearchQuery.Type != Enums.SearchQueryType.None));

                    customers = response.DataArray;
                    foreach (Backend.Objects.Customer customer in response.DataArray)
                        AddCustomerToGrid(customer);
                }
                else if (response.StatusCode == 204)
                    RenderEmptyData(response.DataArray.Count == 0);
            }
            else
            {
                Alert.Show("User Account Error", "Please login again, an error occured", Alert.AlertType.Error, isMini: false);
            }
        }

        void AddCustomerToGrid(Backend.Objects.Customer customer)
        {
            //Fill Grid [ CustomersGrid ] With Rows
            CustomerModel customerModel = new CustomerModel
            {
                OnDelete = OnDeleteCustomer,
                Customer = customer,
                Currency = Store.CurrencySign,
                User = User,
            };
            //Add To Grid
            CustomersGrid.Controls.Add(customerModel);
        }

        public void OnCreateCustomer(object sender, EventArgs e)
        {
            var newCustomer = (Backend.Objects.Customer)sender;
            AddCustomerToGrid(newCustomer);

            // Update Controls 
            RenderEmptyData(false);
        }

        public void OnDeleteCustomer(object sender, EventArgs e)
        {
            CustomersGrid.Controls.Remove((CustomerModel)sender);
            // Update Controls 
            if (CustomersGrid.Controls.Count == 0)
                RenderEmptyData();
        }

        void SetQueryType()
        {
            if (string.IsNullOrEmpty(txtFilter.Text) && dpdCustomerGroup.selectedIndex == 0)
                SearchQuery.Type = Enums.SearchQueryType.None;

            else if (!string.IsNullOrEmpty(txtFilter.Text))
                SearchQuery.Type = Enums.SearchQueryType.Query;

            else if (dpdCustomerGroup.selectedIndex != 0)
                SearchQuery.Type = Enums.SearchQueryType.Id;

            else
                SearchQuery.Type = Enums.SearchQueryType.None;
        }

        void InitializeUI()
        {
            SoftColor = UserInterface.SoftColor;

            btnAddCustomer.Activecolor = btnAddCustomer.Normalcolor = btnAddCustomer.BackColor = btnGroups.Activecolor = btnGroups.Normalcolor = btnGroups.BackColor =
                btnFilter.Activecolor = btnAddCustomer_Alert.Activecolor = btnAddCustomer_Alert.Normalcolor = btnAddCustomer_Alert.BackColor = btnFilter.Normalcolor = btnFilter.BackColor = SoftColor;
            txtFilter.BorderColorFocused = txtFilter.BorderColorIdle = SoftColor;
            btnAddCustomer.OnHovercolor = btnAddCustomer_Alert.OnHovercolor = btnFilter.OnHovercolor = btnGroups.OnHovercolor = Color.FromArgb(200, SoftColor);
        }

        void RenderEmptyData(bool isEmpty = true, bool noResults = false)
        {
            cardEmptyData.Visible = isEmpty;
            CustomersGrid.Visible = !isEmpty;

            if (noResults)
            {
                if (Translation.IsPossible())
                    lblNoCustomers_Alert.Text = Translation.Translate("No results found for query ") + txtFilter.Text;
                else
                    lblNoCustomers_Alert.Text = "No results found for query " + txtFilter.Text;
            }

            //Location
            Util.Methods.AlignToParent(lblSorry_Alert, cardEmptyData, (int)Util.Methods.AlignIndex.HCenter);
            Util.Methods.AlignToParent(lblNoCustomers_Alert, cardEmptyData, (int)Util.Methods.AlignIndex.HCenter);
        }

        public void ResizeControl()
        {
            UserControlUtil.Func.ResizeControl(CustomersGrid, this.Size, extraHeight: 60);
            UserControlUtil.Func.ResizeControl(this);
        }
        #endregion

        #region Translate 

        void Translate()
        {
            Translation.ForceUpdate();

            if (Translation.IsPossible())
            {
                //Translate Strings
                foreach (Control control in pnlHeader.Controls)
                    Translation.TranslateControl(control);

                foreach (Control control in pnlGridHeader.Controls)
                    if (control is Label)
                        Translation.TranslateControl(control);

                foreach (Control control in cardEmptyData.Controls)
                    if (control is Label || control is Bunifu.Framework.UI.BunifuFlatButton)
                        Translation.TranslateControl(control);

                Translation.TranslateControl(text_SearchHint);
                Translation.TranslateControl(text_CustomerGroup);
                Translation.TranslateControl(btnFilter);

                UserControlUtil.Func.MoveControlTo(btnAddCustomer, new Point(744, 23), new Size(172, 40),
                    new Point(717, 23), new Size(199, 40));
            }
        }
        #endregion

        #region OnClose

        #endregion      
    }
}
