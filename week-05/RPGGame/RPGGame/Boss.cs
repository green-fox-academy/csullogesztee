using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGGame
{
    class Boss : Characters
    {
        public Boss(Map map) : base(map)
        {
            Type = "Boss";
            MaxHealthPoint = (2 * Level + 1) * D6;
            CurrentHealthPoint = MaxHealthPoint;
            DefendPoint = Level / 2 * D6 + D6 / 2;
            StrikePoint = Level * (D6 + 1);
        }
    }
}
