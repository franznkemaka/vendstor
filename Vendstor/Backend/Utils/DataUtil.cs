using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Vendstor.Backend.Utils
{
    public static class DataUtil
    {
        public static bool IsJson(string strInput)
        {
            strInput = strInput.Trim();
            if ((strInput.StartsWith("{") && strInput.EndsWith("}")) || //For object
                (strInput.StartsWith("[") && strInput.EndsWith("]"))) //For array
            {
                try
                {
                    var obj = JToken.Parse(strInput);
                    return true;
                }
                catch (JsonReaderException jex)
                {
                    //Exception in parsing json
                    Console.WriteLine(jex.Message);
                    return false;
                }
                catch (Exception ex) //some other exception
                {
                    Console.WriteLine(ex.ToString());
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
        public static bool IsBase64(string base64String)
        {
            /// Code SRC : StackOverflow  Oybek stackoverflow.com/users/794764/oybek
            if (base64String == null || base64String.Length == 0  || base64String.Length % 4 != 0
               || base64String.Contains(" ") || base64String.Contains("\t") 
               || base64String.Contains("\r") || base64String.Contains("\n"))
                return false;

            try
            {
                Convert.FromBase64String(base64String);
                return true;
            }
            catch (Exception) {}
            return false;
        }

        public static DataTable ToDataTable<T>(List<T> iList)
        {
            DataTable dataTable = new DataTable();
            PropertyDescriptorCollection propertyDescriptorCollection =
                TypeDescriptor.GetProperties(typeof(T));
            for (int i = 0; i < propertyDescriptorCollection.Count; i++)
            {
                PropertyDescriptor propertyDescriptor = propertyDescriptorCollection[i];
                Type type = propertyDescriptor.PropertyType;

                if (type.IsGenericType && type.GetGenericTypeDefinition() == typeof(Nullable<>))
                    type = Nullable.GetUnderlyingType(type);


                dataTable.Columns.Add(propertyDescriptor.Name, type);
            }
            object[] values = new object[propertyDescriptorCollection.Count];
            foreach (T iListItem in iList)
            {
                for (int i = 0; i < values.Length; i++)
                {
                    values[i] = propertyDescriptorCollection[i].GetValue(iListItem);
                }
                dataTable.Rows.Add(values);
            }
            return dataTable;
        }


        public static object GetJsonProperty(object data, string key, out object value)
        {
            try
            {
                value = ((JObject)data)[key];
                return ((JObject)data)[key];
            }
            catch
            {
                value = null;
                return null;
            }
        }
    }
}