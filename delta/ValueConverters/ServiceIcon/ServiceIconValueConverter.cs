using delta.Core;
using System;
using System.Diagnostics;
using System.Globalization;
using System.Windows;

namespace delta
{
    /// <summary>
    /// Converts the <see cref="ServiceIconEnum"/> to an icon
    /// </summary>
    public class ServiceIconValueConverter : BaseValueConverter<ServiceIconValueConverter>
    {
        public override object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            // Find the appropriate page
            switch ((ServiceIconEnum)value)
            {
                case ServiceIconEnum.Twitch:
                    return Application.Current.FindResource("MaterialDesignTwitchIcon");

                case ServiceIconEnum.YouTube:
                    return Application.Current.FindResource("MaterialDesignYoutubeIcon");

                default:
                    Debugger.Break();
                    return null;
            }
        }

        public override object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
