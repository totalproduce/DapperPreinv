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

        public static int Max(int val1, int? val2, int? val3 = null, int? val4 = null)
        {
            int max = val1;
            if (val2.HasValue && (val2.Value > max))
            {
                max = val2.Value;
            }
            if (val3.HasValue && (val3.Value > max))
            {
                max = val3.Value;
            }
            if (val4.HasValue && (val4.Value > max))
            {
                max = val4.Value;
            }
            return max;
        }
    }
}
