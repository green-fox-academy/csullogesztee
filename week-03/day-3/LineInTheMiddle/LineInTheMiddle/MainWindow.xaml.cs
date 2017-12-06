using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using GreenFox;
using System.Windows.Media;

namespace LineInTheMiddle
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var foxDraw = new FoxDraw(canvas);
            //  draw a red horizontal line to the canvas' middle.
            //  draw a green vertical line to the canvas' middle.
            DrawRedline(foxDraw);
            DrawGreenline(foxDraw);
        }

        public static void DrawRedline(FoxDraw foxDraw)
        {
            foxDraw.StrokeColor(Colors.Red);
            var startPoint = new Point(0, 175);
            var endPoint = new Point(525, 175);
            foxDraw.DrawLine(startPoint, endPoint);
        }
        public static void DrawGreenline(FoxDraw foxDraw)
        {
            foxDraw.StrokeColor(Colors.Green);
            var startPointgreen = new Point(262, 0);
            var endPointgreen = new Point(262, 350);
            foxDraw.DrawLine(startPointgreen, endPointgreen);
        }
    }
}