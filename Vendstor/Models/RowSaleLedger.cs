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
    public partial class RowSaleLedger : UserControl
    {
        #region Variables


        //Props       
        public string ReceiptToken { get; set; }

        public bool ExpandControl = false;

        public string Currency = "€";
        string ParentForm = "SalesLedger";


        //Class
        UserInterface UI = new UserInterface();
        Library Lib = new Library();

        //Color
        Color SoftColor;
        Color ColorGray = Color.FromArgb(209, 212, 221);
        Color ColorDimGray = Color.FromArgb(241, 242, 246);
        Color ImageColor = Color.DimGray;

        //Color AltSoftColor;

        //Image
        Image imgExpand = Properties.Resources.expand_checkout_w;
        Image imgCollapse = Properties.Resources.collapse_arrow_w;

        //String
        string StandardText = "Type to add note...";
        #endregion

        #region InitializeComponent

        public RowSaleLedger()
        {
            InitializeComponent();

            //Void
            InitializeUI();
        }

        #endregion

        #region UserControl Load

        private void RowSaleLedger_Load(object sender, EventArgs e)
        {
            BackEnd();
        }

        #endregion

        #region UserControl - Event Handler


        private void RowSaleLedger_Click(object sender, EventArgs e)
        {
            //Expand OR Collapse Control
            ExpandCollapseControl();
        }

        private void RowSaleLedger_SizeChanged(object sender, EventArgs e)
        {
          
        }

        #endregion

        #region Control - Event Handler

        private void btnReturnItems_Click(object sender, EventArgs e)
        {
            //Send Checkout Items => Sell Form With Props (Refund)

            Sell sell = new Sell();
            sell.ReturnItems = true;

            foreach (CheckoutSaleLedger checkoutSaleLedger in flpnlCheckoutProducts.Controls)
            {
                ProductCheckout pc = new ProductCheckout();

                //Pass Props From CheckoutSaleLedger => ProductCheckout Then Add On Checkout
                pc.ProductName = checkoutSaleLedger.ProductName;
                pc.ProductID = checkoutSaleLedger.ProductID;
                pc.ProductDiscountPercentage = checkoutSaleLedger.ProductDiscountPercentage;
                pc.ProductUnitPrice = checkoutSaleLedger.ProductUnitPrice;
                pc.ProductQuantity = checkoutSaleLedger.ProductQuantity;
                pc.ProductTag = checkoutSaleLedger.ProductTag;
                pc.ProductToken = checkoutSaleLedger.ProductTag;
                pc.RootForm = "SalesLedger";
                pc.ReturnItems = true;

                sell.flpnl_Checkout.Controls.Add(pc);
            }

            //sell.Update();
            sell.Show();
            sell.RefundCheckout();


        }

        private void imgbtn_ResizeControl_Click(object sender, EventArgs e)
        {
            ExpandCollapseControl();
        }

        #endregion

        #region  Void - ...

        public void InitializeUI()
        {
            int DefaultSizeHeigt = 61;

            //Get Color from Class According Properties.Settings            
            SoftColor = UI.SoftColor();

            //Color Image
            imgExpand = Lib.ColorImage(imgExpand, ImageColor);
            imgCollapse = Lib.ColorImage(imgCollapse, ImageColor);
            btnPrintReceipt.Iconimage = Lib.ColorImage(btnPrintReceipt.Iconimage, ColorGray);
            btnGiftReceipt.Iconimage = Lib.ColorImage(btnGiftReceipt.Iconimage, ColorGray);
            btnReturnItems.Iconimage = Lib.ColorImage(btnReturnItems.Iconimage, ColorGray);
            btnEmailReceipt.Iconimage = Lib.ColorImage(btnEmailReceipt.Iconimage, ColorGray);

            //Change Color
            GridSeperator_Collapse.LineColor = GridSeperator_Expand.LineColor = ColorGray;

            //Change Size
            this.Size = new Size(this.Size.Width, DefaultSizeHeigt);

            //Image => Control
            imgbtn_ResizeControl.Image = imgExpand;

        }

        void BackEnd()
        {
            string[] tok = { "sdsfd", "dfsdfa", "afsfs", "safsfas", "afsfasf" };
            int[] id = { 10, 041, 047, 105, 100, 047, 105, 100, 047, 105, 100 };
            double[] qty = { 5, 2, 5, 1, 7, 5, 2, 5, 1, 7 };
            string[] name = { "Chicken Härnchen", "Jealow Rice", "Ybo Coco", "Chinchin", " Indomies"};            
            double[] price = { 5, 1.99, 7, 10.25, 1.99, 4, 5, 5, 4, 7 };
            double[] dis = { 10, 20, 30, 0, 50, 70, 80, 100, 0, 25, 25 };
            

            //Dev
            for (int x = 0; x < 5; x++)
            {
                int i = x;
               // Random rnd = new Random();
                //int i = rnd.Next(0, 4); // creates a number between 1 and 12

                //Add Checkout 
                CheckoutSaleLedger checkoutSaleLedger = new CheckoutSaleLedger();

                //Props
                checkoutSaleLedger.ProductToken = tok[i];
                checkoutSaleLedger.ProductUnitPrice = price[i];
                checkoutSaleLedger.ProductDiscountPercentage = dis[i];
                checkoutSaleLedger.ProductID = id[i];
                checkoutSaleLedger.ProductName = name[i];
                checkoutSaleLedger.ProductQuantity = qty[i];

                flpnlCheckoutProducts.Controls.Add(checkoutSaleLedger);
            }
            

        }
        void ExpandCollapseControl()
        {            
            //Expand or Collapse UC 
            ExpandControl = (ExpandControl) ? false : true;
            
            /**Access Parent Form
            SalesLedger salesLedger = Activator.CreateInstance(Type.GetType("Vendstor.UserControls.Dashboard." + ParentForm)) as SalesLedger;

            ControlCollection c = salesLedger.flpnlGridRows.Controls;
            
            foreach (RowSaleLedger rowSaleLedger in c)
            {
                MessageBox.Show("Foreach");
                //To Avoid To Select Current Usercontrol
                if (rowSaleLedger.ReceiptToken != this.ReceiptToken && rowSaleLedger.ExpandControl)
                {
                    MessageBox.Show("Found");
                    //=> Change Other ExpandControl = false;
                    rowSaleLedger.ExpandControl = false;
                    rowSaleLedger.ResizeControl();
                }
            }**/

            //Resize This Control
            ResizeControl();
        }
        public new void Update()
        {
            BackEnd();

        }
        public void ResizeControl()
        {
            int ExpandSizeHeight = 426;
            int DefaultSizeHeigt = 61;
          
            //Refresh UI 
            if (ExpandControl)
            {
                this.BackColor = Color.White;
                imgbtn_ResizeControl.Image = imgCollapse;
                //Change  Height Only
                this.Size = new Size(this.Size.Width + 5, ExpandSizeHeight);
                //Visibility
                Indicator.Visible = true;

                //Change Color
                GridSeperator_Collapse.LineColor = GridSeperator_Expand.LineColor = ColorDimGray;

            }
            else
            {
                this.BackColor = ColorDimGray;
                imgbtn_ResizeControl.Image = imgExpand;
                //Change  Height Only
                this.Size = new Size(this.Size.Width - 5, DefaultSizeHeigt);
                //Visibility
                Indicator.Visible = false;

                //Change Color
                GridSeperator_Collapse.LineColor = GridSeperator_Expand.LineColor = ColorGray;
            }

          
        }


        #endregion

        #region UserControl - Event


        #endregion

       
    }
}
