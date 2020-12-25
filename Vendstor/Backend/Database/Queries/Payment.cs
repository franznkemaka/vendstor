using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using System.Data;

// Vendstor
using Vendstor.Backend.Utils;
using Vendstor.Backend.Constants;

namespace Vendstor.Backend.Database.Queries
{
    /// <summary>
    /// Manage Payments
    /// </summary>
    public class Payment : Query
    {
        /// <summary>
        /// Checks if Id is valid
        /// </summary>       
        /// <returns></returns>
        public bool IsValid(Objects.Payment payment)
        {
            bool isValid;
            try
            {
                //Open Connection
                Database.Connection.Open();

                string query = "SELECT PaymentId FROM Payments WHERE PaymentId=@PaymentId";
                MySqlCommand Command = new MySqlCommand(query, Database.Connection);
                Command.Parameters.AddWithValue("PaymentId", payment.Id);
                MySqlDataReader DataReader = Command.ExecuteReader();
                if (!DataReader.HasRows)
                    isValid = false;
                else
                    isValid = true;

                //Close Connection
                Database.Connection.Close();
            }
            catch (MySqlException e)
            {
                Logger.QueryError(e, "Payment", "Verifying Id");
                isValid = false;
            }

            //Close Connection if Open
            if (Database.Connection.State == ConnectionState.Open)
                Database.Connection.Close();

            return isValid;
        }        
    }
}
