using System;
using System.Drawing;
using System.Windows.Forms;
using System.Globalization;
using System.Drawing.Printing;

//Vendstor
using Vendstor.Backend;
using Vendstor.Backend.Utils;
using Vendstor.Backend.Libraries;
using Vendstor.Backend.Hardwares;
using Vendstor.Backend.Database.Queries;

namespace Vendstor.UserControls.Dashboard.Setup
{
    public partial class Software : UserControl
    {
        #region Variables

        public Backend.Objects.User User = new Backend.Objects.User();

        enum FieldOrder { First, Second }
        enum CustomColorType { Hex, Rgb, None }

        Size ControlDefaultSize = new Size(888, 550);

        Point ActiveFieldLocation = new Point(11, 13);
        Point InActiveFieldLocation = new Point(11, 617);

        Color SoftColor;
        Color ColorGray = Color.FromArgb(209, 212, 221);
        Color ColorTextGray = Color.FromArgb(136, 144, 157);

        #endregion

        #region Constructors

        public Software()
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


        #endregion

        #region Control - Event Handler
                
        private void BtnSaveGeneralSettings_Click(object sender, EventArgs e)
        {
            //Color
            var customColorType = GetColorType(txtHEXColor.Text, txtRGBColor.Text);

            if (customColorType == CustomColorType.Hex)
                Properties.Settings.Default.SoftColor = ColorUtil.HEXToColor(txtHEXColor.Text);
            else if (customColorType == CustomColorType.Rgb)
                Properties.Settings.Default.SoftColor = ColorUtil.RGBToColor(txtRGBColor.Text);

            //Language
            var language = cbbLanguages.SelectedItem.ToString().Replace(" ", "").Split(',')[1];
            Properties.Settings.Default.SoftLocale = language;

            //Switch
            Properties.Settings.Default.IsSoundEnabled = ckbEnableSound.Checked;

            //Update
            Properties.Settings.Default.Save();
            QueryController.User.UpdateSettings();

            //Show 
            cardNewColor.color = cardNewColor.BackColor = Properties.Settings.Default.SoftColor;
        }

        private void BtnSaveServerSettings_Click(object sender, EventArgs e)
        {
            if (!Util.Func.IsUserAllowed(User, Util.PermissionAlertType.Message, this.ParentForm))
                return;

            //Server=localhost;Database=Vendstor;Uid=root;Pwd=;
            var connectionCredentials = string.Format("{0};{1};{2};{3};", txtServerHostName.Text, txtServerDatabase.Text,
                txtServerUserName.Text, txtServerPassword.Text);

            var connectionString = string.Format("Server={0};Database={1};Uid={2};Pwd={3};", txtServerHostName.Text, txtServerDatabase.Text ,
                txtServerUserName.Text, txtServerPassword.Text );
            var isOk = ServerUtil.IsConnectionStringOK(connectionString);

            if (isOk)
                Properties.Settings.Default.CustomConnectionString = connectionString;

            imgValidServerSets.Image = Validation.GetValidityImage(isOk);
            Properties.Settings.Default.UseDefaultSettings = switchUseDefaultServerConfig.Value;
            Properties.Settings.Default.ConnectionCredentials = connectionCredentials;

            // Save
            Properties.Settings.Default.Save();
        }

        private void BtnSaveReceiptLayout_Click(object sender, EventArgs e)
        {
            if (!Util.Func.IsUserAllowed(User, Util.PermissionAlertType.Message, this.ParentForm))
                return;

            Properties.Settings.Default.IsSoldByEnabled = switchDisplayUsername.Value;
            Properties.Settings.Default.ReceiptFooterMessage = rtxtDescription.Text;

            //Save Default Printer
            Printer.SetDefaultPrinter(cbbInstalledPrinters.SelectedItem.ToString());

            Properties.Settings.Default.Save();
        }

        private void BtnSaveHardwareSettings_Click(object sender, EventArgs e)
        {
            if (!Util.Func.IsUserAllowed(User, Util.PermissionAlertType.Message, this.ParentForm))
                return;

            Properties.Settings.Default.IsPrinterAvailable = switchPrinter.Value;
            Properties.Settings.Default.AppBasedScanner = switchAppScanner.Value;
            Properties.Settings.Default.MaximizeSoftware = switchMaxSoft.Value;
            Properties.Settings.Default.Save();
        }

        private void ColorCard_Click(object sender, EventArgs e)
        {
            Control control = (Control)sender;
            Properties.Settings.Default.SoftColor = cardNewColor.BackColor = cardNewColor.color =  control.BackColor;
            Properties.Settings.Default.Save();

            QueryController.User.UpdateSettings();
        }

        private void ImgbtnForceUpdate_Click(object sender, EventArgs e)
        {
            //Force Update
            this.Initialize();
        }
        private void LanguageSelectedIndexChanged(object sender, EventArgs e)
        {
            // Change SelectedIndex

            Control c = (Control)sender;
            if (c.Name.Contains("dpd"))
                cbbLanguages.SelectedIndex = dpdLanguages.selectedIndex;
            else if (c.Name.Contains("cbb"))
                dpdLanguages.selectedIndex = cbbLanguages.SelectedIndex;

        }

        private void PrinterSelectedIndexChanged(object sender, EventArgs e)
        {
            // Change SelectedIndex
            Control c = (Control)sender;
            if (c.Name.Contains("dpd"))
                cbbInstalledPrinters.SelectedIndex = dpdInstalledPrinters.selectedIndex;
            else if (c.Name.Contains("cbb"))
                dpdInstalledPrinters.selectedIndex = cbbInstalledPrinters.SelectedIndex;
        }

        private void ImgbtnGoSecondFields_Click(object sender, EventArgs e)
        {
            OrderFields(FieldOrder.Second);
        }

        private void ImgbtnGoFirstFields_Click(object sender, EventArgs e)
        {
            OrderFields(FieldOrder.First);
        }

        #endregion

        #region  Methods

        public void InitializeUI()
        {
            //Get Color from Class According Properties.Settings            
            SoftColor = UserInterface.SoftColor;

            //Change Color
            txtHEXColor.BorderColorFocused = txtRGBColor.BorderColorFocused = txtServerDatabase.BorderColorFocused = txtServerHostName.BorderColorFocused = txtServerPassword.BorderColorFocused =
                txtServerPort.BorderColorFocused = txtServerUserName.BorderColorFocused = SoftColor;
            txtHEXColor.BorderColorMouseHover = txtRGBColor.BorderColorMouseHover = txtServerDatabase.BorderColorMouseHover = txtServerHostName.BorderColorMouseHover = txtServerPassword.BorderColorMouseHover =
                txtServerPort.BorderColorMouseHover = txtServerUserName.BorderColorMouseHover = SoftColor;
            btnSaveGeneralSettings.Activecolor = btnSaveGeneralSettings.BackColor = btnSaveGeneralSettings.Normalcolor = btnSaveServerSettings.Activecolor = btnSaveHardwareSettings.Activecolor = btnSaveHardwareSettings.BackColor = btnSaveHardwareSettings.Normalcolor =
                btnSaveServerSettings.BackColor = btnSaveServerSettings.Normalcolor = btnSaveReceiptLayout.Activecolor = btnSaveReceiptLayout.BackColor = btnSaveReceiptLayout.Normalcolor = SoftColor;

            //Hover Color
            btnSaveGeneralSettings.OnHovercolor = btnSaveHardwareSettings.OnHovercolor = btnSaveReceiptLayout.OnHovercolor = btnSaveServerSettings.OnHovercolor = Color.FromArgb(200, SoftColor);

            //Color Images
            imgbtnGoFirstFields.Image = ImageUtil.ColorImage(imgbtnGoFirstFields.Image, ColorGray);
            imgbtnGoSecondFields.Image = ImageUtil.ColorImage(imgbtnGoSecondFields.Image, ColorGray);
            imgbtnForceUpdate.Image = ImageUtil.ColorImage(imgbtnForceUpdate.Image, Color.DimGray);

            //Show Current Color
            cardNewColor.color = cardNewColor.BackColor = SoftColor;
        }

        void Initialize()
        {
            User = Util.Data.GetUser();


            //Get Current Color
            cardNewColor.color = cardNewColor.BackColor = SoftColor;
            txtHEXColor.Text = ColorUtil.ToHEXColor(SoftColor);
            txtRGBColor.Text = ColorUtil.ToRGBColor(SoftColor);

            //Translate 
            Translate();

            //Show Languages
            CultureInfo[] cultureInfos = CultureInfo.GetCultures(CultureTypes.InstalledWin32Cultures);
            foreach (CultureInfo cultureInfo in cultureInfos)
            {
                dpdLanguages.AddItem(cultureInfo.DisplayName + " , " + cultureInfo.TwoLetterISOLanguageName);
                cbbLanguages.Items.Add(cultureInfo.DisplayName + " , " + cultureInfo.TwoLetterISOLanguageName);
            }

            //Get UserLocale
            cbbLanguages.SelectedItem = new CultureInfo(Properties.Settings.Default.SoftLocale).DisplayName + " , " + new CultureInfo(Properties.Settings.Default.SoftLocale).TwoLetterISOLanguageName;

            //Show Installed Printers
            foreach (var printer in PrinterSettings.InstalledPrinters)
            {
                cbbInstalledPrinters.Items.Add(printer);
                dpdInstalledPrinters.AddItem(printer.ToString());
            }
                

            ckbEnableSound.Checked = Properties.Settings.Default.IsSoundEnabled;
            switchUseDefaultServerConfig.Value = Properties.Settings.Default.UseDefaultSettings;
            switchMaxSoft.Value = Properties.Settings.Default.MaximizeSoftware;
            switchPrinter.Value = Properties.Settings.Default.IsPrinterAvailable;
            switchAppScanner.Value = Properties.Settings.Default.AppBasedScanner;
            switchDisplayUsername.Value = Properties.Settings.Default.IsSoldByEnabled;

            try
            {
                //Server Settings
                var connectionCredentials = Properties.Settings.Default.ConnectionCredentials.Split(';');
                txtServerHostName.Text = connectionCredentials[0];
                txtServerDatabase.Text = connectionCredentials[1];
                txtServerUserName.Text = connectionCredentials[2];
                txtServerPassword.Text = connectionCredentials[3];
            }
            catch { }
        }

        CustomColorType GetColorType(string HEX, string RGB)
        {
            if (ColorUtil.HEXToColor(HEX) != Color.White && !ColorUtil.HEXToColor(HEX).IsEmpty)
                return CustomColorType.Hex;

            if (ColorUtil.RGBToColor(RGB) != Color.White && !ColorUtil.RGBToColor(RGB).IsEmpty)
                return CustomColorType.Rgb;

            return CustomColorType.None;
        }

        void OrderFields(FieldOrder fieldOrder)
        {
            if (fieldOrder == FieldOrder.First)
                OrderFieldToControl(pnlFirstFields, pnlSecondFields);

            else if (fieldOrder == FieldOrder.Second)
                OrderFieldToControl(pnlSecondFields, pnlFirstFields);
        }

        void OrderFieldToControl(Control activeControl, Control inActiveControl)
        {
            if (ParentForm.WindowState == FormWindowState.Maximized)
            {
                Util.Methods.AlignToParent(activeControl, this);
                activeControl.Location = new Point(activeControl.Location.X, 13);
            }
            else
            {
                inActiveControl.Location = InActiveFieldLocation;
                activeControl.Location = ActiveFieldLocation;
            }
            activeControl.Visible = true;
            inActiveControl.Visible = false;
        }

        #endregion

        #region Translate

        void Translate()
        {
            if (Translation.IsPossible())
            {
                //Translate Strings 
                foreach (Control c in this.Controls)
                    if (c is Label)
                        c.Text = Translation.Translate(c.Text);

                foreach (Control c in cardServerSettings.Controls)
                    if (c is Label)
                        c.Text = Translation.Translate(c.Text);

                foreach (Control c in cardHardware.Controls)
                    if (c is Label)
                        c.Text = Translation.Translate(c.Text);

                foreach (Control c in cardGeneralSettings.Controls)
                    if (c is Label)
                        c.Text = Translation.Translate(c.Text);

                foreach (Control c in cardReceiptLayout.Controls)
                    if (c is Label)
                        c.Text = Translation.Translate(c.Text);

                text_BackToFields.Text = Translation.Translate(text_BackToFields.Text);
                btnSaveGeneralSettings.Text = btnSaveHardwareSettings.Text = btnSaveReceiptLayout.Text = btnSaveServerSettings.Text = Translation.Translate("Save");
            }
        }

        #endregion

        #region OnClose

        #endregion
    }
}
