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
        public Hero hero;

        public MainWindow()
        {
            InitializeComponent();
            foxDraw = new FoxDraw(canvas);
            hero = new Hero(foxDraw);
            var mymap = new Map(foxDraw);

            mymap.MapCreater();
            mymap.WallCreater();
            
        }
        private void WindowKeyDown(object sender, KeyEventArgs e)
        {
            int xcoordinate = 0;
            int ycoordinate = 0;

            if (e.Key == Key.Left)
            {
                xcoordinate = xcoordinate - 50;
                hero.DrawLeftHero(xcoordinate, ycoordinate);
                
            }

            if (e.Key == Key.Right)
            {
                xcoordinate = xcoordinate + 50;
                hero.DrawRightHero(xcoordinate, ycoordinate);
            }
            if (e.Key == Key.Up)
            {
                ycoordinate = ycoordinate - 50;
                hero.DrawUpHero(xcoordinate, ycoordinate);
            }

            if (e.Key == Key.Down)
            {
                ycoordinate = ycoordinate + 50;
                hero.DrawDownHero(xcoordinate, ycoordinate);
            }
        }
    }
}
