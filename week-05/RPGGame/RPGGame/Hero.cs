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
        public Hero(Map map) : base(map)
        {
            Type = "Hero";
            MaxHealthPoint = 20 + 3 * D6;
            CurrentHealthPoint = MaxHealthPoint;
            DefendPoint = 2 * D6;
            StrikePoint = 5 + D6;
            XCoordinate = 0;
            YCoordinate = 0;
        }

        public void HeroUp(FoxDraw foxDraw)
        {
            YCoordinate -= 50;
            foxDraw.SetPosition(foxDraw.CharactersList[0], XCoordinate, YCoordinate);
        }

        public void HeroDown(FoxDraw foxDraw)
        {
            YCoordinate += 50;
            foxDraw.SetPosition(foxDraw.CharactersList[0], XCoordinate, YCoordinate);
        }

        public void HeroLeft(FoxDraw foxDraw)
        {
            XCoordinate -= 50;
            foxDraw.SetPosition(foxDraw.CharactersList[0], XCoordinate, YCoordinate);
        }

        public void HeroRight(FoxDraw foxDraw)
        {
            XCoordinate += 50;
            foxDraw.SetPosition(foxDraw.CharactersList[0], XCoordinate, YCoordinate);
        }

    }
}
