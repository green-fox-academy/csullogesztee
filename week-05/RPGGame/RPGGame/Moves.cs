using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGGame
{
    class Moves
    {
        public void MoveHeroLeft(Hero hero)
        {
            hero.XCoordinate -= 50;
        }

        public void MoveHeroRight(Hero hero)
        {
            hero.XCoordinate += 50;
        }

        public void MoveHeroDown(Hero hero)
        {
            hero.YCoordinate += 50;
        }

        public void MoveHeroUp(Hero hero)
        {
            hero.YCoordinate -= 50;
        }
    }
}
