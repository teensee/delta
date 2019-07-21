using delta.Core;
using System;
using System.Globalization;
using System.Windows;

namespace delta
{
    /// <summary>
    /// A converters that takes in a boolean if a message was sent by me, and returns
    /// the correct background color
    /// </summary>
    public class SentByMeBackgroundConverter : BaseValueConverter<SentByMeBackgroundConverter>
    {
        public override object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return (bool)value ? Application.Current.FindResource("BackgroundMessageDarkBrush") : Application.Current.FindResource("BackgroundMessageLightBrush");
        }

        public override object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
