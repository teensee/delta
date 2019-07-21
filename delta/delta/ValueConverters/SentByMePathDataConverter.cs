using delta.Core;
using System;
using System.Globalization;

namespace delta
{
    /// <summary>
    /// Converts the <see cref="ServiceIconEnum"/> to an icon
    /// </summary>
    public class SentByMePathDataConverter : BaseValueConverter<SentByMePathDataConverter>
    {
        private string leftArrow = "M 0,0 L 10,10 L 10,0";
        private string rightArrow = "M 0 0 L 0 10 L 10 0";
        public override object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return (bool)value ? rightArrow : leftArrow;
        }

        public override object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
