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

namespace _11.SquareInSuare
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var foxDraw = new FoxDraw(canvas);
            double myx = 10;
            double myy = 10;
            double mysize = 500;
            DrawSquare(foxDraw, myx, myy, mysize);
        }
        public static void DrawSquare(FoxDraw foxDraw, double coordinatex, double coordinatey, double size)
        {
            if (size > 0)
            {
                foxDraw.FillColor(Colors.Yellow);
                foxDraw.StrokeColor(Colors.Black);
                foxDraw.DrawRectangle(coordinatex, coordinatey, size, size);

                DrawSquare(foxDraw, coordinatex, coordinatey, size / 3);
            }
            else
            {
                return;
            }
        }
    }
}
