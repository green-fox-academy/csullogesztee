using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGGame
{
    class Boss : Characters
    {
        public Boss(int HP, int DP, int SP) : base(HP, DP, SP)
        {

        }

        public void DrawBoss(int bossCoordinateX, int bossCoordinateY)
        {
            myfoxDraw.AddImage("./hero-up.png", bossCoordinateX, bossCoordinateY);
        }
    }
}
