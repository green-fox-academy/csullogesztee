using GreenFox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGGame
{
    class Skeletons : Characters
    {
        public bool Key { get; set; }

        public Skeletons(bool haveKey, Map map) : base(map)
        {
            Type = "Skeleton";
            MaxHealthPoint = 2 * Level * D6;
            CurrentHealthPoint = MaxHealthPoint;
            DefendPoint = Level / 2 * D6;
            StrikePoint = Level * D6;
            Key = haveKey;
        }

    }
}
