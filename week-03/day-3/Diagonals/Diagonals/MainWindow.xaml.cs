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

namespace Diagonals
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var foxDraw = new FoxDraw(canvas);
            // draw the canvas' diagonals in green.
            DrawDiagonal(foxDraw);
        }
        public static void DrawDiagonal(FoxDraw foxDraw)
        {
            foxDraw.StrokeColor(Colors.Green);
            var startPoint = new Point(0, 0);
            var endPoint = new Point(525, 350);
            foxDraw.DrawLine(startPoint, endPoint);
        }
    }
}