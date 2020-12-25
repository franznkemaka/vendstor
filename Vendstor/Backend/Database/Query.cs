using System;
using System.Globalization;
using MySql.Data.MySqlClient;

//Vendstor
namespace Vendstor.Backend.Database.Queries
{
    public class Query
    {
        public static class Func
        {
            public static int GetRowsCount(MySqlCommand Command)
            {
                return Convert.ToInt32(Command.ExecuteScalar());
            }

            /// <summary>
            /// Convert bool to string for MySQL 
            /// </summary>
            /// <param name="boolToConvert"></param>
            /// <returns></returns>
            public static string ToString(bool value)
            {
                return value ? "1" : "0";
            }

            /// <summary>
            /// Convert string to bool from MySQL 
            /// </summary>
            /// <param name="stringToConvert"></param>
            /// <returns></returns>
            public static bool ToBoolean(string value)
            {
                return (value == "1" || value.ToLower() == "true");
            }

            public static string GetPaginationLimit(Objects.Pagination pagination)
            {
                var row = pagination.CurrentPage * pagination.MaxResults;
                var limit = string.Format(" LIMIT {0}, {1}", row, pagination.MaxResults);
                return limit;
            }

            public static string ToTimeStamp(DateTime dateTime)
            {
                return dateTime.ToString("MM/dd/yyyy HH:mm:ss");
            }

            public static decimal ToDecimal(string str)
            {
                if (string.IsNullOrEmpty(str))
                    return 0;
                else
                    return decimal.Parse(str);
            }

            public static double ToDouble(string str)
            {
                if (string.IsNullOrEmpty(str))
                    return 0;
                else
                    return double.Parse(str);
            }
        }
        
    }
}


