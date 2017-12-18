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
        public FoxDraw myfoxDraw { get; set; }

        public int MaxHealthPoint { get; set; }
        public int CurrentHealthPoint { get; set; }
        public int DefendPoint { get; set; }
        public int StrikePoint { get; set; }
        public bool Alive { get; set; }

        public Characters()
        {

        }

        public Characters(int HP, int DP, int SP)
        {
            CurrentHealthPoint = HP;
            DefendPoint = DP;
            StrikePoint = SP;
        }

        public bool IsItAlive(Characters character)
        {
            if (character.CurrentHealthPoint > 0)
            {
                Alive = true;
            }
            else
            {
                Alive = false;
            }
            return Alive;
        }


    }
}
