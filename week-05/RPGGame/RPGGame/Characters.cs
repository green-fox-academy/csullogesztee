using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GreenFox;

namespace RPGGame
{
    public class Characters
    {
        Dice dice = new Dice();
        public int D6 { get; set; }

        public int XCoordinate { get; set; }
        public int YCoordinate { get; set; }

        public int MaxHealthPoint { get; set; }
        public int CurrentHealthPoint { get; set; }
        public int DefendPoint { get; set; }
        public int StrikePoint { get; set; }
        public int Level { get; set; }

        public Characters(Map map)
        {
            D6 = dice.Throw();
        }
    }
}
