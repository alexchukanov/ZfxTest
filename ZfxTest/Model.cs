using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;
using System.Windows.Shapes;


namespace ZfxTest
{
    public class ShapeInfo
    {
        public string Name { get; set; }
        public Shape Shape { get; set; }
    }

    public class CircleInfo : ShapeInfo
    {
        public CircleInfo(int radius)
        {
            Shape = new Ellipse();

            Shape.Width = radius * 2;
            Shape.Height = radius * 2;
        }
    }

    public class RectangleInfo : ShapeInfo
    {
        public RectangleInfo(int x, int y)
        {
            Polygon rectangle = new Polygon();
            var rectPoints = new PointCollection
            {
                new Point(0, 0),
                new Point(x, 0),
                new Point(x, y),
                new Point(0, y)
            };

            rectangle.Points = rectPoints;
            Shape = rectangle;

            Shape.Width = x;
            Shape.Height = y;
        }
    }


    public class TriangleInfo : ShapeInfo
    {
        public TriangleInfo(int x, int y)
        {
            Polygon rectangle = new Polygon();
            var rectPoints = new PointCollection
            {
                new Point(0, 0),
                new Point(x, 0),
                new Point(0, y)
            };

            rectangle.Points = rectPoints;
            Shape = rectangle;

            Shape.Width = x;
            Shape.Height = y;
        }
    }

    public class Utils
    {
        public static SolidColorBrush GetSolidColorBrush(string hex)
        {
            hex = hex.Replace("#", string.Empty);
            byte a = (byte)(Convert.ToUInt32(hex.Substring(0, 2), 16));
            byte r = (byte)(Convert.ToUInt32(hex.Substring(2, 2), 16));
            byte g = (byte)(Convert.ToUInt32(hex.Substring(4, 2), 16));
            byte b = (byte)(Convert.ToUInt32(hex.Substring(6, 2), 16));
            SolidColorBrush myBrush = new SolidColorBrush(System.Windows.Media.Color.FromArgb(a, r, g, b));

            return myBrush;
        }
    }
}
