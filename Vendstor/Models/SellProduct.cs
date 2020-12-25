using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


//Vendstor
using Vendstor.UI;
using Vendstor.Lib;
using Vendstor.Forms;
using Vendstor.Forms.Auth;
using Vendstor.Forms.PointOfSale;

using Vendstor.UserControls;
using Vendstor.UserControls.Dashboard;

namespace Vendstor.Models
{
    public partial class SellProduct : UserControl
    {

        #region Variables

        //Props

        public string ProductToken { get; set; }
        public int ProductID { get; set; }
        public new string ProductName { get; set; }
        public double ProductUnitPrice { get; set; }
        public string ProductImagePath { get; set; }
        public double ProductDiscountPercentage { get; set; }
        public string ProductUnit { get; set; }
        public string ProductColorHEX { get; set; }

        public string Currency = "€";

        string FormName = "Sell";


        //Class
        UserInterface UI = new UserInterface();
        Library Lib = new Library();

        //Color
        Color SoftColor;
        Color ColorGray = Color.FromArgb(209, 212, 221);
        Color ProductColor;
        //Color AltSoftColor;



        #endregion

        #region InitializeComponent

        public SellProduct()
        {
            InitializeComponent();

            //Void
            InitializeUI();          
        }

        #endregion

        #region UserControl Load


        private void SellProduct_Load(object sender, EventArgs e)
        {
            BackEnd();
            this.Anchor = AnchorStyles.None;
            Sell ParentForm = (Sell)Application.OpenForms["Sell"];
          
            int CountrolCount = ParentForm.flpnl_Products.Controls.Count;     

            /*
            if (CountrolCount <= 1)
                this.Margin = new Padding(10, 5, 5, 5);
            else
                this.Margin = new Padding(5, 5, 5, 5);
                */
            this.Margin = new Padding(6, 5, 4, 5);
            //this.Margin = new Padding(5, 5, 5, 5);
        }

        #endregion

        #region Control - Event Handler
        
        private void Control_Click(object sender, EventArgs e)
        {
            //Add Product On Click
            AddProduct();
            
        }

        #endregion

        #region  Void - ...

        public void InitializeUI()
        {
            //Get Color from Class According Properties.Settings            
            SoftColor = UI.SoftColor();
        }
     
        public void BackEnd()
        {
            // HEX => Color 
            ProductColor = ColorTranslator.FromHtml(ProductColorHEX);

            lbl_ProductPrice.Font = (ProductDiscountPercentage != 0) ?  new Font(lbl_ProductPrice.Font, FontStyle.Strikeout) : new Font(lbl_ProductPrice.Font, FontStyle.Regular);
            pic_Discount.Visible = (ProductDiscountPercentage != 0) ? true : false;

            ResizeProductLabel();

            //Fill Variables          
            lbl_ProductName.Text = ProductName;
            lbl_ProductPrice.Text = $"{ ProductUnitPrice } { Currency }";
            pic_ProductImg.ImageLocation = ProductImagePath;
            
            //Refresh UI
            lbl_ProductName.TextAlign = ContentAlignment.MiddleCenter;
        

            //Set Color
            Indicator.BackColor = card_PriceBG.BackColor = card_PriceBG.color = ProductColor;
        }
        public int XSize( double n)
        {
            int i = (int)Math.Abs(n);
            if (i == 0) return 0;
            return i.ToString().Length;
        }

        public void ResizeProductLabel()
        {
            var Length = ProductUnitPrice.ToString().Length;
            Size cardSize = card_PriceBG.Size;
            Point cardLocation = card_PriceBG.Location;

            if(Length >= 3)
            {
                //LongLabel
                cardSize = new Size(77, 29);
                cardLocation = new Point(99, 10);
            }
            else if(Length == 2)
            {
                //ShortLabel
                cardSize = new Size(60, 29);
                cardLocation = new Point(116, 10);
            }
            else if (Length < 2)
            {
                //NormalLabel
                cardSize = new Size(37, 29);
                cardLocation = new Point(139, 10);
            }

            card_PriceBG.Size = cardSize;
            card_PriceBG.Location = cardLocation;           
        }

        public void AddProduct()
        {
           Sell frmSell = (Sell)Application.OpenForms[FormName];
          
            if (frmSell.flpnl_Checkout.Controls.Count == 0) //Add A New Product if it Is Empty
                AddProductToCheckout();
            else
            {
                bool NotExist = true;

                //Select All Product( UControls) In Checkout ( FLPanel)
                foreach (CheckoutProduct CheckoutProd in frmSell.flpnl_Checkout.Controls)
                {
                    //Compare FLPanel Product Name With New one 
                    if (CheckoutProd.ProductName == ProductName)
                    {
                        //Update Quantity To Avoid Adding The Same Product Twice

                        NotExist = false; //It's Exist

                        var CurrentQuantity = CheckoutProd.ProductQuantity + 1; //Increment With 1; Since 1 Click = 1 Unit [Kg, Pct]
                        CheckoutProd.ProductQuantity = CurrentQuantity;

                        //Ask Control To Update i.e Update Variables With New Ones[Quantity]
                        CheckoutProd.Update();
                    }
                }


                if (NotExist) //Add As Normal Control                    
                    AddProductToCheckout();
            }
            
        }
        void AddProductToCheckout()

        {
            Sell frmSell = (Sell)Application.OpenForms[FormName];

            //Add A New Product, => Pass in Props To Avoid Requesting The DB;
            CheckoutProduct CheckoutProd = new CheckoutProduct();

            CheckoutProd.ProductName = ProductName;
            CheckoutProd.ProductUnitPrice = ProductUnitPrice;
            CheckoutProd.ProductQuantity = 1; // Increment With 1; Since 1 Click = 1 Unit [Kg, Pct]
            CheckoutProd.ProductDiscountPercentage = ProductDiscountPercentage;
            CheckoutProd.ProductTag = "Demo ";
            CheckoutProd.ProductImagePath = this.pic_ProductImg.ImageLocation;

            //Add Control
            frmSell.flpnl_Checkout.Controls.Add(CheckoutProd);

            //Update Checkout  Variables [ Total ] ...
            frmSell.UpdateCheckout();
        }

        #endregion

        #region UserControl - Event

        #endregion


    }
}
