namespace Vendstor.Backend.Constants
{
    public static class Constants
    {
        /// <summary>
        /// This is the url to access the remote REST API.
        /// </summary>
        public static readonly string ApiUrl = "http://rigle.co/vendstor/api";
        /// <summary>
        /// This is the token used to authenticate with the remote REST API
        /// </summary>
        public static readonly string ApiAuthToken = "9d8a22dcff084215cd7e6187427c9b1d";
        /// <summary>
        /// This is the unique ID which indicates which software in the database is installed
        /// This is used to determine if the software is outdated or not
        /// </summary>
        public static readonly string SoftwareId = "a0e6d48c2ba4db74e55ca4f6565aad4d";
    }
}
