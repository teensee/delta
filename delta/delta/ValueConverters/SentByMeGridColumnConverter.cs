using delta.Core;
using System;
using System.Globalization;

namespace delta
{
    /// <summary>
    /// Converts the <see cref="ServiceIconEnum"/> to an icon
    /// </summary>
    public class SentByMeGridColumnConverter : BaseValueConverter<SentByMeGridColumnConverter>
    {
        public override object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return (bool)value ? 2 : 0;
        }

        public override object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
