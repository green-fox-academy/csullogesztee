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

namespace FunctionToCenter
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var foxDraw = new FoxDraw(canvas);
            // create a line drawing function that takes 2 parameters:
            // the x and y coordinates of the line's starting point
            // and draws a line from that point to the center of the canvas.
            // fill the canvas with lines from the edges, every 20 px, to the center.
            int myx = 212;
            int myy = 125;

                for (int j = 0; j < 100; j++)
                {
                    DrawLines(foxDraw, myx, myy);
                    if (211 < myx && myx < 312 && myy == 125)
                    {
                        myx = myx + 10;
                    }
                    else if ( 124 < myy && myy < 225 && myx == 312)
                    {
                        myy = myy + 10;
                    }
                    else if (212 < myx && myx < 313 && myy == 225)
                    {
                        myx = myx - 10;
                    }
                    else if (myx == 212 && 124 < myy && myy < 226)
                    {
                        myy = myy - 10;
                    }

                }
        }
        public static void DrawLines(FoxDraw foxDraw, int x, int y)
        {
            foxDraw.DrawLine(x, y, 262, 175);
        }
    }
}