using delta.Core;
using System;
using System.Globalization;
using System.Windows.Media;

namespace delta
{
    /// <summary>
    /// A converts that takes <see cref="ServiceIconEnum"/> and converts it to WPF brush
    /// </summary>
    public class ServiceIconToBrushValueConverter : BaseValueConverter<ServiceIconToBrushValueConverter>
    {
        private string color;
        public override object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            switch ((ServiceIconEnum)value)
            {
                case ServiceIconEnum.Twitch:
                    color = "6441a4";
                    break;
                case ServiceIconEnum.YouTube:
                    color = "ff4747";
                    break;
                case ServiceIconEnum.GoodGame:
                    color = "6441a4";
                    break;
            }

            return (SolidColorBrush)(new BrushConverter().ConvertFrom($"#{color}"));
        }

        public override object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
