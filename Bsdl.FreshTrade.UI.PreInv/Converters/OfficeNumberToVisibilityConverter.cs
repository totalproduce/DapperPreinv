using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Data;

namespace Bsdl.FreshTrade.UI.PreInv.Converters
{
    public class OfficeNumberToVisibilityConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            if (value != null && value != DependencyProperty.UnsetValue)
            {
                int officeNumber = (int) value;
                Visibility visibility = officeNumber > 0 ? Visibility.Visible : Visibility.Hidden;
                return visibility;
            }

            return Binding.DoNothing;
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            return Binding.DoNothing;
        }
    }
}
