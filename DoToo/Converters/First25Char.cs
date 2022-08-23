/*using System;
using System.Globalization;
using Xamarin.Forms;

namespace DoToo.Converters
{
    public class First25Char : IValueConverter
    {
        public object Convert(object value, Type targetType,
                              object parameter, CultureInfo
                              culture)
        {
            if (value == null)
            {
                return "No Description";
            }
            else
            {
                string s = (string)value;
                return s.Substring(0,25);
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return null;
        }
    }
}*/