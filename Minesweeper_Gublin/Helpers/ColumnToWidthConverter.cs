using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace Minesweeper_Gublin.Helpers
{
    class ColumnToWidthConverter : IValueConverter
    {
        public object Convert(object value, Type targetType,
            object parameter, CultureInfo culture)
        {
            double param = 0;
            double.TryParse((parameter as string).Replace(',', '.'), NumberStyles.Any, CultureInfo.InvariantCulture, out  param);

            double v = 0;
            if (value == null) return param;
            double.TryParse((value as string).Replace(',', '.'), NumberStyles.Any, CultureInfo.InvariantCulture, out v);
            return param * v;
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            return (float)value / (float)parameter;
        }
    }

}
