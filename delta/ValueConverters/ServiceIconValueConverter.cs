using System;
using System.Diagnostics;
using System.Globalization;

namespace delta
{
    /// <summary>
    /// Converts the <see cref="ApplicationPage"/> to an actual view/page
    /// </summary>
    public class ServiceIconValueConverter : BaseValueConverter<ServiceIconValueConverter>
    {
        public override object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            // Find the appropriate page
            switch ((ServiceIconEnum)value)
            {
                case ServiceIconEnum.Twitch:
                    return "\uf543";

                case ServiceIconEnum.YouTube:
                    return "\uf5c3";

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
