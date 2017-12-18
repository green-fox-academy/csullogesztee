using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGGame
{
    class Hero : Characters
    {
        public Hero(int HP, int DP, int SP) : base(HP, DP, SP)
        {
            
        }

        public void DrawUpHero(int heroCoordinateX, int heroCoordinateY)
        {
            myfoxDraw.AddImage("./hero-up.png", heroCoordinateX, heroCoordinateY);
        }

        public void DrawDownHero(int heroCoordinateX, int heroCoordinateY)
        {
            myfoxDraw.AddImage("./hero-down.png", heroCoordinateX, heroCoordinateY);
        }

        public void DrawLeftHero(int heroCoordinateX, int heroCoordinateY)
        {
            myfoxDraw.AddImage("./hero-left.png", heroCoordinateX, heroCoordinateY);
        }

        public void DrawRightHero(int heroCoordinateX, int heroCoordinateY)
        {
            myfoxDraw.AddImage("./hero-right.png", heroCoordinateX, heroCoordinateY);
        }
    }
}
