using System;
using System.IO;
using System.Windows.Forms;
using System.Runtime.Serialization.Formatters.Binary;
using System.Globalization;
using System.Linq;
using System.Collections.Generic;

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;


using Vendstor.Modals;

using Vendstor.Forms.Auth;
using Vendstor.Backend.Libraries;
using Vendstor.Backend.Database.Queries;
using Vendstor.Backend.Data;

namespace Vendstor.Backend.Utils
{
    public static class Util
    {
        public enum RequiredPermission { User, Admin, Super, Developer, FranzNkemaka }
        public enum AlertParserType
        {
            NotFound, BadHappened, Created, Error, ErrorUpdating, RedeemFailed,
            ErrorCreating, ErrorDeleting, Deleted, Updated, Canceled, Custom
        }

        public enum PermissionAlertType { Alert, Message, None }

        public static class Methods
        {
            /// <summary>
            ///  Align Control To Parent [By Default To Center]
            /// </summary>
            /// <param name="TargetControl"> Control To Align </param>
            /// <param name="ParentControl"> Parent Control, Where Control Is Located</param>
            /// <param name="AlignIndex"> Index To Align 0 = HCenter, 1 = VCenter, 2 = VHCenter [H=Horizontal, V=Vertical] </param>
            public enum AlignIndex { HCenter, VCenter, VHCenter }
            public static void AlignToParent(Control targetControl, Control parentControl, AlignIndex alignIndex = AlignIndex.HCenter)
            {
                switch (alignIndex)
                {
                    case AlignIndex.HCenter:
                        targetControl.Left = (parentControl.ClientSize.Width - targetControl.Width) / 2;
                        break;

                    case AlignIndex.VCenter:
                        targetControl.Top = (parentControl.ClientSize.Height - targetControl.Height) / 2;
                        break;

                    case AlignIndex.VHCenter:
                        targetControl.Left = (parentControl.ClientSize.Width - targetControl.Width) / 2;
                        targetControl.Top = (parentControl.ClientSize.Height - targetControl.Height) / 2;
                        break;
                }
            }

            public static void SetIcon(Form form)
            {
                form.Icon = Properties.Resources.vendstor_big;
            }
        }

        public static class Object
        {
            /// <summary>
            /// Base64 Encode Object to string
            /// </summary>
            public static string ToString(object obj)
            {
                try
                {
                    using (MemoryStream ms = new MemoryStream())
                    {
                        new BinaryFormatter().Serialize(ms, obj);
                        return Convert.ToBase64String(ms.ToArray());
                    }
                }
                catch { return null; }
            }

            /// <summary>
            /// Decode Base64 Encode string to Object
            /// </summary>
            public static object ToObject(string base64String)
            {
                try
                {
                    byte[] bytes = Convert.FromBase64String(base64String);
                    using (MemoryStream ms = new MemoryStream(bytes, 0, bytes.Length))
                    {
                        ms.Write(bytes, 0, bytes.Length);
                        ms.Position = 0;
                        return new BinaryFormatter().Deserialize(ms);
                    }
                }
                catch { return null; }
            }
        }

        public static class Data
        {
            public static Objects.Store HandshakeStore(Form currentForm, bool logOut = true)
            {
                if (!QueryController.Store.IsIdValid())
                {
                    if (logOut)
                        Func.LogStoreOut(currentForm);
                }
                else
                    SynchronizeStore();
                return GetStore();
            }

            public static Objects.User HandshakeUser(Form currentForm, bool logOut = true)
            {
                if (!QueryController.User.IsIdValid())
                {

                    if (logOut)
                        Func.LogUserOut(currentForm);
                }
                else
                    SynchronizeStore();
                return GetUser();
            }

            /// <summary>
            /// 
            /// </summary>
            public static Objects.Store GetStore()
            {
                var storeEncoded = Properties.Settings.Default.Store;
                if (DataUtil.IsBase64(storeEncoded))
                {
                    var store = (Objects.Store)Object.ToObject(storeEncoded);
                    return store;
                }
                else
                    return new Objects.Store();
            }

            /// <summary>
            /// Get Store properties from settings
            /// </summary>
            /// <param name="store"> Store Object </param>
            public static void SynchronizeStore(string storeId = null)
            {
                Objects.Store store = new Objects.Store
                {
                    Id = storeId ?? Properties.Settings.Default.StoreId
                };
                if (Validation.IsTokenValid(store.Id))
                {
                    var response = QueryController.Store.Get(store);
                    // Check response StatusCode
                    if (response.StatusCode == 200)
                    {
                        var _store = (Objects.Store)response.Data;
                        Properties.Settings.Default.StoreId = _store.Id;
                        var storeEncoded = Object.ToString(_store);
                        // Update Store Infos                        
                        Properties.Settings.Default.Store = storeEncoded;
                    }
                }

                Properties.Settings.Default.Save();
            }

            /// <summary>
            /// Save User properties to settings
            /// </summary>
            /// <param name="user"> User Object</param>
            /// 
            public static void SynchronizeUser(string userId = null, bool fetch = true)
            {
                Objects.User user = new Objects.User
                {
                    Id = userId ?? Properties.Settings.Default.UserId
                };
                if (fetch)
                {
                    QueryController.User.UpdateSettings(userId);

                    if (Validation.IsTokenValid(user.Id))
                    {
                        var response = QueryController.User.Get(user);
                        // Check response StatusCode
                        if (response.StatusCode == 200)
                        {
                            user = (Objects.User)response.Data;
                            Properties.Settings.Default.UserId = user.Id;

                        }
                    }
                }
                var userEncoded = Object.ToString(user);
                // Update Store Infos                        
                Properties.Settings.Default.User = userEncoded;
                Properties.Settings.Default.Save();
            }

            /// <summary>
            /// 
            /// </summary>
            public static Objects.User GetUser()
            {
                try
                {
                    var userEncoded = Properties.Settings.Default.User;
                    if (DataUtil.IsBase64(userEncoded))
                    {
                        var store = (Objects.User)Object.ToObject(userEncoded);
                        return store;
                    }
                    else
                        return new Objects.User();
                }
                catch { return new Objects.User(); }
            }
        }

        public static class Func
        {
            public static void LogStoreOut(Form parentForm)
            {
                try
                {
                    //Reset Store 
                    Properties.Settings.Default.StoreId = null;
                    Properties.Settings.Default.Store = "";

                    //Form Login
                    StoreAuth storeAuth = new StoreAuth
                    {
                        //Props
                        TopMost = true,
                        WindowState = parentForm.WindowState
                    };

                    Extensions.HideAndShow(parentForm, storeAuth);
                }
                catch (Exception)
                {
                    Extensions.ExitApplication();
                }


            }
            public static void LogUserOut(Form parentForm)
            {
                try
                {
                    //Reset User 
                    Properties.Settings.Default.UserId = null;
                    Properties.Settings.Default.User = "";

                    //Form Login
                    UserLogin userLogin = new UserLogin
                    {
                        //Props
                        TopMost = true,
                        WindowState = parentForm.WindowState
                    };

                    userLogin.ShowDialog();
                }
                catch (Exception)
                {
                    Extensions.ExitApplication();
                }
            }

            public static bool IsUserAllowed(Objects.User user, PermissionAlertType alertType = PermissionAlertType.None, Form form = null, RequiredPermission reqPermission = RequiredPermission.Admin)
            {
                if (user == null)
                    return false;

                bool isAllowed = true;
                switch (reqPermission)
                {
                    case RequiredPermission.Admin:
                        if (user.Role.ToLower() != "admin") isAllowed = false;
                        break;
                }

                //Alert User
                if (!isAllowed)
                {
                    switch (alertType)
                    {
                        case PermissionAlertType.Alert:
                            Alert.Show("Limited Permission", "You must be an Admin to perform this action.", Alert.AlertType.Warning);
                            break;
                        case PermissionAlertType.Message:
                            MessageParser.Permission(caller: form);
                            break;
                        case PermissionAlertType.None:
                            break;
                    }
                }

                return isAllowed;
            }

            public static List<string> GetAllCountries()
            {
                return CultureInfo.GetCultures(CultureTypes.SpecificCultures)
                .Select(x => new RegionInfo(x.LCID))
                .Select(x => x.DisplayName)
                .Distinct()
                .OrderBy(x => x)
                .ToList();
            }

            public static void AddCountriesToDropDowns(ComboBox comboBox, Bunifu.Framework.UI.BunifuDropdown dropdown)
            {
                var countries = GetAllCountries();
                foreach (var country in countries)
                {
                    comboBox.Items.Add(country);
                    dropdown.AddItem(country);
                }
            }

            public static Enums.TokenType GetTokenType(object type)
            {
                switch ((type.ToString()).ToLower())
                {
                    case "qr":
                        return Enums.TokenType.QrCode;
                    case "code128":
                        return Enums.TokenType.CODE128;
                    case "code39":
                        return Enums.TokenType.CODE39;
                    case "code93":
                        return Enums.TokenType.CODE93;
                    case "ean13":
                        return Enums.TokenType.EAN13;
                    case "ean8":
                        return Enums.TokenType.EAN8;
                    case "upce":
                        return Enums.TokenType.UPCE;
                    case "aztec":
                        return Enums.TokenType.AZTEC;
                    default:
                        return Enums.TokenType.None;
                }
            }
            
            static string InstallerExecutable
            {
                get { return $@"C:\Program Files\RigleSoft\Vendstor\Installer\Installer.exe"; }
            }
            public static void StartInstaller(Form parentForm)
            {
                // check if installer is there
                if (File.Exists(InstallerExecutable))
                {
                    System.Diagnostics.Process.Start(InstallerExecutable);
                    Extensions.ExitApplication();
                }
                else
                {
                    Extensions.ShowDialogWithBlur(parentForm, new MessageDialog
                    {
                        DialogButtonsIndex = MessageDialog.DialogButtons.One,
                        DialogIconIndex = MessageDialog.DialogIcon.Sorry,
                        ThirdBtnText = "Ok",
                        Title = "Error while trying to Update",
                        Message = $"Unable to find the Installer, please uninstall vendstor and re-install it",
                        TopMost = true,
                    }, Constants.UIConstants.MinBlurOpacity);
                    Extensions.ExitApplication();
                }
            }
        }

        public static class MessageParser
        {
            public static void Permission(string message = null, string title = null, Form caller = null)
            {
                title = title ?? " Sorry, you are not allowed to do this";
                message = message ?? "You must be an Admin to perform this action.";

                // Add Blur
                Forms.Blur blur = null;
                if (caller is Form)
                {
                    blur = new Forms.Blur(caller, 0.60);
                    blur.Show();
                }

                MessageDialog messageDialog = new MessageDialog
                {
                    DialogButtonsIndex = MessageDialog.DialogButtons.One,
                    DialogIconIndex = MessageDialog.DialogIcon.Sorry,
                    ThirdBtnText = "OK",
                    Title = title,
                    Message = message,

                    TopMost = true,
                };
                messageDialog.ShowDialog();

                //Remove Blur
                if (blur is Form)
                    blur.Close();
            }

            public static void Alert(string obj, AlertParserType parserAlertType, bool isMini = false, bool customTitle = false, Alert.AlertType alertType = Modals.Alert.AlertType.Error)
            {
                string title = "", message = "";
                switch (parserAlertType)
                {

                    case AlertParserType.BadHappened:
                        title = $"Error";
                        message = $"Something bad happened";
                        break;

                    case AlertParserType.NotFound:
                        title = $"{obj} Not Found";
                        message = $"The provided {obj} doesn't exist ";
                        break;
                    case AlertParserType.ErrorCreating:
                        title = $"Unable to create {obj}";
                        message = $"An error occured while trying to create {obj} ";
                        break;
                    case AlertParserType.ErrorUpdating:
                        title = $"Unable to update {obj}";
                        message = $"An error occured while trying to update {obj} ";
                        break;
                    case AlertParserType.ErrorDeleting:
                        title = $"Unable to delete {obj}";
                        message = $"An error occured while trying to delete {obj} ";
                        break;
                    case AlertParserType.RedeemFailed:
                        title = $"Unable to redeem";
                        message = $"Error redeeming please start over or cancel ";
                        break;

                    case AlertParserType.Created:
                        title = $"{obj} created";
                        message = $"{obj} was successfully created";
                        isMini = true;
                        alertType = Modals.Alert.AlertType.Success;
                        break;
                    case AlertParserType.Updated:
                        title = $"{obj} updated";
                        message = $"{obj} was successfully updated";
                        isMini = true;
                        alertType = Modals.Alert.AlertType.Success;
                        break;
                    case AlertParserType.Deleted:
                        title = $"{obj} deleted";
                        message = $"{obj} was successfully deleted";
                        isMini = true;
                        alertType = Modals.Alert.AlertType.Success;
                        break;


                    default:
                        break;
                }

                title = customTitle ? obj : title;

                Modals.Alert.Show(title, message, alertType, isMini: isMini);
            }
        }


        public static bool IsUpToDate(string softwareId, string currentVersion, out JObject app)
        {
            app = null;
            var response = ServerUtil.GetResponse(softwareId, Constants.Constants.ApiAuthToken);
            if (response != null)
            {
                app = response["data"]["software"].ToObject<JObject>();
                return response["data"]["software"]["version"].ToObject<string>() == currentVersion;
            }
            else
                return false;
        }

        public static bool IsUpdateRequired(JObject app)
        {
            DataUtil.GetJsonProperty(app, "isUpdateRequired", out object isUpdateRequired);
            return Convert.ToBoolean(isUpdateRequired);
        }

    }
}


