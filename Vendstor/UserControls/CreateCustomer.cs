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

namespace Vendstor.UserControls
{
    public partial class CreateCustomer : UserControl
    {

        #region Variables

        public string CustomerToken { get; set; }
        public string RootForm { get; set; }

        //Class
        UserInterface UI = new UserInterface();
        Library Lib = new Library();

        //Enum
        enum Form { Hide, Close, Exit };

        //Color
        Color SoftColor;
        Color ColorGray = Color.FromArgb(209, 212, 221);

        //Color AltSoftColor;

        #endregion

        #region InitializeComponent

        public CreateCustomer()
        {
            InitializeComponent();

            //Void
            InitializeUI();
        }

        #endregion

        #region UserControl Load

        private void AddCustomer_Load(object sender, EventArgs e)
        {
           
        }

        #endregion

        #region Control - Event Handler


        private void btn_CreateCustomer_Click(object sender, EventArgs e)
        {
            //Save Data
            this.GoRootForm();
        }
        
        private void CreateCustomer_Load(object sender, EventArgs e)
        {
            BackEnd();
        }

        #endregion


        #region  Void - ...

        public void InitializeUI()
        {
            //Get Color from Class According Properties.Settings            
            SoftColor = UI.SoftColor();
        }

        void BackEnd()
        {
            CustomerToken = "HELLOSOFT";
        }

        void GoRootForm()
        {
            if(RootForm == "Sell")
            {
                Sell sell = (Sell)Application.OpenForms["Sell"];

                //=> Props
                sell.CustomerToken = CustomerToken;

                
                //update
                sell.Update();
            }
            //Close ParentForm  of ParentForm
            Forms.PointOfSale.Customers customers = (Forms.PointOfSale.Customers)Application.OpenForms["Customers"];
            customers.Hide();

            //Close ParentForm
            AddCustomer addCustomer = (AddCustomer)Application.OpenForms["AddCustomer"];
            addCustomer.Hide();

            this.Hide();
        }


        #endregion

        #region UserControl Close

        public void CloseForm(int _CloseFormIndex)
        {
            switch (_CloseFormIndex)
            {
                
                case (int)Form.Exit:
                    Application.Exit();
                    break;

                case (int)Form.Hide:
                    //Hide
                    this.Hide();
                    break;
            }
        }

        #endregion

    }
}
