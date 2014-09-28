using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Data;

namespace DataConverterText
{
    public class DateToStringConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            if(targetType==typeof(string) && value == typeof(DateTime))
                return ((DateTime)value).ToString();
            else
                return value;
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            if(targetType==typeof(DateTime) && value == typeof(string))
                return System.Convert.ToDateTime(value);
            else
                return value;
        }
    }
}
