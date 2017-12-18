using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GreenFox;
using System.Windows;

namespace RPGGame
{
    class Map
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

        public void MapCreater()
        {
            int ycoordinate = 0;

            for (int i = 0; i < MapHeigth; i++)
            {
                int xcoordinate = 0;

                for (int j = 0; j < MapWidth; j++)
                {
                    myfoxDraw.AddImage("./floor.png", xcoordinate, ycoordinate);
                    xcoordinate = xcoordinate + 50;
                }
                ycoordinate = ycoordinate + 50;
            }
        }
    }
}
