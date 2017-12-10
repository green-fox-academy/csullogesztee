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
            double mycount = 3;
            DrawTriangle(foxDraw, myx, myy, mysize, mycount);
        }
        public static void DrawTriangle(FoxDraw foxDraw, double origox, double origoy, double size, double count)
        {
            if (size > 0)
            {
                if (count < 10)
                {

                    foxDraw.StrokeColor(Colors.Black);
                    foxDraw.FillColor(Colors.White);

                    var points = new List<Point>();
                    points.Add(new Point(origox, origoy));
                    points.Add(new Point(origox + size, origoy));
                    points.Add(new Point(origox + (size / 2), origoy + (Math.Sqrt(3)/2 * size)));

                    foxDraw.DrawPolygon(points);
                    count++;

                    DrawTriangle(foxDraw, origox, origoy, (size / 2), count);
                    DrawTriangle(foxDraw, origox +(size / 2), origoy, (size / 2), count);
                    DrawTriangle(foxDraw, origox + (size / 4), (origoy + (Math.Sqrt(3) / 2 * size) / 2), (size / 2), count);
                }
                else
                {
                    return;
                }
            }
            else
            {
                return;
            }
        }
    }
}
