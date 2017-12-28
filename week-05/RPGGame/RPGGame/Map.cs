using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GreenFox;
using System.Windows;
using System.Windows.Controls;

namespace RPGGame
{
    public class Map
    {
        private int MapWidth = 10;
        private int MapHeigth = 10;
        private int WallCount = 25;
        //Random random = new Random();

        public FoxDraw myfoxDraw { get; set; }

        public Map(FoxDraw foxDraw)
        {
            myfoxDraw = foxDraw;
        }

        public int[,] GenerateMap()
        {
            int x = 0;
            int y = 0;

            int[,] map = new int[,]
            {
                {0, 0, 0, 1, 0, 1, 0, 0, 0, 0 },
                {0, 0, 0, 1, 0, 1, 0, 1, 1, 0 },
                {0, 1, 1, 1, 0, 1, 0, 1, 1, 0 },
                {0, 0, 0, 0, 0, 1, 0, 0, 0, 0 },
                {1, 1, 1, 1, 0, 1, 1, 1, 1, 0 },
                {0, 1, 0, 1, 0, 0, 0, 0, 1, 0 },
                {0, 1, 0, 1, 0, 1, 1, 0, 1, 0 },
                {0, 0, 0, 0, 0, 1, 1, 0, 1, 0 },
                {0, 1, 1, 1, 0, 0, 0, 0, 1, 0 },
                {0, 0, 0, 1, 0, 1, 1, 0, 1, 0 },
                {0, 1, 0, 1, 0, 1, 0, 0, 0, 0 }
            };

            for (int i = 0; i < MapHeigth; i++)
            {
                for (int j = 0; j < MapWidth; j++)
                {
                    if (map[i, j] == 0)
                    {
                        myfoxDraw.AddImage("./floor.png", x, y);
                    }
                    else
                    {
                        myfoxDraw.AddImage("./wall.png", x, y);
                    }
                    x += 50;
                }
                x = 0;
                y += 50;
            }
            return map;
        }
    }
    //int RandomWall()
    //{
    //    return random.Next(MapWidth * MapHeigth);
    //}

    //bool WallChecker(int[] map, int number)
    //{
    //    if (map[number] != 1)
    //    {
    //        map[number] = 1;
    //        return true;
    //    }

    //    return false;
    //}

    //int[] GenerateMap()
    //{
    //    int[] map = new int[MapWidth * MapHeigth];

    //    for (int i = 0; i < WallCount;)
    //    {
    //        if (WallChecker(map, RandomWall()))
    //            i++;
    //    }

    //    return map;
    //}

    //public void CreateMap()
    //{
    //    int xcoordinate = 0;
    //    int ycoordinate = 0;

    //    for (int i = 0; i < MapHeigth; i++)
    //    {
    //        for (int j = 0; j < MapWidth; j++)
    //        {
    //            if (GenerateMap()[i * 10 + j] == 1)
    //            {
    //                myfoxDraw.AddImage("./wall.png", xcoordinate, ycoordinate);
    //            }
    //            else
    //            {
    //                myfoxDraw.AddImage("./floor.png", xcoordinate, ycoordinate);
    //            }
    //            xcoordinate += j * 50;
    //        }
    //        ycoordinate += i * 50;
    //    }
    //}
}

