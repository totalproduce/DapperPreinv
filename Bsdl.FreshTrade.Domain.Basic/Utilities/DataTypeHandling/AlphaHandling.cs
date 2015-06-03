using System;

namespace Bsdl.FreshTrade.Domain.Basic.Utilities.DataTypeHandling
{
    public static class AlphaHandling
    {
        public static string ToAlpha(string passString)
        {
            if (passString != null)
            {
                return RemoveInvalidChars(passString);
            }
            else
            {
                throw new NullReferenceException("Null Value in ToAlpha(passString))");
            }
        }

        public static string DoubleQuoteSQLLiteral(string text)
        {
            return text.Replace("'", "''");
        }
        /// <summary>
        /// Convert passed in string to a string for use in SQL statements  
        /// Set includeLikeChar = true to include % for like 
        /// </summary>
        /// <param name="passString"></param>
        /// <param name="includeLikeChar"></param>
        /// <returns></returns>
        public static string FormatToSQLAlpha(string passString, bool includeLikeChar)
        {
            if (passString != null)
            {
                string formattedString = DoubleQuoteSQLLiteral(RemoveInvalidChars(passString));
                if (includeLikeChar)
                {
                    formattedString = "%" + formattedString + "%";
                }

                formattedString = " '" + formattedString + "' ";

                return formattedString;
            }
            else
            {
                throw new NullReferenceException("Null Value in ToAlpha(passString))");
            }
        }

        public static bool IsAlpha(string passString)
        {
            if (passString == null)
            {
                return false;
            }
            else
            {
                string toAlphaString = ToAlpha(passString);

                if (toAlphaString != null)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public static bool IsAlpha(string passString, bool allowBlank)
        {
            if (passString == null)
            {
                return false;
            }
            else
            {
                string toAlphaString = ToAlpha(passString);

                if (string.IsNullOrEmpty(toAlphaString))
                {
                    if (toAlphaString != null && !allowBlank)
                    {
                        return false;
                    }
                    else
                    {
                        return true;
                    }
                }
                else
                {
                    return true;
                }
            }
        }

        public static bool IsAlpha(string passString, int minLength, int maxLength)
        {
            if (passString != null)
            {
                string toAlphaString = ToAlpha(passString);

                if (!string.IsNullOrEmpty(toAlphaString))
                {
                    if (toAlphaString.Length < minLength || toAlphaString.Length > maxLength)
                    {
                        return false;
                    }
                    else
                    {
                        return true;
                    }
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        static string RemoveInvalidChars(string passString)
        {
            string validString = passString;

            if (passString.Contains("~"))
            {
                validString = validString.Replace("~", "");
            }

            return validString;
        }

        public static string Left(this string data, int count)
        {
            if (data.Length > count)
            {
                return data.Substring(0, count);
            }
            return data;
        }

        public static string Right(this string data, int count)
        {
            if (data.Length > count)
            {
                return data.Substring(data.Length - count, count);
            }
            return data;
        }

        public static string DateToSqlStr(DateTime date)
        {
            return date.ToString("yyyy-MM-dd");
        }

        public static bool StringToBoolean(string str)
        {
            if (string.Compare(str, "TRUE", true) == 0)
            {
                return true;
            }
            if (string.Compare(str, "FALSE", true) == 0)
            {
                return false;
            }
            int num;
            if (int.TryParse(str, out num))
            {
                return num > 0;
            }
            return false;
        }
    }
}
