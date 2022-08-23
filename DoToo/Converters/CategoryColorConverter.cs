using System;
using System.Globalization;
using Xamarin.Forms;

namespace DoToo.Converters
{
    public class CategoryColorConverter : IValueConverter
    {
        public object Convert(object value, Type targetType,
                              object parameter, CultureInfo
                              culture)
        {
            string s = (string)value;
            if (s == "Personal")
            {
                return (Color)Application.Current.Resources["Personal"];
            }
            else if( s == "School")
            {
                return (Color)Application.Current.Resources["School"];
            }
            else
            {
                return (Color)Application.Current.Resources["Home"];
            }
        }

        public object ConvertBack(object value, Type
         targetType,
         object parameter, CultureInfo culture)
        {
            return null;
        }
    }
}