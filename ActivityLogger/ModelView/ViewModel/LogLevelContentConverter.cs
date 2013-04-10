using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Windows.Data;

namespace ModelView.ViewModel 
{
    public class LogLevelContentConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            String content = parameter as String;
            int nb = (int)value;
            if (content == "Total Log")
            {
                return String.Format("{0} : {1}", content, nb);
            }
            else
            {
                return String.Format("{0} ({1})", content, nb);
            }
            
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
