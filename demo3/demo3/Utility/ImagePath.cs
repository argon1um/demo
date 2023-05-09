using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace demo3.Utility
{
    internal class ImagePath
    {
        static string imagefolder = "pack://application:,,,/Images";
        static string defaultimage = "picture.png";
        public static BitmapImage GetBitmapImage()
        {
            return new BitmapImage(new Uri($"{imagefolder}/{defaultimage}", UriKind.Absolute));
        }
        public static BitmapImage GetBitmapImage(string image)
        {
            return new BitmapImage(new Uri($"{imagefolder}/{image}", UriKind.Absolute));
        }
    }
}
