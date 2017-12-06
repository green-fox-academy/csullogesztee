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

namespace PositionSquare
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var foxDraw = new FoxDraw(canvas);
            // create a square drawing function that takes 2 parameters:
            // the x and y coordinates of the square's top left corner
            // and draws a 50x50 square from that point.
            // draw 3 squares with that function.            
            DrawSquares(foxDraw);
        }
        public static void DrawSquares(FoxDraw foxDraw)
        {
            int x = 10;
            int y = 10;
            for (int i = 0; i < 4; i++)
            {
                foxDraw.DrawRectangle(x, y, 50, 50);
                x = x + i * 100;
                y = y + i * 100;
            }
        }
    }
}