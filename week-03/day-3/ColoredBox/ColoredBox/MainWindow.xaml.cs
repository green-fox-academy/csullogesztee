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

namespace ColoredBox
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var foxDraw = new FoxDraw(canvas);
            // draw a box that has different colored lines on each edge.
            //DrawColoredBox(foxDraw);
            DrawColoredLines(foxDraw);
        }
        //public static void DrawColoredBox(FoxDraw foxDraw)
        //{
        //    var points = new List<Point>();
        //    points.Add(new Point(10, 10));
        //    points.Add(new Point(160, 10));
        //    points.Add(new Point(160, 160));
        //    points.Add(new Point(10, 160));

        //    foxDraw.DrawPolygon(points);
        //}
        public static void DrawColoredLines(FoxDraw foxDraw)
        {
            foxDraw.StrokeColor(Colors.Black);
            foxDraw.DrawLine(10, 10, 160, 10);
            foxDraw.StrokeColor(Colors.Blue);
            foxDraw.DrawLine(160, 10, 160, 160);
            foxDraw.StrokeColor(Colors.Purple);
            foxDraw.DrawLine(160, 160, 10, 160);
            foxDraw.StrokeColor(Colors.Orange);
            foxDraw.DrawLine(10, 160, 10, 10);
        }
    }
}