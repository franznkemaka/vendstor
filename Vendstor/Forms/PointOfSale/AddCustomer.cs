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
    public partial class AddCustomer: Form
    {

        #region Variables

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

        public AddCustomer()
        {
            InitializeComponent();

            //Void
            InitializeUI();
        }

        #endregion

        #region Form Load
        
        private void AddCustomer_Load(object sender, EventArgs e)
        {
            BackEnd();
        }

        #endregion

        #region Control - Event Handler


        #endregion

        #region  Void - ...

        public void InitializeUI()
        {
            //Get Color from Class According Properties.Settings            
            SoftColor = UI.SoftColor();
        }

        void BackEnd()
        {
            CreateCustomer CreateCustomer = new CreateCustomer();

            //Props
            CreateCustomer.RootForm = RootForm;

            //Add
            flpnl_Controls.Controls.Add(CreateCustomer);
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
