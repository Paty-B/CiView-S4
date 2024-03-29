﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Windows.Data;

namespace ModelView.ViewModel
{
    public class ColorLineItemConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            Int16 content = (Int16)parameter;
            switch(content)
            {
                case 1 :
                    return "Red";
                    break;
                case 2 :
                    return "Azure";
                    break;
                default :
                    return "Black";
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
