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
        public int Counter = 0;
        public FoxDraw myfoxDraw { get; set; }

        public MainWindow()
        {
            InitializeComponent();
            myfoxDraw = new FoxDraw(canvas);

            Map mymap = new Map(myfoxDraw);
            mymap.GenerateMap();

            Characters mycharacters = new Characters(mymap);
            mycharacters.AddCharacter(new Hero(mymap));
            mycharacters.AddCharacter(new Boss(mymap));
            mycharacters.AddCharacter(new Skeletons(true, mymap));
            mycharacters.AddCharacter(new Skeletons(false, mymap));
            mycharacters.AddCharacter(new Skeletons(false, mymap));

            mycharacters.AddImages(myfoxDraw);
        }

        private void WindowKeyDown(object sender, KeyEventArgs e)
        {
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

            Counter++;
        }
    }
}
