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
using GreenFox;

namespace Triangles
{

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var foxDraw = new FoxDraw(canvas);
            double myx = 50;
            double myy = 50;
            double mysize = 500;
            DrawTriangle(foxDraw, myx, myy, mysize);
        }
        public static void DrawTriangle(FoxDraw foxDraw, double origox, double origoy, double size)
        {
            foxDraw.StrokeColor(Colors.Black);
            foxDraw.FillColor(Colors.White);

            var points = new List<Point>();
            points.Add(new Point(origox, origoy));
            points.Add(new Point(size, origoy));
            points.Add(new Point((size / 2), Math.Sqrt(d: (Math.Pow(size, 2) - Math.Pow((size / 2), 2)))));

            foxDraw.DrawPolygon(points);
        }
    }
}
