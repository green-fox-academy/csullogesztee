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

            Characters mycharacters = new Characters();
            mycharacters.AddCharacter(new Hero(myfoxDraw));
            mycharacters.AddCharacter(new Boss(myfoxDraw));
            mycharacters.AddCharacter(new Skeletons(true, myfoxDraw));
            mycharacters.AddCharacter(new Skeletons(false, myfoxDraw));
            mycharacters.AddCharacter(new Skeletons(false, myfoxDraw));

            mycharacters.AddImages();
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
