using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using GreenFox;

namespace RPGGame
{
    public class Characters
    {
        Dice dice = new Dice();
        public int D6 { get; set; }

        public FoxDraw myfoxDraw { get; set; }
        public int XCoordinate { get; set; }
        public int YCoordinate { get; set; }

        public string Type { get; set; }
        public int MaxHealthPoint { get; set; }
        public int CurrentHealthPoint { get; set; }
        public int DefendPoint { get; set; }
        public int StrikePoint { get; set; }
        public int Level { get; set; } = 1;

        public Characters()
        {
            D6 = dice.Throw();
        }

        List<Characters> ListOfCharacters = new List<Characters>();

        public void AddCharacter(Characters character)
        {
            ListOfCharacters.Add(character);
        }

        public void LevelUp()
        {
            foreach (Characters Character in ListOfCharacters)
            {
                if (Type == "Hero")
                {
                    MaxHealthPoint += D6;
                    DefendPoint += D6;
                    StrikePoint += D6;
                }
                else
                {
                    Level++;
                }
            }
        }

        public void AddImages(FoxDraw foxDraw)
        {
            foreach (Characters character in ListOfCharacters)
            {
                if (Type == "Hero")
                {
                    foxDraw.AddImage("./hero-down.png", XCoordinate, YCoordinate + 50);
                }

                if (Type == "Boss")
                {
                    foxDraw.AddImage("./boss.png", XCoordinate, YCoordinate + 100);
                }

                if (Type == "Skeleton")
                {
                    foxDraw.AddImage("./skeleton.png", XCoordinate, YCoordinate + 150);
                }
            }
            foxDraw.AddImage("./skeleton.png", XCoordinate+100, YCoordinate);
            foxDraw.AddImage("./boss.png", XCoordinate+50, YCoordinate);
            foxDraw.AddImage("./hero-down.png", XCoordinate, YCoordinate);
        }

    }
}
