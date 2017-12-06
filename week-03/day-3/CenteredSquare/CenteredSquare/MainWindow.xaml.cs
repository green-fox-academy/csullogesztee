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

namespace CenteredSquare
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var foxDraw = new FoxDraw(canvas);
            // draw a green 10x10 square to the canvas' center.
            DrawSquare(foxDraw);
        }
        public static void DrawSquare(FoxDraw foxDraw)
        {
            foxDraw.FillColor(Colors.Green);
            var points = new List<Point>();
            points.Add(new Point(257, 170));
            points.Add(new Point(267, 170));
            points.Add(new Point(267, 160));
            points.Add(new Point(257, 160));
            foxDraw.DrawPolygon(points);
        }
    }
}