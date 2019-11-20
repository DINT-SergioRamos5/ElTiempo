using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace ElTiempo
{
    class ConverterPrediccion : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if ((string)value == "sol")
                value = "sunny.png";
            else if ((string)value == "nubes")
                value = "cloudy.png";
            else if ((string)value == "lluvia")
                value = "rain.png";
            else
                value = "snow.png";

            return value;

        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
