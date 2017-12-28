using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGGame
{
    public class Hero : Characters
    {
        public Hero(Map map) : base(map)
        {
            MaxHealthPoint = 20 + 3 * D6;
            DefendPoint = 2 * D6;
            StrikePoint = 5 + D6;
        }
    }
}
