using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Windows.Data;

namespace ModelView.ViewModel
{
    public class LineItemVisibilityConverter : IValueConverter
    {
        public object Convert(object value, Type targetTape, object parameter, CultureInfo culture)
        {

            bool format = (bool)value;
            if (format)
            {
                return "Collapsed";
            }
            else
            {
                return "Visible";
            }
        }


        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
