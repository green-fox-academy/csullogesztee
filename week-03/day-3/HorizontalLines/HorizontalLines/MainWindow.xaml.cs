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

namespace HorizontalLines
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var foxDraw = new FoxDraw(canvas);
            // create a line drawing function that takes 2 parameters:
            // the x and y coordinates of the line's starting point
            // and draws a 50 long horizontal line from that point.
            // draw 3 lines with that function.
            DrawHorizontalLines(foxDraw);
        }
        public static void DrawHorizontalLines(FoxDraw foxDraw)
        {
            foxDraw.StrokeColor(Colors.DeepPink);
            foxDraw.DrawLine(10, 10, 10 + 50, 10);
            foxDraw.DrawLine(20, 20, 20 + 50, 20);
            foxDraw.DrawLine(30, 30, 30 + 50, 30);
        }
    }
}