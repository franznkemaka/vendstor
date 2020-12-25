using System;
using System.Drawing;
using System.Windows.Forms;

//Vendstor
using Vendstor.Modals;

using Vendstor.Backend;
using Vendstor.Backend.Data;
using Vendstor.Backend.Utils;
using Vendstor.Backend.Constants;
using Vendstor.Backend.Libraries;
using Vendstor.Backend.Database.Queries;
using System.Drawing.Imaging;

namespace Vendstor.Forms
{
    public partial class User : Form
    {
        #region Variables

        public Backend.Objects.User CurrentUser = new Backend.Objects.User();
        Backend.Objects.User user = new Backend.Objects.User();
        Backend.Objects.User actionUser = new Backend.Objects.User();
        Backend.Objects.Store store = new Backend.Objects.Store();

        public int UsersCount { get; set; }

        private Enums.ActionDialog ActionDialog { get; set; }
        public Enums.Task Task { get; set; }

        private Image UserTokenCode { get; set; }
        public bool IsUserRegistered { get; set; }

        string LocalImagePath = null;

        enum ActiveField { Details, SecurityOrInsights }

        Size ControlDefaultSize = new Size(888, 550);

        Point ActiveFieldLocation = new Point(12, 12);
        Point InActiveFieldLocation = new Point(12, 556);
        Point SecurityPnlFieldLocation = new Point(12, 100);

        Color SoftColor;
        Color ColorGray = Color.FromArgb(209, 212, 221);

        #endregion

        #region Constructors

        public User()
        {
            InitializeComponent();

            InitializeUI();
            Util.Methods.SetIcon(this);
        }

        #endregion

        #region OnLoad

        private void OnLoad(object sender, EventArgs e)
        {
            Initialize();
        }

        #endregion

        #region Control - Event Handler        

        public Enums.ActionDialog ShowWithDialog()
        {
            this.ShowDialog();
            return ActionDialog;
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (Task == Enums.Task.Update || Task == Enums.Task.Get)
            {
                UpdateUser();
                UpdateProfileImage();

                ActionDialog = Enums.ActionDialog.Updated;
            }
            else if (Task == Enums.Task.Create)
            {
                CreateUser();

                ActionDialog = Enums.ActionDialog.Created;
            }
            this.Close();
        }

        private void InputValueChanged(object sender, EventArgs e)
        {
            Control txt = (Control)sender;

            //Change Validity Image According To Control Name
            if (txt.Name.Contains("Username"))
                imgValidUsername.Image = Validation.GetValidityImage(Validation.IsStringValid(txt.Text, 5, 20));

            else if (txt.Name.Contains("FirstName"))
                imgValidFirstName.Image = Validation.GetValidityImage(Validation.IsStringValid(txt.Text, 3, 25));

            else if (txt.Name.Contains("LastName"))
                imgValidLastName.Image = Validation.GetValidityImage(Validation.IsStringValid(txt.Text, 3, 25));

            else if (txt.Name.Contains("Email"))
                imgValidEmail.Image = Validation.GetValidityImage(Validation.IsEmailValid(txt.Text));

            else if (txt.Name.Contains("Password"))
                imgValidPassword.Image = Validation.GetValidityImage(Validation.IsPasswordValid(txt.Text) && txtPassword.Text == txtRepeatPassword.Text);

            else if (txt.Name.Contains("Pin"))
                imgValidPIN.Image = Validation.GetValidityImage(Validation.IsPINValid(txt.Text));

            else
                return;
        }

        private void BtnDeleteProfileImage_Click(object sender, EventArgs e)
        {
            DeleteProfileImage();

            //Reset LocalImagePath
            LocalImagePath = null;
        }

        private void BtnPrintToken_Click(object sender, EventArgs e)
        {
            // PR : Print QR Code

            // Save locally
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Images|*.png;*.bmp;*.jpg";
            ImageFormat format = ImageFormat.Png;
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                var extension = System.IO.Path.GetExtension(saveFileDialog.FileName);
                switch (extension)
                {
                    case ".jpg":
                        format = ImageFormat.Jpeg;
                        break;
                    case ".bmp":
                        format = ImageFormat.Bmp;
                        break;
                    case ".png":
                        format = ImageFormat.Png;
                        break;
                }
                imgUserCode.Image.Save(saveFileDialog.FileName, format);
            }
        }

        private void BtnCopyUserToken_Click(object sender, EventArgs e)
        {
            //Copy UserToken To Clipboard
            Clipboard.SetText(lblUserToken.Text);
        }

        private void RoleSelectedIndexChanged(object sender, EventArgs e)
        {
            // Change SelectedIndex
            Control control = (Control)sender;
            if (control.Name.Contains("dpd"))
                cbbUserRole.SelectedIndex = dpdRole.selectedIndex;
            else if (control.Name.Contains("cbb"))
                dpdRole.selectedIndex = cbbUserRole.SelectedIndex;
        }

        private void ImgbtnGoSecondFields_Click(object sender, EventArgs e)
        {
            ToPanel(ActiveField.SecurityOrInsights);
        }

        private void ImgbtnGoFirstFields_Click(object sender, EventArgs e)
        {
            ToPanel(ActiveField.Details);
        }
        private void ImgbtnExit_Click(object sender, EventArgs e)
        {
            ActionDialog = Enums.ActionDialog.Closed;
            this.Close();
        }

        private void BtnUploadProfileImage_Click(object sender, EventArgs e)
        {
            //Open File Dialog   
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                //Image Filters  
                Filter = "Vendstor Image Files (*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                //Display Image in ImageBox
                imgProfileImage.Image = new Bitmap(openFileDialog.FileName);
                LocalImagePath = openFileDialog.FileName;
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            // User can't delete his/her own account by him/her self
            if (actionUser.Id == user.Id)
            {
                Blur blur = new Blur(this, UIConstants.MinBlurOpacity);
                blur.Show();

                new MessageDialog
                {
                    DialogButtonsIndex = MessageDialog.DialogButtons.One,
                    DialogIconIndex = MessageDialog.DialogIcon.Sorry,
                    ThirdBtnText = "OK",
                    Title = "Impossible to delete this Account",
                    Message = "Sorry you can't delete your account yourself. To so either create a new admin account or use another account. Contact Franz Nkemaka for more!",
                    TopMost = true,
                }.ShowDialog();

                blur.Close();
            }
            else
            {
                Blur blur = new Blur(this, UIConstants.MinBlurOpacity);
                blur.Show();

                MessageDialog messageDialog = new MessageDialog
                {
                    DialogButtonsIndex = MessageDialog.DialogButtons.Two,
                    DialogIconIndex = MessageDialog.DialogIcon.Sorry,
                    SecondBtnText = "No",
                    ThirdBtnText = "Yes",
                    ThirdBtnColor = Color.Tomato,
                    Title = "Are you sure ?",
                    Message = $"Are you sure you want to permanently delete { user.FirstName }, this user will be deleted immediately. You can't undo this action.",
                    TopMost = true,
                };

                var dialogResult = messageDialog.ShowWithEvent();
                if (dialogResult == MessageDialog.OnClickEvent.ThirdButton)
                {
                    //Delete
                    DeleteUser();
                    ActionDialog = Enums.ActionDialog.Deleted;
                }

                blur.Close();
            }    
        }

        #endregion

        #region  Methods

        #region Backend

        void Initialize()
        {
            actionUser = Util.Data.GetUser();
            store = Util.Data.GetStore();
            user = CurrentUser;

            //Get Task
            if (Task == Enums.Task.Get || Task == Enums.Task.Update)
            {
                IsUserRegistered = true;

                GetUser();

                text_EnterPassword.Text = "Change Password";
                text_RepeatPassword.Text = "Repeat New Password";

                //Render User Token Code
                RenderUserCode();
            }
            else
                IsUserRegistered = btnDelete.Visible = false;

            if (!Util.Func.IsUserAllowed(actionUser))
                dpdRole.Enabled = false;

            ReArrangePanel();

            Translate();
        }

        void GetUser()
        {
            if (QueryController.User.IsIdValid() && QueryController.User.IsIdValid(user.Id))
            {
                lblTitle.Text = $"{ user.FirstName } { user.LastName }";
                txtUsername.Text = user.Username;
                txtFirstName.Text = user.FirstName;
                txtLastName.Text = user.LastName;
                txtEmailAddress.Text = user.Email;
                txtPassword.Text = user.Password;
                txtRepeatPassword.Text = user.Password;
                lblUserToken.Text = user.Username;
                txtPinCode.Text = user.PinCode;

                cbbUserRole.SelectedItem = user.Role;
                imgProfileImage.Image = user.ProfileImage;
            }
            else
                Alert.Show("Error", "Something went wrong, this user doesn't exist", Alert.AlertType.Error);
        }

        void CreateUser()
        {
            bool isSuccess = false;

            if (IsInputValid())
            {
                isSuccess = true;

                SetUserProperties();

                var response = QueryController.User.Register(user, store);
                if (response.StatusCode == 201)
                {
                    var _user = (Backend.Objects.User)response.Data;

                    // Update Image
                    if (LocalImagePath != null)
                        UploadProfileImage(_user);
                }

                //Duplicate KEY OR Conflict
                else if (response.StatusCode == 409)
                {
                    Alert.Show("Possible Duplicate", "Please try another email, this one is already used", Alert.AlertType.Warning, isMini: false);
                    imgValidEmail.Image = Validation.GetValidityImage(false);
                }
                else
                {
                    Util.MessageParser.Alert("User", Util.AlertParserType.ErrorCreating);
                    isSuccess = false;
                }
            }

            //Change Validity Image
            imgValidEmail.Image = imgValidLastName.Image = imgValidUsername.Image = imgValidFirstName.Image = imgValidPIN.Image = imgValidPassword.Image = Validation.GetValidityImage(isSuccess);

        }

        void UpdateUser()
        {
            bool isSuccess = false;

            if (IsInputValid())
            {
                isSuccess = true;

                SetUserProperties();

                var response = QueryController.User.Update(user);
                if (response.StatusCode == 204)
                {
                    var _user = (Backend.Objects.User)response.Data;
                    this.Close();
                }
                //Duplicate KEY OR Conflict
                else if (response.StatusCode == 409)
                {
                    Alert.Show("Possible Duplicate", "Please try another email, this one is already used", Alert.AlertType.Warning, isMini: false);
                    imgValidEmail.Image = Validation.GetValidityImage(false);
                }
                else
                {
                    Util.MessageParser.Alert("User", Util.AlertParserType.ErrorUpdating);
                    isSuccess = false;
                }
            }

            //Change Validity Image
            imgValidEmail.Image = imgValidLastName.Image = imgValidUsername.Image = imgValidFirstName.Image = imgValidPIN.Image = imgValidPassword.Image = Validation.GetValidityImage(isSuccess);
        }

        void SetUserProperties()
        {
            user.Username = txtUsername.Text;
            user.Email = txtEmailAddress.Text;
            user.Password = txtPassword.Text;
            user.Role = dpdRole.selectedValue;
            user.FirstName = txtFirstName.Text;
            user.LastName = txtLastName.Text;
            user.PinCode = txtPinCode.Text;
            user.Locale = store.Locale;
            user.Color = Properties.Settings.Default.SoftColor;
        }

        void DeleteUser()
        {
            // Delete Profile Image
            DeleteProfileImage();

            // Delete User
            var response = QueryController.User.Delete(user);
            if (response.StatusCode == 204)
            {
                this.Close();
            }
            else
                Alert.Show("Error", "Something went wrong", Alert.AlertType.Error);

            //Close
            this.Close();
        }

        void DeleteProfileImage()
        {
            if (Validation.IsTokenValid(user.ImageBlobId, 30))
            {
                var file = (Backend.Objects.File)QueryController.Blob.Get(user.ImageBlobId).Data;
                QueryController.Blob.Delete(file);
            }
            imgProfileImage.Image = ImageUtil.DrawLetter(user.FirstName, backgroundColor: SoftColor);
        }

        void UpdateProfileImage()
        {
            if (LocalImagePath != null)
            {
                //Delete Old Image
                if (Validation.IsTokenValid(user.ImageBlobId, 30))
                    DeleteProfileImage();
                //Upload new Image
                UploadProfileImage(user);
            }
        }

        void UploadProfileImage(Backend.Objects.User user)
        {
            Backend.Objects.File file = new Backend.Objects.File
            {
                SystemFileName = LocalImagePath,
                Extension = ".jpg",
                ServerFolder = ServerConstants.ServerFolderPath,
            };

            // Returns BlobId
            var response = QueryController.Blob.Create(file);
            var _file = (Backend.Objects.File)response.Data;
            // Update ImageBlobId
            QueryController.User.UpdateImage(user, _file);
        }

        void RenderUserCode()
        {
            var qrCodeImage = CodeGenerator.GenerateQrCode(lblUserToken.Text);
            imgUserCode.Image = UserTokenCode = qrCodeImage;
        }

        bool IsInputValid()
        {
            if (!Validation.IsStringValid(txtUsername.Text, 5, 20))
                return false;
            else if (!Validation.IsPasswordValid(txtPassword.Text))
                return false;
            else if (!Validation.IsPasswordValid(txtRepeatPassword.Text))
                return false;
            else if (txtRepeatPassword.Text != txtPassword.Text)
                return false;
            else if (!Validation.IsStringValid(txtFirstName.Text, 3, 20))
                return false;
            else if (!Validation.IsStringValid(txtLastName.Text, 3, 20))
                return false;
            else if (!Validation.IsEmailValid(txtEmailAddress.Text))
                return false;
            else if (!Validation.IsPINValid(txtPinCode.Text))
                return false;
            else if (dpdRole.selectedValue == null)
                return false;
            else
                return true;
        }

        #endregion

        #region UI

        void InitializeUI()
        {
            //Get Color from Class According Properties.Settings            
            SoftColor = UserInterface.SoftColor;
            Color HoverColor = Color.FromArgb(200, SoftColor);

            //Change Color
            txtFirstName.BorderColorFocused = txtLastName.BorderColorFocused = txtPinCode.BorderColorMouseHover = txtLastName.BorderColorMouseHover = txtFirstName.BorderColorMouseHover = txtEmailAddress.BorderColorMouseHover = txtEmailAddress.BorderColorFocused =
                txtPassword.BorderColorFocused = txtPassword.BorderColorMouseHover = txtRepeatPassword.BorderColorMouseHover = txtRepeatPassword.BorderColorFocused =
                txtUsername.BorderColorFocused = txtUsername.BorderColorMouseHover = txtPinCode.BorderColorFocused =
                btnSave.Activecolor = btnSave.Normalcolor = btnSave.BackColor =
                btnPrintToken.Activecolor = btnPrintToken.Normalcolor = btnPrintToken.BackColor =
                btnCopyUserToken.Activecolor = btnCopyUserToken.Normalcolor = btnCopyUserToken.BackColor =
                btnChooseImage.Activecolor = btnChooseImage.Normalcolor = btnDeleteProfileImage.Normalcolor = btnDeleteProfileImage.BackColor = btnDeleteProfileImage.Activecolor = btnChooseImage.BackColor = SoftColor;

            //HoverColor
            btnSave.OnHovercolor = btnChooseImage.OnHovercolor = btnPrintToken.OnHovercolor = btnDeleteProfileImage.OnHovercolor = btnCopyUserToken.OnHovercolor = HoverColor;

            //Color Images
            ImageUtil.ColorImageButton(imgbtnExit, ColorGray);
            ImageUtil.ColorImageButton(imgbtnGoFirstFields, ColorGray);
            ImageUtil.ColorImageButton(imgbtnGoSecondFields, ColorGray);

            //Size
            this.Size = ControlDefaultSize;

            //Default Location
            imgbtnExit.Location = new Point(847, 12);
        }

        void ReArrangePanel(bool pnlVisible = false)
        {
            //Change Visibility & Location
            if (IsUserRegistered)
                pnlRegisteredUser.Visible = true;

            else
            {
                pnlSecurity.Visible = pnlVisible;
                pnlSecurity.Location = SecurityPnlFieldLocation;
            }

        }

        void ToPanel(ActiveField activeField)
        {
            if (activeField == ActiveField.Details)
            {
                //Change Panel Location
                pnlFirstFields.Location = ActiveFieldLocation;
                pnlSecondFields.Location = InActiveFieldLocation;
            }
            else if (activeField == ActiveField.SecurityOrInsights)
            {
                //Change Panel Location
                pnlFirstFields.Location = InActiveFieldLocation;
                pnlSecondFields.Location = ActiveFieldLocation;

                //Rearrange Panel
                ReArrangePanel(true);
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
                foreach (Control control in pnlFirstFields.Controls)
                    if (control is Label)
                        Translation.TranslateControl(control);

                foreach (Control control in pnlSecurity.Controls)
                    if (control is Label)
                        Translation.TranslateControl(control);

                Translation.TranslateControl(text_yourUserQrCodeTok);
                Translation.TranslateControl(text_userqrcodetok);
                Translation.TranslateControl(text_SalesHistory);

                Translation.TranslateControl(text_ThisMonth);
                Translation.TranslateControl(text_ThisWeek);
                Translation.TranslateControl(text_Today_cd);

                Translation.TranslateControl(btnSave);
                Translation.TranslateControl(btnChooseImage);
                Translation.TranslateControl(text_PImage);
                Translation.TranslateControl(text_BackToFields);
            }

        }

        #endregion

        #region OnClose

        #endregion
    }
}
