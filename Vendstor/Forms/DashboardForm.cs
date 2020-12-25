using System;
using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel;


//Vendstor
using Vendstor.UserControls;
using Vendstor.UserControls.Dashboard;

using Vendstor.Backend;
using Vendstor.Backend.Utils;

namespace Vendstor.Forms
{
    public partial class DashboardForm : Form
    {
        #region Variables

        public string TabName = "Home";
        BackgroundWorker AsyncWorker;

        Backend.Objects.Store store = new Backend.Objects.Store();
        Backend.Objects.User user = new Backend.Objects.User();

        Sell Sell;

        Home Home;
        SellRegister SellRegister;
        SalesLedger SalesLedger;
        Reporting Reporting;
        ProductsTab Products;
        UserControls.Dashboard.Customers Customers;
        Settings Settings;

        UserTab UserTabSlider;
        NotificationsTab NotificationsTabSlider;

        Color SoftColor;

        int LargeScreenWidth = 1300;
        bool IsUserTabVisible = true;
        bool IsNotificationsTabVisible = true;

        public bool ScrollOnNormalized = false;
        public bool ScrollOnMaximized = false;

        #endregion

        #region Constructor

        public DashboardForm()
        {
            InitializeComponent();

            InitializeUI();
            Util.Methods.SetIcon(this);
            AsyncWorker = new BackgroundWorker();

            // Due to performance Reason 
            // Load Tasks
            AsyncWorker.DoWork += AsyncInititalize;
            AsyncWorker.RunWorkerCompleted += OnAsyncWorkerCompleted;
            AsyncWorker.RunWorkerAsync();
        }

        #endregion

        #region OnLoad

        private void OnLoad(object sender, EventArgs e)
        {
            // Truncate 
            lblStoreName.Text = lblUserDisplayName.Text = "";

            Translate();

            // Wait for AsyncWorker To Complete Work To Get             
        }

        private void AsyncInititalize(object sender, DoWorkEventArgs e)
        {
            try
            {
                // Execute the following code on the GUI thread.
                this.Invoke(new MethodInvoker(delegate
                {
                    RenderLoading(true);
                }));
            }catch { }
         
           
            Sell = new Sell();

            SellRegister = new SellRegister();
            SalesLedger = new SalesLedger();
            Reporting = new Reporting();
            Products = new ProductsTab();
            Customers = new UserControls.Dashboard.Customers();
            Settings = new Settings();

            UserTabSlider = new UserTab();
            NotificationsTabSlider = new NotificationsTab();           
        }

        private void OnAsyncWorkerCompleted(object sender, AsyncCompletedEventArgs e)
        {
            try
            {
                // Execute the following code on the GUI thread.
                this.Invoke(new MethodInvoker(delegate
                {
                    RenderLoading(false);
                    Home = new Home();

                    Initialize();
                }));
            }
            catch { }          
        }

        #endregion

        #region Form - Event Handler

        private void OnSizeChanged(object sender, EventArgs e)
        {
            ResizeControl();
        }

        #endregion

        #region Control - Event Handler

        private void ImgbtnMaximize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            TopMost = true;
        }

        private void ImgbtnExit_Click(object sender, EventArgs e)
        {
            Extensions.CloseOrHide(this, "Main");
        }

        private void ImgbtnForceUpdate_Click(object sender, EventArgs e)
        {
            //Force Update
            this.Initialize();
        }

        private void ImgbtnNormalize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            this.CenterToScreen();
            TopMost = false;
        }

        private void ImgbtnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void ImgbtnToggleUserTab_Click(object sender, EventArgs e)
        {
            //Show UserTab if IsUserTabVisible
            SlideTab(UserTabSlider, IsUserTabVisible);
        }

        private void ImgbtnNotifications_Click(object sender, EventArgs e)
        {
            //Show NotificationTab if IsNotificationsTabVisible
            SlideTab(NotificationsTabSlider, IsNotificationsTabVisible);
        }

        #endregion

        #region Slider Button - Event Handler

        /// <summary>
        /// Main Slider Button Click [HomeTab, SellTab ...]
        /// </summary
        private void SliderButton(object sender, EventArgs e)
        {
            //Load User Control According To Button LabelText
            TabName = ((Control)sender).Name.Replace("tbtn", "");
            AddTabs();
        }

        #endregion

        #region  Methods

        #region Backend

        public void Initialize()
        {
            // Get a Store LogOut if an error occurs
            user = Util.Data.HandshakeUser(this);
            store = Util.Data.HandshakeStore(this);

            serverSignal.Start();

            UserTabSlider.RootFormIndex = (int)UserTab.RootForm.MainDashBoard;
            lblStoreName.Text = store.Name;
            lblUserDisplayName.Text = $"{ user.FirstName } { user.LastName }";
            imgUserProfile.Image = user.ProfileOvalImage;

            AddTabs();

            //Align Controls
            Util.Methods.AlignToParent(lblStoreName, pnlHeader);
        }

        void AddControlToPanel(UserControl uc)
        {
            if (this.WindowState == FormWindowState.Maximized)
                uc.Size = ChildControls.Size;

            ChildControls.Controls.Clear();
            ChildControls.Controls.Add(uc);
            ResizeControl();
            uc.Update();
        }

        void RenderLoading(bool isLoading = true)
        {
            LoadingPanel.Visible = isLoading;
            ChildControls.Visible = !isLoading;
            pgbLoading.animated = isLoading;
        }

        void AddTabs()
        {
            UserControl userControl = new UserControl();
            Control control = null;

            switch (TabName)
            {
                case "Home":
                    userControl = Home;
                    control = tbtnHome;
                    break;

                case "Sell":
                    try
                    {
                        this.TopMost = false;
                        userControl = SellRegister;
                        control = tbtnSell;
                        Sell.TopMost = true;
                        Sell.WindowState = this.WindowState;
                        Sell.ShowDialog();
                    }catch { return;  }        
                    break;
                case "SalesLedger":
                    userControl = SalesLedger;
                    control = tbtnSalesLedger;
                    break;

                case "Reporting":
                    userControl = Reporting;
                    control = tbtnReporting;
                    break;

                case "Products":
                    userControl = Products;
                    control = tbtnProducts;
                    break;

                case "Customers":
                    userControl = Customers;
                    control = tbtnCustomers;
                    break;

                case "Settings":
                    userControl = Settings;
                    control = tbtnSettings;
                    break;

            }

            if (control != null)
                PointIndicatorTo(control);

            if (userControl != null)
                AddControlToPanel(userControl);
        }

        #endregion

        #region UI

        void InitializeUI()
        {
            SoftColor = UserInterface.SoftColor;

            Color color = Color.FromArgb(209, 212, 221);
            ImageUtil.ColorImageButton(imgbtnMinimize, color);
            ImageUtil.ColorImageButton(imgbtnNormalize, color);
            ImageUtil.ColorImageButton(imgbtnMaximize, color);
            ImageUtil.ColorImageButton(imgbtnExit, color);

            IndicatorSlider.LineColor = pnlSoftName.BackColor = lblStoreName.ForeColor = SoftColor;
            pgbLoading.ProgressColor = SoftColor;

            ImageUtil.ColorImageButton(imgbtnToggleUserTab, Color.FromArgb(209, 212, 221));
            ImageUtil.ColorImageButton(imgbtnForceUpdate, Color.FromArgb(209, 212, 221));

            ImageUtil.ColorTitleButton(tbtnHome, Color.FromArgb(160, 89, 181));
            ImageUtil.ColorTitleButton(tbtnSell, Color.FromArgb(68, 183, 115));
            ImageUtil.ColorTitleButton(tbtnSalesLedger, Color.FromArgb(86, 186, 214));
            ImageUtil.ColorTitleButton(tbtnReporting, Color.FromArgb(243, 194, 119));
            ImageUtil.ColorTitleButton(tbtnProducts, Color.FromArgb(245, 118, 95));
            ImageUtil.ColorTitleButton(tbtnCustomers, Color.FromArgb(160, 89, 181));
            ImageUtil.ColorTitleButton(tbtnSettings, Color.FromArgb(72, 87, 112));

            pnlSliderTab.Dock = DockStyle.None;
            pnlSliderTab.Visible = false;
        }

        void PointIndicatorTo(Control control)
        {
            IndicatorSlider.Location = new Point(IndicatorSlider.Location.X, control.Location.Y);
        }

        public void RequestAutoScroll(bool scrollOnMaximized = true, bool scrollOnNormalized = false)
        {
            ScrollOnNormalized = scrollOnNormalized;
            ScrollOnMaximized = scrollOnMaximized;
        }

        void ResizeControl()
        {
            Size homeControlSize = new Size(1349, 892);
            Size minimizeSize = new Size(1138, 660);

            if (this.WindowState == FormWindowState.Normal)
            {               
                foreach (UserControl uc in ChildControls.Controls)
                {
                    if (uc is Home)
                    {
                        uc.Size = homeControlSize;
                        ChildControls.AutoScroll = ScrollOnNormalized;
                    }
                    else
                    {
                        uc.Size = minimizeSize;
                        ChildControls.AutoScroll = false;
                    }
                       
                    uc.Update();
                }
            }
            else if (this.WindowState == FormWindowState.Maximized)
            {
                //Change AutoScroll  According FlowPanelMaximedSize  ; Default (Undefined ) = False;
                if (this.Size.Width > LargeScreenWidth)
                    ChildControls.AutoScroll = false;

                foreach (UserControl uc in ChildControls.Controls)
                {
                    // AdditionalWidth To Replace Width Occupied By The Scroll         
                    int additionalWidth = 150;

                    if (uc is Home)
                    {
                        uc.Size = new Size(homeControlSize.Width + 10, homeControlSize.Height);
                        ChildControls.AutoScroll = ScrollOnMaximized;
                    }
                    else
                    {
                        ChildControls.AutoScroll = false;
                    }
                       

                    //Change Size                    
                    if (this.Size.Width < LargeScreenWidth)
                        uc.Size = new Size(ChildControls.Width + additionalWidth, ChildControls.Height);
                    else
                        uc.Size = ChildControls.Size;

                    uc.Update();
                }
            }
        }

        /// <summary>
        /// Show or hide SliderTab according to bool
        /// </summary>
        /// <param name="userControl"></param>
        /// <param name="isVisible"></param>
        void SlideTab(UserControl userControl, bool isVisible)
        {
            pnlSliderTab.Controls.Clear();

            //Color Images
            Color color = Color.FromArgb(209, 212, 221);
            Image expand = ImageUtil.ColorImage(Properties.Resources.expand_arrow_w, color);
            Image collapse = ImageUtil.ColorImage(Properties.Resources.collapse_arrow_w, color);
            Image notif = ImageUtil.ColorImage(Properties.Resources.notification_w, color);
            Image hide = ImageUtil.ColorImage(Properties.Resources.hide_w, color);


            //Set Panel Size according to UserControl's Width; Add 2 For Borders
            int extraBorderWidth = 2;
            pnlSliderTab.Size = new Size(userControl.Size.Width + extraBorderWidth, pnlSliderTab.Height);
            pnlSliderTab.Visible = isVisible;

            if (isVisible)
            {
                pnlSliderTab.Dock = DockStyle.Right;

                // Add control
                pnlSliderTab.Controls.Add(userControl);
                if (userControl == UserTabSlider)
                {
                    imgbtnToggleUserTab.Image = collapse;
                    IsUserTabVisible = false;
                }
                else
                {
                    imgbtnNotifications.Image = hide;
                    IsNotificationsTabVisible = false;
                }
            }
            else
            {
                pnlSliderTab.Dock = DockStyle.None;
                if (userControl == UserTabSlider)
                {
                    imgbtnToggleUserTab.Image = expand;
                    IsUserTabVisible = true;
                }
                else
                {
                    imgbtnNotifications.Image = notif;
                    IsNotificationsTabVisible = true;
                }
            }
        }


        #endregion

        #endregion

        #region Translate

        void Translate()
        {
            if (Translation.IsPossible())
            {
                //Translate Strings 
                tbtnHome.LabelText = Translation.Translate(tbtnHome.LabelText);
                tbtnSell.LabelText = Translation.Translate(tbtnSell.LabelText);
                tbtnSalesLedger.LabelText = Translation.Translate(tbtnSalesLedger.LabelText);
                tbtnReporting.LabelText = Translation.Translate(tbtnReporting.LabelText);
                tbtnProducts.LabelText = Translation.Translate(tbtnProducts.LabelText);
                tbtnCustomers.LabelText = Translation.Translate(tbtnCustomers.LabelText);
                tbtnSettings.LabelText = Translation.Translate(tbtnSettings.LabelText);
            }
        }

        #endregion

        #region OnClose

        private void OnClose(object sender, FormClosingEventArgs e)
        {
            serverSignal.Stop();
        }

        #endregion
    }
}
