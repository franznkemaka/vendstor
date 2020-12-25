using System;
using MySql.Data.MySqlClient;
using System.Data;

// Vendstor
using Vendstor.Backend.Utils;

namespace Vendstor.Backend.Database
{
    public static class Database
    {
        //Default ServerCredentials
        public static string DefaultConnectionString = $"Server=YOUR_DATABASE_HOST_HERE;Database=Vendstor;Uid=YOUR_DATABASE_USERNAME;Pwd=YOUR_DATABASE_PASSWORD;";
        readonly static string AdditionalConnectionStrings = " Convert Zero Datetime=True";

        public static MySqlConnection Connection;

        static Database()
        {
            var connectionString = DefaultConnectionString;
            var customConnectionString = Properties.Settings.Default.CustomConnectionString;
            var useDefault = Properties.Settings.Default.UseDefaultSettings;

            if (ServerUtil.IsConnectionStringOK(customConnectionString) && !useDefault)
                connectionString = customConnectionString;

            connectionString += AdditionalConnectionStrings;
            Connection = new MySqlConnection(connectionString);
        }

        /// <summary>
        /// Validate ConnectionString
        /// </summary>
        /// <param name="connectionString"></param>
        /// <returns></returns>
        public static bool IsConnectionStringValid(string connectionString)
        {
            MySqlConnection connection = new MySqlConnection(connectionString);
            try
            {
                if(connection.State == ConnectionState.Open)
                    return true;
                connection.Open();
                connection.Close();
                return true;

            }catch { return false;  }
        }
        
        /// <summary>
        /// Returns Connection State in ConnectionState, compare using ConnectionState
        /// </summary>
        /// <returns></returns>
        public static ConnectionState State()
        {
            ConnectionState connectionState = 0;
            //get MySQL State
            try
            {
                if (Connection.State != ConnectionState.Open)
                {
                    Connection.Open();
                    connectionState = Connection.State;
                    Connection.Close();
                }
                else
                    //Connection is already opened get State
                    connectionState = Connection.State;
            }
            catch (MySqlException e)
            {
                //Add Error
                Logger.QueryError(e, "Database", "State()");

                connectionState = Connection.State;
            }
            return connectionState;
        }

        public static void Open(MySqlConnection connection)
        {
            if (connection.State == ConnectionState.Open)
            {
                connection.Close();

                connection.Open();
            }
            else
                connection.Open();

            //# This is done to avoid to use a NonQueryConnection with a ReaderConnection
            //Create a new connection    
        }

        public static void Close()
        {

        }

        public static void Reconnect()
        {
            if (Connection.State == ConnectionState.Open)
                Connection.Close();
            Connection.Open();
        }
        public static void Disonnect()
        {
            if (Connection.State == ConnectionState.Open)
                Connection.Close();
            Connection.Close();
        }


        public static int GetServerStatusCode()
        {
            return 0;
        }
        public static bool IsServerStateOK()
        {
            if (State() == ConnectionState.Open)
                return true;
            else
                return false;
        }
    }
}
