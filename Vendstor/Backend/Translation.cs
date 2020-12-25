using System;
using System.Text;
using System.Net;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Windows.Forms;

using Vendstor.Backend.Utils;
using Vendstor.Backend.Constants;

namespace Vendstor.Backend
{
    public static class Translation
    {
        //PR : use settings for constants instead class defined variables
        readonly static string LanguageLocalPath = $@"RigleSoft\Vendstor\Resources\Languages\Data\";
        private readonly static string LanguageFileExtension = ".json";
        static string LanguagePath
        {
            // languagePath without locale and file extension
            get { return $@"C:\Users\{Environment.UserName}\AppData\Local\{LanguageLocalPath}"; }
        }

        static Translation()
        {
            if (!Directory.Exists(LanguagePath))
                Directory.CreateDirectory(LanguagePath);
        }

        /// <summary>
        /// Translate String
        /// </summary>
        public static string Translate(string originalString, string lang = "auto", string locale = null)
        {
            string translation;
            locale = locale ?? Properties.Settings.Default.SoftLocale;

            if (locale == "en")
                return originalString;

            if (IsLanguageFileValid(locale))
                //get Language translation from json file
                translation = TranslateUsingFile(originalString, locale);
            else
                //Translate using api [Network]
                translation = TranslateUsingAPI(originalString, lang, locale);

            return translation;
        }

        public static void TranslateControl(Control control, string text = null)
        {
            if (string.IsNullOrEmpty(text))
                control.Text = Translate(control.Text);
            else
                control.Text = Translate(text);
        }

        #region Methods : 

        /// <summary>
        /// Get Translation using local Files
        /// </summary>
        private static string TranslateUsingFile(string originalString, string locale)
        {
            string translation;

            if (IsExistsTranslation(originalString, locale))
                //get Language translation from json file
                translation = GetTranslation(originalString, locale);
            else
                //Translate Using API
                translation = TranslateUsingAPI(originalString, "auto", locale);

            return translation;
        }

        /// <summary>
        /// Get Translation either using API or Local Files
        /// </summary>
        private static string GetTranslation(string originalString, string locale)
        {
            var currentLanguageFile = GetLanguagePath(locale);
            string translation;

            //Json string data
            var jsonData = File.ReadAllText(currentLanguageFile);
            try
            {
                //Get Translation(value) by OriginalString(Key)
                var data = (JObject)JsonConvert.DeserializeObject(jsonData);
                translation = data[originalString].Value<string>();
            }
            catch
            {
                //Use API
                translation = TranslateWithAPI(originalString, "auto", locale);
            }

            return translation;
        }

        /// <summary>
        /// Get Translation using API
        /// </summary>
        private static string TranslateUsingAPI(string originalString, string lang = "auto", string locale = null)
        {
            string translation;
            locale = locale ?? Properties.Settings.Default.SoftLocale;

            //Translate using Rigle Translate API
            translation = TranslateWithAPI(originalString, lang, locale);

            //Save Translation locally
            SaveTranslation(originalString, translation, locale);

            return translation;
        }

        /// <summary>
        /// Save Translation to Local Files
        /// </summary>
        private static void SaveTranslation(string originalString, string translation, string locale)
        {
            var currentLanguageFile = GetLanguagePath(locale);
            if (!IsLanguageFileValid(locale))
            {
                //Logger.Log("Corrumpt or unfound language resource file", "Translation", "SaveTranslation", "500");
                if (!File.Exists(currentLanguageFile))
                    File.Delete(currentLanguageFile);

                File.Create(currentLanguageFile).Dispose();
            }

            var jsonData = File.ReadAllText(currentLanguageFile);
            JObject jsonObject;

            if (DataUtil.IsJson(jsonData))
                //Convert string to object ) (DeserializeObject)
                jsonObject = (JObject)JsonConvert.DeserializeObject(jsonData);
            else
                jsonObject = new JObject();

            try
            {
                //Add new data to existing language data [Key, Value] if not exists
                if (jsonObject[originalString] == null)
                    jsonObject.Add(originalString, translation);
            }
            catch
            {
                //Add new data to existing language data [Key, Value]
                jsonObject.Add(originalString, translation);
            }
            //Convert Obj to string (SerializeObject)
            var json = JsonConvert.SerializeObject(jsonObject, Formatting.Indented);

            //Save data  to absolutePath
            File.WriteAllText(currentLanguageFile, json);
        }

        /// <summary>
        /// Tanslate Using WebRequest
        /// </summary>
        private static string TranslateWithAPI(string originalString, string source = "auto", string locale = null)
        {
            string translation = null;
            locale = locale ?? Properties.Settings.Default.SoftLocale;

            //URL
            var q = originalString.Replace("#", " %23");
            var qeury = $"{ ServerConstants.TranslationApiUrl }?q={ q }&source={ source }&target={ locale}&authToken={ServerConstants.AuthKey}";
            try
            {
                //Send Request
                using (WebClient webClient = new WebClient { Encoding = Encoding.UTF8 })
                {
                    translation = webClient.DownloadString(new Uri(qeury));
                }
                return translation;
            }
            catch (Exception e)
            {
                Logger.Error(e, 4000, "Translation", "TranslateWithAPI");
                return originalString;
            }
        }

        #endregion

        public static bool CanTranslate(string locale = "en")
        {
            return Properties.Settings.Default.SoftLocale != locale;
        }

        public static bool IsPossible(string locale = null)
        {
            return Properties.Settings.Default.IsTranslationPossible;
        }

        public static bool IsPossible(bool forceUpdate)
        {
            var locale = Properties.Settings.Default.SoftLocale;
            if (locale == "en")
                return false;
            else if (!ServerUtil.IsNetworkAvailable())
                return false;
            else if (!ServerUtil.IsServerAvailable)
                return false;
            else
                return true;
        }

        public static void ForceUpdate()
        {
            Properties.Settings.Default.IsTranslationPossible = IsPossible(true);
            Properties.Settings.Default.Save();
        }

        private static string GetLanguagePath(string locale)
        {
            return LanguagePath + locale + LanguageFileExtension;
        }

        /// <summary>
        /// Check if a language file is valid
        /// </summary>
        private static bool IsLanguageFileValid(string locale)
        {
            var currentLanguageFile = GetLanguagePath(locale);
            if (!File.Exists(currentLanguageFile))
                return false;
            else if (!DataUtil.IsJson(File.ReadAllText(currentLanguageFile)))
                return false;
            else
                return true;
        }

        /// <summary>
        /// Check if the translation of the particular arg OriginalString,
        /// exists or not
        /// </summary>
        private static bool IsExistsTranslation(string originalString, string locale)
        {
            var currentLanguageFile = GetLanguagePath(locale);
            var data = File.ReadAllText(currentLanguageFile);

            if (!DataUtil.IsJson(data))
                return false;

            // check if data contains OriginalString
            else if (!data.Contains(originalString))
                return false;
            else
                return true;
        }

        #region Using Resource Files
        /*
        //Get Text String From  /Languages/LanguageData.xml
        public string GetString(string _Lang, out bool ErrorOccured, string _Locale = null, string _BaseName = null, string _LangFilePath = null)
        {
            //Props
            string _String = null;
            _LangFilePath = (_LangFilePath != null) ? _LangFilePath : Application.StartupPath + "/Languages/";
            _BaseName = (_BaseName != null) ? _BaseName : "resource";
            _Locale = (_Locale == null) ? Properties.Settings.Default.SoftLocale : _Locale;

            try
            {   
                LanguageDataSet languageDataSet = new LanguageDataSet();

                //Load Language
                languageDataSet.ReadXml(string.Format("{0}/Languages/LanguageData.xml", Application.StartupPath));

                CultureInfo _CultureInfo = new CultureInfo(_Locale);
                Thread.CurrentThread.CurrentCulture = _CultureInfo;
                Thread.CurrentThread.CurrentUICulture = _CultureInfo;
                ResourceManager _ResourceManager = ResourceManager.CreateFileBasedResourceManager(_BaseName, _LangFilePath, null);

                if (_ResourceManager.GetString(_Lang) != null)
                    _String = _ResourceManager.GetString(_Lang);

               
                ErrorOccured = false;
            }
            catch
            {
                ErrorOccured = true;
                //Null : LanguageData.xml Is Empty
            }

            return _String;
        }

        //Save Language XML
        public void SaveLanguage(LanguageDataSet languageDataSet, out bool ErrorOccured)
        {
            try
            {
                //Save Changes Under User Language Settings Path
                languageDataSet.WriteXml(string.Format("{0}/Languages/LanguageData.xml", Application.StartupPath));
                ResourceWriter rwDE = new ResourceWriter(Application.StartupPath + "/Languages/resource.de-DE.resources");
                ResourceWriter rwEN = new ResourceWriter(Application.StartupPath + "/Languages/resource.en-US.resources");
                ResourceWriter rwFR = new ResourceWriter(Application.StartupPath + "/Languages/resource.fr-FR.resources");

                foreach (LanguageDataSet.LanguagesRow row in languageDataSet.Languages.Rows)
                {
                    rwDE.AddResource(row.Lang, row.Deutsch);
                    rwEN.AddResource(row.Lang, row.English);
                    rwFR.AddResource(row.Lang, row.Français);
                }

                rwDE.Generate();
                rwEN.Generate();
                rwFR.Generate();

                rwDE.Close();
                rwEN.Close();
                rwFR.Close();

                ErrorOccured = false;
            }
            catch
            {
                ErrorOccured = true;                
            }

            
        }
        
        //Load Language XML
        public void LoadLanguage(LanguageDataSet languageDataSet, out bool ErrorOccured)
        {            
            try
            {
                languageDataSet.ReadXml(string.Format("{0}/Languages/LanguageData.xml", Application.StartupPath));
                ErrorOccured = false;
            }
            catch
            {
                ErrorOccured = true;
                //Null : LanguageData.xml Is Empty
            }
        }*/

        #endregion
    }
}
