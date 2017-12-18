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
        public void WallCreater()
        {
            List<int> ycoordinates = new List<int> {
                0, 0, 50, 50, 50, 50, 100, 100, 100, 100, 100, 100, 150, 200, 200,
                200, 200, 200, 200, 200, 200, 250, 250, 250, 300, 300, 300, 300, 300,
                350, 350, 350, 400, 400, 400, 400, 450, 450, 450, 450, 500, 500, 500};
            List<int> xcoordinates = new List<int> {150, 250, 150, 250, 350, 400, 50,
                100, 150, 250, 350, 400, 250, 0, 50, 100, 150, 250, 300, 350, 400, 50,
                150, 400, 50, 150, 250, 300, 400, 250, 300, 400, 50, 100, 150, 400, 150, 250, 300, 400, 50, 150, 250};
            for (int i = 0; i < xcoordinates.Count; i++)
            {
            myfoxDraw.AddImage("./wall.png", xcoordinates[i], ycoordinates[i]);
            }
        }
    }
}
