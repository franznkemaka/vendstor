using System;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Net;
using System.Net.NetworkInformation;
using System.Security.Cryptography;
using System.IO;
using System.Data;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

using Vendstor.Modals;
using Vendstor.Backend.Constants;

namespace Vendstor.Backend.Utils
{
    public static class ServerUtil
    {
        public static bool IsDatabaseAvailable
        {
            get
            {
                try
                {
                    if (Database.Database.Connection.State == ConnectionState.Open)
                        return true;

                    Database.Database.Connection.Open();
                    Database.Database.Connection.Close();
                    return true;
                }
                catch { return false; }
            }
        }

        public static bool IsServerAvailable
        {
            get { return IsEndpointAvailable("/"); }
        }

        public static bool ReportStatus()
        {
            bool status = true;
            if (!IsDatabaseAvailable)
            {
                new Alert
                {
                    Title = " Internal Server Error",
                    Message = "Unable to connect to the Database, please report this to the admin Franz Nkemaka.",
                    AlertPositionIndex = Alert.AlertPosition.BottomRight,
                    AlertTypeIndex = Alert.AlertType.Error,
                    TranslateMessage = false,
                    TranslateTitle = false,
                }.Show();

                status = false;
            }

            if (!IsServerAvailable)
            {
                new Alert
                {
                    Title = " Internal Server Error",
                    Message = "Unable to connect to the Server, please report this to the admin Franz Nkemaka.",
                    AlertPositionIndex = Alert.AlertPosition.BottomRight,
                    AlertTypeIndex = Alert.AlertType.Error,
                    TranslateMessage = false,
                    TranslateTitle = false,
                }.Show();

                status = false;
            }

            if (!IsNetworkAvailable())
            {
                new Alert
                {
                    Title = " No Internet Available ",
                    Message = "You're not connected to the Internet. please check your network and try again.",
                    AlertPositionIndex = Alert.AlertPosition.BottomRight,
                    AlertTypeIndex = Alert.AlertType.Error,
                    TranslateMessage = false,
                    TranslateTitle = false,
                }.Show();

                status = false;
            }

            if (!IsServerAvailable && Translation.CanTranslate())
            {
                new Alert
                {
                    Title = " Unable to Translate ",
                    Message = "The Translation API is unavaible. please try again later or cantact the admin Franz Nkemaka.",
                    AlertPositionIndex = Alert.AlertPosition.BottomRight,
                    AlertTypeIndex = Alert.AlertType.Error,
                    TranslateMessage = false,
                    TranslateTitle = false,
                }.Show();

                return false;
            }
            return status;
        }

        /// <summary>
        /// Check Network Connectivity
        /// </summary>
        /// <param name="minimumSpeed"> minimum acceptable Speed default : 10000000</param>
        /// <returns></returns>
        public static bool IsNetworkAvailable(long minimumSpeed = 10000000)
        {
            /** Code SRC : Simon Mourier, Dec 1 2011 - Stack Overflow */

            if (!NetworkInterface.GetIsNetworkAvailable())
                return false;

            foreach (NetworkInterface networkInterface in NetworkInterface.GetAllNetworkInterfaces())
            {
                // Discard Because of Standard reasons
                if ((networkInterface.OperationalStatus != OperationalStatus.Up) ||
                    (networkInterface.NetworkInterfaceType == NetworkInterfaceType.Loopback) ||
                    (networkInterface.NetworkInterfaceType == NetworkInterfaceType.Tunnel))
                    continue;

                // This Allow to filter Modems, Serial, etc.
                // 10000000 As A Minimum Speed for most Cases
                if (networkInterface.Speed < minimumSpeed)
                    continue;

                // Discard Virtual Cards (Virtual Box, Virtual PC, Etc.)
                if ((networkInterface.Description.IndexOf("virtual", StringComparison.OrdinalIgnoreCase) >= 0) ||
                    (networkInterface.Name.IndexOf("virtual", StringComparison.OrdinalIgnoreCase) >= 0))
                    continue;

                // Discard "Microsoft Loopback Adapter", it will not show as NetworkInterfaceType.Loopback but as Ethernet Card.
                if (networkInterface.Description.Equals("Microsoft Loopback Adapter", StringComparison.OrdinalIgnoreCase))
                    continue;

                return true;
            }
            return false;
        }

        /// <summary>
        /// Check if Endpoint is Avialable
        /// </summary>
        public static bool IsEndpointAvailable(string endpoint = null)
        {
            try
            {
                var url = ServerConstants.Url + endpoint;
                WebClient webClient = new WebClient { Encoding = Encoding.UTF8 };
                var response = webClient.DownloadString(new Uri(url));
                return true;
            }
            catch (WebException) { return false; }
        }
        public static bool IsConnectionStringOK(string connectionString)
        {
            return Database.Database.IsConnectionStringValid(connectionString);
        }

        /// <summary>
        /// retuns severStatus Image [Green OK, Red ERROR [ERR500]]
        public static Image GetServerStatusImage()
        {
            if (IsDatabaseAvailable && IsServerAvailable)
                return Properties.Resources.led_green;
            else
                return Properties.Resources.led_blinksred;
        }

        public static object DownloadString(string url)
        {
            try
            {
                using (WebClient webClient = new WebClient { Encoding = Encoding.UTF8 })
                {
                    return webClient.DownloadString(new Uri(url));
                }
            }
            catch { return null;  };
        }

        public static JObject GetResponse(string id, string authToken)
        {
            var url = string.Format(@"{0}/software?softwareId={1}&authToken={2}", Constants.Constants.ApiUrl, id, authToken);
            var jsonData = DownloadString(url);

            if (!DataUtil.IsJson(jsonData.ToString()))
                return null;

            return (JObject)JsonConvert.DeserializeObject(jsonData.ToString());
        }


        /// <summary>
        /// Get Image From URl
        /// </summary>
        public static Image GetImageFromUrl(string imageUrl, bool elipseCorners = false)
        {
            Image image = Properties.Resources.n_a;
            if (IsNetworkAvailable())
            {
                try
                {
                    WebClient webClient = new WebClient();
                    byte[] bytes = webClient.DownloadData(imageUrl);
                    MemoryStream memoryStream = new MemoryStream(bytes);
                    image = Image.FromStream(memoryStream);
                }
                catch (Exception e)
                {
                    Logger.Error(e, 500, "ServerUtil", "GetImageFromURL");
                }
            }

            if (elipseCorners)
                image = ImageUtil.OvalImage(image);
            return image;
        }

        /// <summary>
        /// Get Image From Server
        /// </summary>
        public static Image GetImageFromServerUrl(string imageUrl, bool isFullUrl = false, string rootUrl = null, bool elipseCorners = false)
        {
            //Default Image
            Image image = Properties.Resources.n_a;
            rootUrl = rootUrl ?? ServerConstants.Url + "/";
            var imagePath = (!isFullUrl) ? rootUrl + imageUrl : imageUrl;

            if (IsNetworkAvailable())
            {
                try
                {
                    //Download Image With FullPath
                    WebClient webClient = new WebClient();
                    byte[] bytes = webClient.DownloadData(imagePath);
                    MemoryStream memoryStream = new MemoryStream(bytes);
                    image = Image.FromStream(memoryStream);
                }
                catch (Exception e)
                {
                    Logger.Error(e, 500, "ServerUtil", "GetImageFromURL");
                }
            }

            if (elipseCorners)
                image = ImageUtil.OvalImage(image);
            return image;
        }

        /// <summary>    
        /// Generate a random token of arg[allowedChars] with length arg[tokenLength]
        /// </summary>
        public static string GenerateToken(int tokenLength, string allowedChars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789")
        {
            var outOfRange = byte.MaxValue + 1 - (byte.MaxValue + 1) % allowedChars.Length;

            return string.Concat(
                Enumerable
                    .Repeat(0, int.MaxValue)
                    .Select(e => GenRandomByte())
                    .Where(randomByte => randomByte < outOfRange)
                    .Take(tokenLength)
                    .Select(randomByte => allowedChars[randomByte % allowedChars.Length])
            );
        }

        /// <summary>
        /// Generate a Random Integer Between int Minimum And int Maximum
        /// </summary>
        public static int GenerateRandomNum(int minChar = 1000, int maxChar = 9999)
        {
            Random random = new Random();
            return random.Next(minChar, maxChar);
        }

        public static string RandomDigits(int length)
        {
            var random = new Random();
            string s = string.Empty;
            for (int i = 0; i < length; i++)
                s = String.Concat(s, random.Next(10).ToString());
            return s;
        }

        private static byte GenRandomByte()
        {
            using (var randomizationProvider = new RNGCryptoServiceProvider())
            {
                var randomBytes = new byte[1];
                randomizationProvider.GetBytes(randomBytes);
                return randomBytes.Single();
            }
        }
    }
}
