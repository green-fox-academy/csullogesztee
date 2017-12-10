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

namespace Checkerboard
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var foxDraw = new FoxDraw(canvas);
            // fill the canvas with a checkerboard pattern.

            double mywz = 10;
            double mybz = 10;
            double sumx = 10;
            for (int i = 0; i < 10; i++)
            {
                    double sumy = 10;
                for (int j = 0; j < 10; j++)
                {
                    
                    if (i % 2 == 0)
                    {
                        if (j % 2 == 0)
                        {
                            DrawBlackSquares(foxDraw, sumx, sumy, mybz);
                        }
                        else
                        {
                            DrawWhiteSquares(foxDraw, sumx, sumy, mywz);
                        }
                    }
                    else
                    {
                        if (j % 2 == 0)
                        {
                            DrawWhiteSquares(foxDraw, sumx, sumy, mywz);
                        }
                        else
                        {
                            DrawBlackSquares(foxDraw, sumx, sumy, mybz);
                        }
                    }
                    sumy = sumy + 10;
                }
                    sumx = sumx + 10;
            }
        }
    public static void DrawWhiteSquares(FoxDraw foxDraw, double wx, double wy, double wz)
    {
        foxDraw.FillColor(Colors.White);
        foxDraw.DrawRectangle(wx, wy, wz, wz);
    }
    public static void DrawBlackSquares(FoxDraw foxDraw, double bx, double by, double bz)
    {
        foxDraw.FillColor(Colors.Black);
        foxDraw.DrawRectangle(bx, by, bz, bz);
    }
    }

}