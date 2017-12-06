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

namespace PurpleSteps
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var foxDraw = new FoxDraw(canvas);
            // reproduce this:
            // [https://github.com/greenfox-academy/teaching-materials/blob/master/workshop/drawing/purple-steps/r3.png]
            double myx = 10;
            double myy = 10;
            for (int i = 0; i < 50; i++)
            {
                DrawSquares(foxDraw, myx, myy);
                myx = myx + 10;
                myy = myy + 10;
            }
        }
        public static void DrawSquares(FoxDraw foxDraw, double x, double y)
        {
            foxDraw.FillColor(Colors.Purple);
            foxDraw.DrawRectangle(x, y, 10, 10);
        }
    }
}