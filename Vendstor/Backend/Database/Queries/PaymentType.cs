using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;

// Vendstor
using Vendstor.Backend.Objects;

/** 
 * Copyright : © RigleSoft™,  Rigle™ - A Company of Franz Nkemaka™ -  All Rights Reserved 
 * Read README for more information. */

namespace Vendstor.Backend.Database.Queries
{
    /// <summary>
    /// Manage Payment Type : Create, Update, Get
    /// </summary>
    public class PaymentType : Query
    {
        /// <summary>
        /// Create a new Store's default Payment Type
        /// </summary>
        public bool Create(Objects.Store store)
        {
            bool response = false;
            var storeId = store.Id ?? Properties.Settings.Default.StoreId;
            try
            {
                //Open MySqlConnection
                Database.Connection.Open();
                var query = "INSERT INTO PaymentTypes (StoreId) VALUES (@StoreId)";

                //Execute Query With MySqlConnection
                MySqlCommand Command = new MySqlCommand(query, Database.Connection);
                Command.Parameters.AddWithValue("StoreId", storeId);
                Command.ExecuteNonQuery();

                //Close Connection
                Database.Connection.Close();

                return true;
            }
            catch (MySqlException e)
            {
                Logger.QueryError(e, "Payment Type", "Create");
            }

            //Close Connection if Open
            if (Database.Connection.State == ConnectionState.Open)
                Database.Connection.Close();

            return response;
        }

        /// <summary>
        /// Update Payment Type
        /// </summary>
        public bool Update(Objects.Store store)
        {
            bool response = false;

            var storeId = store.Id ?? Properties.Settings.Default.StoreId;
            var creditCardPayment = Func.ToString(store.PaymentTypes.CreditCard);
            var storeCreditPayment = Func.ToString(store.PaymentTypes.StoreCredit);

            try
            {
                Database.Connection.Open();
                var query = "UPDATE PaymentTypes SET CreditCard=@CreditCard, StoreCredit=@StoreCredit " +
                            "WHERE StoreId=@StoreId";

                MySqlCommand Command = new MySqlCommand(query, Database.Connection);
                Command.Parameters.AddWithValue("StoreId", storeId);
                Command.Parameters.AddWithValue("CreditCard", creditCardPayment);
                Command.Parameters.AddWithValue("StoreCredit", storeCreditPayment);
                Command.ExecuteNonQuery();

                Database.Connection.Close();

                return true;
            }
            catch (MySqlException e)
            {
                Logger.QueryError(e, "Payment Type", "Update");
            }

            if (Database.Connection.State == ConnectionState.Open)
                Database.Connection.Close();

            return response;
        }

        /// <summary>
        /// Get PaymentType 
        /// </summary>
        public PaymentTypes Get(Objects.Store store)
        {
            store.Id = store.Id ?? Properties.Settings.Default.StoreId;
            PaymentTypes paymentTypes = new PaymentTypes();
            try
            {
                Database.Connection.Open();

                string Query = "SELECT * FROM PaymentTypes WHERE StoreId=@StoreId";

                MySqlCommand Command = new MySqlCommand(Query, Database.Connection);

                Command.Parameters.AddWithValue("StoreId", store.Id);
                MySqlDataReader DataReader = Command.ExecuteReader();

                //Read Data
                while (DataReader.Read())
                {

                    paymentTypes.Cash = Func.ToBoolean(DataReader["Cash"].ToString());
                    paymentTypes.CreditCard = Func.ToBoolean(DataReader["CreditCard"].ToString());
                    paymentTypes.StoreCredit = Func.ToBoolean(DataReader["StoreCredit"].ToString());

                }


                Database.Connection.Close();
            }
            catch (MySqlException e)
            {
                Logger.QueryError(e, "PaymentType", "Get");
            }
            if (Database.Connection.State == ConnectionState.Open)
                Database.Connection.Close();

            return paymentTypes;
        }
    }
}
