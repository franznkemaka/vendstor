using System;
using System.Drawing;
using System.Windows.Forms;

using Vendstor.Backend.Utils;

// PR : Implement Notifications 

namespace Vendstor.Models
{
    public partial class NotificationModel : UserControl
    {
        #region Variables

        public string NotifDate { get; set; }
        public string NotifTitle { get; set; }
        public string NotifDetails { get; set; }
        public string NotifForm { get; set; }

        public string OpenForm { get; set; }
        public bool IsClickable { get; set; }

        Color SoftColor;
        
        #endregion

        #region Constructors

        public NotificationModel()
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

        #region Control - Event Handler


        private void ImgbtnClear_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void OnClick(object sender, EventArgs e)
        {
            if (IsClickable && OpenForm != "")
            {

                try
                {
                    var frm = Activator.CreateInstance(Type.GetType("Vendstor.Forms." + OpenForm)) as Form;
                    frm.Show();
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex);
                }
               
            }
        }

        #endregion

        #region  Methods

        void InitializeUI()
        {
            SoftColor = UserInterface.SoftColor;
          
            //Change SoftColor = UI[Class]
            if (!IsClickable)
                Cursor = DefaultCursor;
      
        }
        void Initialize()
        {
            //Fill Text
            lblNotifDate.Text = NotifDate;
            lblNotifDetails.Text = NotifDetails;
            lblNotifForm.Text = NotifForm;
            lblNotifTitle.Text = NotifTitle;

            //Controls  

            //Actualize Size
            RefreshControl(135);
        }
        
        void RefreshControl(int newSize)
        {
            //Change Size According To Description Length, To Handle long Notifications
            Size = new Size(this.Size.Width, lblNotifDetails.Size.Height + newSize);

            //Change Control Location
           Util.Methods.AlignToParent(lblNotifForm, pnlHeader);
           Util.Methods.AlignToParent(lblNotifDetails, this);

            //pnlHeader.BackColor = SoftColor;
        }

        #endregion

        #region OnClose

        #endregion

    }
}
