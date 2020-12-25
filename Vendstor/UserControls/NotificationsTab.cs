using System;
using System.Drawing;
using System.Windows.Forms;

//Vendstor
using Vendstor.Backend.Utils;

namespace Vendstor.UserControls
{
    public partial class NotificationsTab : UserControl
    {
        #region Variables
       

        Color SoftColor;

        #endregion

        #region Constructors

        public NotificationsTab()
        {
            InitializeComponent();

           
        }

        #endregion

        #region OnLoad

        private void OnLoad(object sender, EventArgs e)
        {
            InitializeUI();

            Initialize();
        }

        #endregion

        #region Controls - Event Handler


        #endregion

        #region  Methods

        void InitializeUI()
        {
            SoftColor = UserInterface.SoftColor;
            pnlHeader.BackColor = SoftColor;
        }

        void Initialize()
        {         
        }

        #endregion

        #region  OnClose

        #endregion
    }
}
