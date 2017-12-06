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

namespace CenterBoxFunction
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var foxDraw = new FoxDraw(canvas);
            // create a square drawing function that takes 1 parameter:
            // the square size
            // and draws a square of that size to the center of the canvas.
            // draw 3 squares with that function.
            DrawSquares(foxDraw);
        }
        public static void DrawSquares(FoxDraw foxDraw)
        {
            Random r = new Random();
            double x = 340;
            for (int i = 0; i < 4; i++)
            {
                foxDraw.FillColor(Color.FromRgb((byte)r.Next(), (byte)r.Next(), (byte)r.Next()));
                foxDraw.DrawRectangle(262 - x / 2, 175 - x / 2, x, x);
                x = x - i * 50;
            }
        }
    }
}