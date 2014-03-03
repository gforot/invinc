
using System;
using System.Windows.Data;
using System.Windows.Media.Imaging;

namespace GliInvincibili.src.converters
{
    public class ImageConverter : IValueConverter
    {
        public object Convert(object value, System.Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {

            return new BitmapImage(new Uri("/GliInvincibili.Model;component/" + (string)value, UriKind.Relative));
        }

        public object ConvertBack(object value, System.Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            throw new System.NotImplementedException();
        }
    }
}
