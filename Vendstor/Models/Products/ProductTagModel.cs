using System;
using System.Drawing;
using System.Windows.Forms;

//Vendstor
using Vendstor.Forms;
using Vendstor.UserControls.Dashboard;
using Vendstor.Forms.Products;

using Vendstor.Backend;
using Vendstor.Backend.Utils;
using Vendstor.Backend.Database.Queries;
using Vendstor.Backend.Libraries;


namespace Vendstor.Models.Products
{
    public partial class ProductTagModel : UserControl
    {
        #region Variables

        //Props       
        public string TagToken { get; set; }
        public new string Tag { get; set; }

        //Class
        
        
        
        
        
        

        //Color
        Color SoftColor;
        Color ColorGray = Color.FromArgb(209, 212, 221);
        Color ColorDimGray = Color.FromArgb(241, 242, 246);
        Color ImageColor = Color.DimGray;

        //String
        //string StandardText = "Type to add note...";
        #endregion

        #region Constructors

        public ProductTagModel()
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
            //Edit
            this.BtnEdit_Click(null, null);
        }

        private void OnSizeChanged(object sender, EventArgs e)
        {

        }

        #endregion

        #region Control - Event Handler


        private void BtnEdit_Click(object sender, EventArgs e)
        {
            // => EditDiscount => Discounts => Update
            //Add Blur
            Blur blur = new Blur(this.ParentForm, 0.60);
            blur.Show();

            //Edit Tag
            Tag EditTag = new Tag();

            //Props
            EditTag.TagToken = this.TagToken;           
            EditTag.Task = "Edit";

            EditTag.TopMost = true;
            EditTag.ShowDialog();

            //Remove Blur
            blur.Close();

            //Update Data With New Changes
            this.Initialize();
        }

        private void BtnViewProducts_Click(object sender, EventArgs e)
        {
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            // Ask To Close => Delete => Close
        }

        #endregion

        #region  Methods

        public void InitializeUI()
        {
            // Get Color from Class According Properties.Settings
            SoftColor = UserInterface.SoftColor;

            //Change Color
            btnViewProducts.BackColor = btnViewProducts.Activecolor = btnViewProducts.Normalcolor = btnEdit.BackColor = btnEdit.Activecolor =
               btnEdit.Normalcolor = btnDelete.BackColor = btnDelete.Activecolor = btnDelete.Normalcolor = SoftColor;

            //HoverColor
            btnViewProducts.OnHovercolor = btnEdit.OnHovercolor = btnDelete.OnHovercolor = Color.FromArgb(200, SoftColor);
        }

        void Initialize()
        {

        }


        #endregion

        #region OnClose


        #endregion

    }
}
