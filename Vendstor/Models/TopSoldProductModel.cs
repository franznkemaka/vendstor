using System;
using System.Drawing;
using System.Windows.Forms;

//Vendstor
using Vendstor.Modals;
using Vendstor.Forms.Products;

using Vendstor.Backend;
using Vendstor.Backend.Utils;
using Vendstor.Backend.Constants;
using Vendstor.Backend.Database.Queries;

namespace Vendstor.Models
{
    public partial class TopSoldProductModel : UserControl
    {
        #region Variables

        public Backend.Objects.Product Product { get; set; }
        public string Currency { get; set; }
        public int MedalIndex { get; set; }

        Color SoftColor;

        #endregion

        #region Constructors

        public TopSoldProductModel()
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

        #region  Methods

        void Initialize()
        {
            //Get 
            if (Product is object)
            {
                lblProductName.Text = Product.Name;
                SetProductComment(Product.Stock);

                lblProductPrice.Text = string.Format("{0} {1}", Currency, StringUtil.ToRoundedString(Product.RetailPrice));
                // If is from Search Item then Get Brand .. Since the couldn't be fetched in another query
                if (Product.IsSearchItem)                
                    Product.Image = Backend.Database.Queries.Product.GetImage(Product.ImageBlobId, Product.Name, Product.Color);
                
                imgProductImage.Image = Product.Image;

                if (MedalIndex == 1)
                    imgMedal.Image = Properties.Resources.medal_first;
                else if (MedalIndex == 2)
                    imgMedal.Image = Properties.Resources.medal_second;
                else
                    imgMedal.Image = Properties.Resources.medal_third;
            }
            else
                Alert.Show("Error", $"Something wrong occured", Alert.AlertType.Error);

            Translate();
        }

        void SetProductComment(decimal stock)
        {
            // Green : 0, 206, 104
            // Yelllow : 255, 175, 0
            // Tomato 
            if (stock > ReportConstants.OnStockValue)
            {
                lblComment.ForeColor = Color.FromArgb(0, 206, 104);
                lblComment.Text = "On Stock";
            }
            else if (stock <= ReportConstants.OnStockValue && Product.Stock > 0)
            {
                lblComment.Text = "Low Stock";
                lblComment.ForeColor = Color.FromArgb(255, 175, 0);
            }
            else
            {
                lblComment.Text = "No Stock";
                lblComment.ForeColor = Color.Tomato;
            }
        }

        void InitializeUI()
        {
            SoftColor = UserInterface.SoftColor;
        }

        #endregion

        #region Translate 

        void Translate()
        {
            if (Translation.IsPossible())
                Translation.TranslateControl(lblComment);
        }

        #endregion

        #region OnClose

        #endregion
    }
}
