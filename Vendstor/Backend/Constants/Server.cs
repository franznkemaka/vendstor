namespace Vendstor.Backend.Constants
{
    public static class ServerConstants
    {
        public static string ServerFolderPath = "uc/";
        /// <summary>
        /// Indicates the web socket url to connect to
        /// </summary>
        public static string ScannerWebSocketUrl = "http://vendstor.rigle.co:443";
        /// <summary>
        /// The default server url
        /// </summary>
        public static string Url = "http://rigle.co/vendstor";
        /// <summary>
        /// The backend endpoint used to translate a text
        /// </summary>
        public static string TranslationApiUrl = "http://rigle.co/vendstor/api/translation/translate";
        /// <summary>
        /// API authorization key for the request
        /// </summary>
        public static string AuthKey = "9d8a22dcff084215cd7e6187427c9b1d";
    }

    public static class SocketConstants
    {
        /// <summary>
        /// socket connection event name 
        /// </summary>
        public static readonly string EventConnection = "Connection";

        /// <summary>
        /// scan socket event name 
        /// </summary>
        public static readonly string EventScan = "Scan";
    }
}
