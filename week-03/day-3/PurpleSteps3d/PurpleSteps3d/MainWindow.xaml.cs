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

namespace PurpleSteps3d
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var foxDraw = new FoxDraw(canvas);
            // reproduce this:
            // [https://github.com/greenfox-academy/teaching-materials/blob/master/workshop/drawing/purple-steps-3d/r4.png]

            double myx = 10;
            double myy = 10;
            for (int i = 0; i < 10; i++)
            {
                DrawSquares(foxDraw, myx, myy);
                myx = myx + myy;
                myy = myy * 1.5;
            }
        }
        public static void DrawSquares(FoxDraw foxDraw, double x, double y)
        {
            foxDraw.FillColor(Colors.Purple);
            foxDraw.DrawRectangle(x, x, y, y);
        }
    }
}