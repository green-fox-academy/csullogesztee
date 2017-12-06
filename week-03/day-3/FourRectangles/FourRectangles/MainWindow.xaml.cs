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

namespace FourRectangles
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var foxDraw = new FoxDraw(canvas);
            // draw four different size and color rectangles.
            DrawRectangles(foxDraw);
        }
        public static void DrawRectangles(FoxDraw FoxDraw)
        {
            Random r = new Random();
            for (int i = 0; i < 5; i++)
            {
            FoxDraw.FillColor(Color.FromRgb((byte)r.Next(), (byte)r.Next(), (byte)r.Next()));
            FoxDraw.DrawRectangle(10 + 100 * i, 10 + 100 * i, 50 * i, 20 * i);
            }
        }
    }
}