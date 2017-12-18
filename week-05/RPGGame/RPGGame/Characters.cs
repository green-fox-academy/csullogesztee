using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GreenFox;

namespace RPGGame
{
    class Characters
    {
        public FoxDraw myfoxDraw { get; set; }

        protected int MaxHealthPoint { get; set; }
        protected int CurrentHealthPoint { get; set; }
        protected int DefendPoint { get; set; }
        protected int StrikePoint { get; set; }
        public bool Alive { get; set; }

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
