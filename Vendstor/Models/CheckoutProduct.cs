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
using Vendstor.Models;


namespace Vendstor.Models
{
    public partial class CheckoutProduct : UserControl
    {
        #region Variables

        //Props        
        public string ProductToken { get; set; }
        public int ProductID { get; set; }
        public new  string ProductName { get; set; }
        public double ProductUnitPrice { get; set; }
        public double ProductTotalPrice { get; set; }
        public double ProductQuantity { get; set; }
        public double ProductDiscountPercentage { get; set; }
        public string ProductImagePath { get; set; }
        public string ProductTag { get; set; }
        public string ProductNote { get; set; }

        public bool isDiscount { get; set; }
        public bool isExpand = false;
        public string Currency = "€";

        string FormName = "Sell";

        //Class
        UserInterface UI = new UserInterface();
        Library Lib = new Library();

        //Color
        Color SoftColor;
        Color ColorGray = Color.FromArgb(209, 212, 221);
        Color ImageColor = Color.DimGray;

        //Color AltSoftColor;

        //Image
        Image imgExpand = Properties.Resources.expand_checkout_w;
        Image imgCollapse = Properties.Resources.collapse_arrow_w;

        //String
        string StandardText = "Type to add note...";
        #endregion

        #region InitializeComponent

        public CheckoutProduct()
        {
            InitializeComponent();

            //Void
            InitializeUI();
        }

        #endregion

        #region UserControl Load


        private void ucCheckout_Product_Load(object sender, EventArgs e)
        {
            // Calculate Discount, Display Props
            BackEnd();           
        }

        #endregion

        #region UserControl - Event Handler

        private void ucCheckout_Product_SizeChanged(object sender, EventArgs e)
        {
            

        }

        private void ucCheckout_Product_Click(object sender, EventArgs e)
        {
            //Expand or Collapse UC
            ExpandCollapseControl();
        }


        #endregion

        #region Control - Event Handler


        private void imgbtn_ResizeControl_Click(object sender, EventArgs e)
        {
            ExpandCollapseControl();
        }

        private void imgbtn_Delete_Click(object sender, EventArgs e)
        {
            //Void
            RemoveControl();
        }


        private void imgbtn_AddQuantity_Click(object sender, EventArgs e)
        {
            //Decrease Quantity , Update
            ProductQuantity++;
            Update();
        }

        private void imgbtn_ReduceQuantity_Click(object sender, EventArgs e)
        {
            //Increase Quantity , Update
            ProductQuantity--;

            if (ProductQuantity == 0)
                //Remove Product From List => Quantity <= 0
                RemoveControl();
            else
                Update();
            
        }

        private void txt_DiscountPtg_KeyDown(object sender, KeyEventArgs e)
        {
            //Update if KeyPress is Enter
            if (e.KeyCode == Keys.Enter && txt_DiscountPtg.Text != "")
            {
                ProductDiscountPercentage = Convert.ToDouble(txt_DiscountPtg.Text); //Change VAR With User Input
                Update();               
            }
        }
        private void txt_Note_MouseEnter(object sender, EventArgs e)
        {
            if (txt_Note.Text == StandardText )
                txt_Note.Text = "";
        }
        private void txt_Note_MouseLeave(object sender, EventArgs e)
        {
            if (txt_Note.Text.Length <= 1)
                txt_Note.Text = StandardText;
        }

        private void txt_Note_KeyDown(object sender, KeyEventArgs e)
        {
            // Update if KeyPress is Enter
            if (e.KeyCode == Keys.Enter)
            {
                ProductNote = (txt_Note.Text.Length > 1) ? txt_Note.Text : ProductNote;
            }
        }
        private void lbl_ShowProdDetails_Click(object sender, EventArgs e)
        {

        }
       

        #endregion

        #region  Void - ...

        public void InitializeUI()
        {
            //Get Color from Class According Properties.Settings            
            SoftColor = UI.SoftColor();

            
            //Color Image
            imgExpand = Lib.ColorImage(imgExpand, ImageColor);
            imgCollapse = Lib.ColorImage(imgCollapse, ImageColor);
            imgbtn_Delete.Image = Lib.ColorImage(imgbtn_Delete.Image, ImageColor);
            imgbtn_AddQuantity.Image = Lib.ColorImage(imgbtn_AddQuantity.Image, ImageColor);
            imgbtn_ReduceQuantity.Image = Lib.ColorImage(imgbtn_ReduceQuantity.Image, ImageColor);

            //Color Controls
            Indicator.BackColor = card_ProductQuantity.BackColor = card_ProductQuantity.color = lbl_ShowProdDetails.ForeColor = SoftColor;
            txt_Note.BorderColorFocused = txt_Note.BorderColorMouseHover = txt_DiscountPtg.BorderColorFocused = txt_DiscountPtg.BorderColorMouseHover = SoftColor;

            //Change Size
            this.Size = new Size(this.Size.Width, 75);

            //Image => Control
            imgbtn_ResizeControl.Image = imgExpand;

        }

        void BackEnd(bool isOwnerControl = false)
        {
            lbl_DiscountPrice.Visible = (ProductDiscountPercentage == 0) ? false : true;

            //Fill Variables
            lbl_ProductName.Text = ProductName;
            lbl_ProductTag.Text = ProductTag;
            pic_ProductImage.ImageLocation = ProductImagePath;

            lbl_ProductQuantity.Text = lbl_ProductQuantity_RS.Text = ProductQuantity.ToString();
            lbl_ProductPrice.Text = lbl_DiscountPrice.Text = lbl_ProductPrice_RS.Text = Currency + " " +  (ProductUnitPrice * ProductQuantity).ToString();
            txt_DiscountPtg.Text = ProductDiscountPercentage.ToString();

            double ProductAmount = (ProductUnitPrice * ProductQuantity);

            if (ProductDiscountPercentage != 0)
            {               
                lbl_DiscountPrice.Text = Currency + " " + ProductAmount.ToString();
                ProductTotalPrice = ProductAmount  - (ProductDiscountPercentage / 100  * ProductAmount);

            }
            else
            {                
                ProductTotalPrice = ProductAmount;
            }           

            //Finally Update Price & %
            txt_DiscountPtg.Text = ProductDiscountPercentage.ToString();
            lbl_ProductPrice.Text = lbl_ProductPrice_RS.Text = Currency + " " +  ProductTotalPrice.ToString();

            //Update Checkout Price
            Sell frmSell = (Sell)Application.OpenForms[FormName];

            frmSell.UpdateCheckout();

        }
        void ExpandCollapseControl()
        {
            //Expand or Collapse UC 
            isExpand = (isExpand) ? isExpand = false : isExpand = true;

            Sell frmSell = (Sell)Application.OpenForms[FormName];

            foreach (CheckoutProduct c in frmSell.flpnl_Checkout.Controls)
            {
                if (c.ProductName != this.ProductName && c.isExpand)
                {

                    c.isExpand = false;
                    c.ResizeControl();
                }
            }

            ResizeControl();
        }
        void RemoveControl()
        {
            // Delete Control From Parent Flow Layout Panel[flpnl_CheckoutList]
            Sell frmSell = (Sell)Application.OpenForms[FormName];

            frmSell.flpnl_Checkout.Controls.Remove(this);
            Update();
        }
        public new void Update()
        {
            BackEnd();
            
        }
        public void ResizeControl()
        {
            //Change Only Height 
            this.Size = (isExpand) ? new Size(this.Size.Width, 255) : new Size(this.Size.Width, 75);

            Seperator.Location = (isExpand) ? new Point(Seperator.Location.X, 246) : Seperator.Location = new Point(Seperator.Location.X, 66);
            Indicator.Visible = (isExpand) ? true : false;

            //Replace Image => To Use The Same Button for Both
            imgbtn_ResizeControl.Image = (isExpand) ? imgCollapse : imgExpand;
        }

        #endregion

        #region UserControl - Event

       
        #endregion
    }
}
