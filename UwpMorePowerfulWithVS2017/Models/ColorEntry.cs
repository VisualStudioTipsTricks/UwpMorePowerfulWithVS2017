using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI;
using Windows.UI.Xaml.Media;

namespace UwpMorePowerfulWithVS2017.Models
{
    class ColorEntry
    {
        public string ColorName { get; set; }
        public Color Color { get; set; }

        public static SolidColorBrush Brushify(Color c)
        {
            return new SolidColorBrush(c);
        }

        public static SolidColorBrush TextColor(Color c)
        {
            return new SolidColorBrush(((c.R * 0.299 + c.G * 0.587 + c.B * 0.114) > 150) ? Colors.Black : Colors.White);
        }
    }
}