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

namespace RPGGame
{
    public partial class MainWindow : Window
    {
        public FoxDraw foxDraw;
        public FoxDraw foxDraw1;
        public Hero hero;
        public Map mymap;

        public MainWindow()
        {
         
        }
        private void WindowKeyDown(object sender, KeyEventArgs e)
        {
            int xcoordinate = 0;
            int ycoordinate = 0;

            if (e.Key == Key.Left)
            {

                
            }

            if (e.Key == Key.Right)
            {

            }
            if (e.Key == Key.Up)
            {

            }

            if (e.Key == Key.Down)
            {

            }
        }
    }
}
