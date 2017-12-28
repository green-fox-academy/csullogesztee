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

        public Characters(FoxDraw foxDraw)
        {
            D6 = dice.Throw();
            myfoxDraw = foxDraw;
        }

        public Characters()
        {

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

        public void AddImages()
        {
            foreach(Characters character in ListOfCharacters)
            {
                if(Type == "Hero")
                {
                    myfoxDraw.AddImage("./hero-down.png", XCoordinate, YCoordinate);
                }

                if (Type == "Boss")
                {
                    myfoxDraw.AddImage("./boss.png", XCoordinate, YCoordinate);
                }

                if (Type == "Skeleton")
                {
                    myfoxDraw.AddImage("./skeleton.png", XCoordinate, YCoordinate);
                }
            }
        }

    }
}
