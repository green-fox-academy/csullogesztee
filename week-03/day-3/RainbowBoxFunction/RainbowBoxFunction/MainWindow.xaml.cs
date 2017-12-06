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

namespace RainbowBoxFunction
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var foxDraw = new FoxDraw(canvas);
            // create a square drawing function that takes 2 parameters:
            // the square size, and the fill color,
            // and draws a square of that size and color to the center of the canvas.
            // create a loop that fills the canvas with rainbow colored squares.

            Color[] mycolor = {Colors.Red,  Colors.Orange, Colors.Yellow, Colors.Green, Colors.Blue,  Colors.Indigo, Colors.Violet};
            double myx = 340;
            for (int i = 0; i < 7; i++)
            {
                DrawSquares(foxDraw, mycolor[i], myx);
                myx = myx - (i+1) * 10;
            }
        }
        public static void DrawSquares(FoxDraw foxDraw, Color color, double x)
        {
                foxDraw.FillColor(color);
                foxDraw.DrawRectangle(262 - x / 2, 175 - x / 2, x, x);
        }
    }
}