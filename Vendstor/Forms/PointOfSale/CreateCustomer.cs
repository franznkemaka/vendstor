using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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

namespace Vendstor.Forms.PointOfSale
{
    public partial class CreateCustomer: Form
    {
        
        #region Variables

        public string CustomerToken { get; set; }
        public string RootForm { get; set; }

        //Class
        UserInterface UI = new UserInterface();
        Library Lib = new Library();

        //Enum
        enum Form { Hide, Close, Exit };
        enum FieldOrder { First, Second }

        //Size
        Size ControlDefaultSize = new Size(746, 461);

        //Point
        Point ActiveField = new Point(12, 12);
        Point InActiveField = new Point(12, 455);

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

        #region Form Load
        
        private void CreateCustomer_Load(object sender, EventArgs e)
        {
            BackEnd();
        }

        #endregion

        #region Control - Event Handler

        private void imgbtnGoSecondFields_Click(object sender, EventArgs e)
        {
            //Set _FieldIndex = 1 => Second Panel
            OrderFields((int)FieldOrder.Second);
        }

        private void imgbtnGoFirstFields_Click(object sender, EventArgs e)
        {
            //Set _FieldIndex = 0 => First Panel
            OrderFields((int)FieldOrder.First);
        }

        private void imgbtn_Exit_Click(object sender, EventArgs e)
        {
            this.CloseForm((int)Form.Close);
        }

        #endregion

        #region  Void - ...

        public void InitializeUI()
        {
            //Get Color from Class According Properties.Settings            
            SoftColor = UI.SoftColor();
            Color HoverColor = Color.FromArgb(200, SoftColor);

            //Change Color
            dpDateOfBirth.BackColor = dpdCountry.NomalColor = btnCreate.BackColor = btnCreate.Activecolor = btnCreate.Normalcolor = SoftColor;
            txtFirstName.BorderColorFocused = txtLastName.BorderColorFocused = txtCustomerCode.BorderColorFocused = txtCustomerGroup.BorderColorFocused = 
                txtEmail.BorderColorFocused = txtPhoneNumber.BorderColorFocused = txtWebsite.BorderColorFocused = txtStreet.BorderColorFocused = txtCity.BorderColorFocused = txtPostCode.BorderColorFocused = SoftColor;

            //HoverColor
            btnCreate.OnHovercolor = dpdCountry.onHoverColor = HoverColor;

            txtFirstName.BorderColorMouseHover = txtLastName.BorderColorMouseHover = txtCustomerCode.BorderColorMouseHover = txtCustomerGroup.BorderColorMouseHover =
             txtEmail.BorderColorMouseHover = txtPhoneNumber.BorderColorMouseHover = txtWebsite.BorderColorMouseHover = txtStreet.BorderColorMouseHover = txtCity.BorderColorMouseHover = txtPostCode.BorderColorMouseHover = SoftColor;


            //Color Images
            imgbtnGoFirstFields.Image = Lib.ColorImage(imgbtnGoFirstFields.Image, ColorGray);
            imgbtn_Exit.Image = Lib.ColorImage(imgbtn_Exit.Image, ColorGray);
            imgbtnGoSecondFields.Image = Lib.ColorImage(imgbtnGoSecondFields.Image, ColorGray);

            //Size
            this.Size = ControlDefaultSize;
        }

        void BackEnd()
        {
            CustomerToken = "HELLOSOFT";
        }

        void GoRootForm()
        {
            if (RootForm == "Sell")
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
            CreateCustomer addCustomer = (CreateCustomer)Application.OpenForms["AddCustomer"];
            addCustomer.Hide();

            this.Hide();
        }


        void OrderFields(int _FieldIndex)
        {
            //Know Field Index  (First = 0, Second = 1)        
            if (_FieldIndex == (int)FieldOrder.First)
            {
                //Change Panel Location
                pnlFirstFields.Location = ActiveField;
                pnlSecondFields.Location = InActiveField;
            }
            else if (_FieldIndex == (int)FieldOrder.Second)
            {
                //Change Panel Location
                pnlFirstFields.Location = InActiveField;
                pnlSecondFields.Location = ActiveField;
            }

        }


        #endregion

        #region Form Close

        public void CloseForm(int _CloseFormIndex)
        {
            switch (_CloseFormIndex)
            {
                case (int)Form.Close:
                    this.Close();
                    break;

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
