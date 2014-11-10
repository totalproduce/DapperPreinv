namespace Bsdl.FreshTrade.Domain.Basic.Utilities.DataTypeHandling
{
    public class GenericFilter
    {
        public bool filterString(string stringValue, string filterByString)
        {

            if (string.IsNullOrEmpty(filterByString))
            {
                return true;
            }


            if (string.IsNullOrEmpty(stringValue))
            {
                return false;
            }

            bool idFilter = true;

            string[] arr = filterByString.Split(new[] { ' ' });

            int lastPosition = 0;
            int currentPosition = 0;
            //bool isFirst = true;

            bool AllowZeroPosition = false;

            foreach (string item in arr)
            {
                if (string.IsNullOrEmpty(item))
                {
                    // we have a wildcard so allow the next string to be in position 0
                    AllowZeroPosition = true;
                }
                else
                {
                    currentPosition = stringValue.ToUpper().IndexOf(item.ToUpper(), lastPosition);

                    if ((currentPosition < 0) || (!AllowZeroPosition && (currentPosition != 0)))
                    {
                        idFilter = false;
                        break;
                    }

                    lastPosition = currentPosition + item.Length;

                    AllowZeroPosition = true;
                }
                //isFirst = false;
            }

            return idFilter;
        }
    }
}
