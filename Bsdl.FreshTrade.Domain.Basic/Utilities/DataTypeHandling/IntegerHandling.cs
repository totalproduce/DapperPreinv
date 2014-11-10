using Bsdl.FreshTrade.Domain.Basic.Enums;

namespace Bsdl.FreshTrade.Domain.Basic.Utilities.DataTypeHandling
{
    using System;

    public static class IntegerHandling
    {
        public static bool IsInteger(string passString)
        {
            if (passString != null)
            {
                int returnInt = 0;

                if (int.TryParse(passString, out returnInt))
                {
                    return true;
                }
                else
                {
                    var ex = new Exception("Invalid Integer in ToInt(passString)");
                    //AppError.SetError(ex, ex.StackTrace, ErrorType.Fatal);
                    throw ex;
                }
            }
            else
            {
                var ex = new Exception("Null Value in ToInt(passString)");
                //AppError.SetError(ex, ex.StackTrace, ErrorType.Fatal);
                throw ex;
            }
        }

        public static bool IsPositiveInteger(string passString)
        {
            if (IsInteger(passString))
            {
                if (Convert.ToInt32(passString) < 0)
                {
                    // throw new ArgumentOutOfRangeException("Integer value must be greater than Zero in IsPositiveInteger(passString)");
                    // var ex = new Exception("Negative Value");
                    // AppError.SetError(ex, ex.StackTrace, ErrorType.Info);
                    // throw ex;
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

        public static bool TryConvertToInt32(decimal val, out int intval)
        {
            if (val > int.MaxValue || val < int.MinValue)
            {
                intval = 0; // assignment required for out parameter
                return false;
            }

            intval = Decimal.ToInt32(val);

            return true;
        }
    }
}
