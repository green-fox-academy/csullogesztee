using GreenFox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGGame
{
    public class Hero : Characters
    {
        public Hero() : base()
        {
            Type = "Hero";
            MaxHealthPoint = 20 + 3 * D6;
            CurrentHealthPoint = MaxHealthPoint;
            DefendPoint = 2 * D6;
            StrikePoint = 5 + D6;
            XCoordinate = 0;
            YCoordinate = 0;
        }
    }
}
