using System;
using System.Drawing;
using System.Windows.Forms;

//Vendstor
using Vendstor.Modals;
using Vendstor.Forms.Products;
using Vendstor.Backend.Database.Queries;

namespace Vendstor.Models.Products
{
    public partial class ProductItemModel : UserControl
    {
        #region Variables

        public Backend.Objects.Product Product { get; set; }
        public Backend.Objects.User User { get; set; }
        public Backend.Objects.Store Store { get; set; }

        public EventHandler OnAdd { get; set; }
        public EventHandler OnDelete { get; set; }
        public bool CanDelete = false;
        public bool IsSearchItem = false;

        //Color SoftColor;

        #endregion

        #region Constructors

        public ProductItemModel()
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
            try
            {
                // Emit Parent to Add
                this.OnAdd(Product, null);
            }
            catch { return; }
        }
        private void BtnDelete_Click(object sender, EventArgs e)
        {
            this.OnDelete(this, null);
        }

        #endregion

        #region  Methods

        void Initialize()
        {
            btnDelete.Visible = CanDelete;
            //Get 
            if (Product is object && User is object && Store is object)
            {
                lblProductName.Text = Product.Name;
                lblProductId.Text = Product.Id;
                lblPrice.Text = string.Format("{0} {1}", Store.CurrencySign, Product.RetailPrice.ToString());
                pnlProductColor.BackColor = Product.Color;     

                if (IsSearchItem)
                    Product.Image = Backend.Database.Queries.Product.GetImage(Product.ImageBlobId, Product.Name, Product.Color);
                imgProductImage.Image = Product.Image;
            }
            else
                Alert.Show("Error", $"Something wrong occured", Alert.AlertType.Error);
        }

        void InitializeUI()
        {
        }

        #endregion

        #region OnClose

        #endregion
    }
}
