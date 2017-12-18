using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGGame
{
    class Skeletons : Characters
    {
        public Skeletons(int HP, int DP, int SP) : base(HP, DP, SP)
        {

        }

        public void DrawSkeleton(int skeletonCoordinateX, int skeletonCoordinateY)
        {
            myfoxDraw.AddImage("./h=skeleton.png", skeletonCoordinateX, skeletonCoordinateY);
        }
    }
}
