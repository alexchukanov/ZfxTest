using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ZfxTest
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ButtonShow_Click(object sender, RoutedEventArgs e)
        {
            canvas.Children.Clear();

            int radius;
            int.TryParse(tbRadius.Text, out radius);

            int width;
            int.TryParse(tbLengthByX.Text, out width);

            int heigth;
            int.TryParse(tbLengthByY.Text, out heigth);

            string selectedShape = cbShapeTypes.SelectionBoxItem.ToString();

            Shape shape = null;

            switch (selectedShape)
            {
                case "Circle":
                    shape = (new CircleInfo(radius)).Shape;
                    break;

                case "Square":
                    tbLengthByY.Text = tbLengthByX.Text;
                    heigth = width;

                    shape = (new RectangleInfo(width, heigth)).Shape;
                    break;

                case "Rectangle":
                    shape = (new RectangleInfo(width, heigth)).Shape;
                    break;

                case "Triangle":
                    shape = (new TriangleInfo(width, heigth)).Shape;
                    break;

            }

            shape.Stroke = Utils.GetSolidColorBrush("#ff3c2f2f");
            shape.Fill = Utils.GetSolidColorBrush("#ffe0ffff");
            shape.StrokeThickness = 8;

            
            //shape.SetValue(Canvas.LeftProperty, 200);
            //shape.SetValue(Canvas.TopProperty, 100);

            canvas.Children.Add(shape);
        }

        private void ButtonClear_Click(object sender, RoutedEventArgs e)
        {
            canvas.Children.Clear();
        }
    }
}
