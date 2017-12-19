using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GreenFox;
using System.Windows;

namespace RPGGame
{
    public class Map
    {
        public int MapWidth { get; private set; }
        public int MapHeigth { get; private set; }
        public FoxDraw myfoxDraw { get; set; }

        public Map(FoxDraw foxDraw)
        {
            MapWidth = 11;
            MapHeigth = 11;
            myfoxDraw = foxDraw;
        }

    }
}
