using System;
using System.Drawing;
using System.Text.RegularExpressions;

namespace Vendstor.Backend.Libraries
{
    public static class Validation
    {
        public enum Type { String, Bool, Int, Double, Float, Decimal };
        public enum Validate { Email, Password, String, Integer };

        readonly static Image imgValid = Properties.Resources.tick;
        readonly static Image imgInValid = Properties.Resources.error_icon4;

        public static bool IsUrl(string input)
        {
            return false;
        }
        
        /// <summary>   
        /// <param name="isValid"> Bool Which Image To Return, Tick or Cross ;</param> 
        /// </summary>
        public static Image GetValidityImage(bool isValid = false)
        {
            if (isValid)
                return imgValid;
            else
                return imgInValid;
        }

        /// <summary>   
        /// <param name="emailAddress"> String to check Validity ;</param> 
        /// </summary>
        public static bool IsEmailValid(string EmailAddress)
        {
            string[] emailAddress = EmailAddress.Split(new string[] { "@" }, StringSplitOptions.None);

            if (emailAddress.Length != 2)
                return false;

            //Check Part Before ...@ [Local-Part]
            if (emailAddress[0].Length < 1)
                return false;

            //Local Part Regex
            Regex regex = new Regex(@"^[a-zA-Z0-9_\-\.]+$"); 

            if (!regex.IsMatch(emailAddress[0]))
                return false;

            //Check Part After @... [Domain-Part]
            string[] domainName = emailAddress[1].Split(new string[] { "." }, StringSplitOptions.None);

            if (domainName.Length < 2)
                return false;

            //Domain Part Regex
            regex = new Regex(@"^[a-zA-Z0-9_\-]+$"); 

            foreach (string domainLetter in domainName)
            {
                if (!regex.IsMatch(domainLetter))
                    return false;
            }

            //Get Email Address TLD [Top Level Domain]
            if (domainName[domainName.Length - 1].Length < 2)
                return false;

            return true;
        }

        /// <summary>
        /// <param name="password"> String To Check Validity ;</param>
        /// <param name="useSymbol"> Accept Symbol In Password Or Not ;</param>
        /// <param name="acceptWhiteSpace"> Accept WhiteSpace In Password Or Not ;</param>
        /// </summary>
        public static bool IsPasswordValid(string password, bool useSymbol = false, bool acceptWhiteSpace = false, int minLength =  6, int maxLength = 25)
        {
            /** Code SRC : Anurag, 1 Dec 2016 : StackOverflow*/

            if (string.IsNullOrWhiteSpace(password))
                return false;

            // Contains 1 Number
            var hasNumberRegex = new Regex(@"[0-9]+");
            // Contains 1 UpperChar
            var hasUpperCharRegex = new Regex(@"[A-Z]+");
            // Char = between minLength and maxLength
            var hasMiniMaxCharsRegex = new Regex(@".{6, 30}");
            // Contains 1 LowerChar
            var hasLowerCharRegex = new Regex(@"[a-z]+");
            // Contains a Symbol
            var hasSymbolsRegex = new Regex(@"[!@#$%^&*()_+=\[{\]};:<>|./?,-]");

            if (!hasLowerCharRegex.IsMatch(password))
                return false;

            else if (!hasUpperCharRegex.IsMatch(password))
                return false;

            //else if (!hasMiniMaxCharsRegex.IsMatch(password))
            //    return false;

            else if (password.Length > maxLength)
                return false;

            else if (password.Length < minLength)
                return false;

            //else if (!hasNumberRegex.IsMatch(password))
             //   return false;

            else if (!hasSymbolsRegex.IsMatch(password) && useSymbol)
                return false;

            else if (password.Contains(" ") && !acceptWhiteSpace)
                return false;
            else
                return true;

        }

        public static bool IsPINValid(string pin, int minLength = 4, int maxLength = 6)
        {
            return IsStringValid(pin, minLength, maxLength, IsInteger: true);
        }

        public static bool IsTokenValid(string token, int minLength = 10, int maxLength = 255)
        {
            return IsStringValid(token, minLength, maxLength);
        }

        /// <summary>        
        /// <param name="inputString"> String To Check Validity ;</param>
        /// <param name="minLength"> Minimum Input String Length ;</param>
        /// <param name="maxLength"> Maximum Input String Length ;</param>    
        /// </summary>
        public static bool IsStringValid(string inputString, int minLength = 4, int maxLength = 20, bool IsInteger = false)
        {
            if (String.IsNullOrWhiteSpace(inputString))
                return false;

            if (IsInteger)  
                //Check If String Is Integer          
                if (!IsInputTypeValid(inputString, (int)Type.Int))
                    return false;

            if (inputString.Length < minLength)
                return false;

            else if (inputString.Length > maxLength)
                return false;

            else
                return true;
        }

        /// <summary>      
        /// <param name="inputString">String To Check Validity ;</param>
        /// <param name="typeIndex"> Target Type Index ;</param>
        /// </summary>
        public static bool IsInputTypeValid(string inputString, int typeIndex)
        {
            switch (typeIndex)
            {
                //Check If InputString Is of TypeIndex
                case (int)Type.Int:
                    if (inputString.Length > 10) 
                        //Handle larger strings With [Int64]
                        return Int64.TryParse(inputString, out Int64 IntType);
                    else
                        return int.TryParse(inputString, out int IntType);

                case (int)Type.Bool:
                    return bool.TryParse(inputString, out bool BoolType);

                case (int)Type.Double:
                    return double.TryParse(inputString, out double DoubleType);

                case (int)Type.Float:
                    return float.TryParse(inputString, out float FloatType);

                case (int)Type.Decimal:
                    return decimal.TryParse(inputString, out decimal DecimalType);

                default:
                    return false;
            }
        }
                
    }
}
