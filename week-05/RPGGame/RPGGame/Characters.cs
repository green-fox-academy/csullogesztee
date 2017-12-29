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
        Random random = new Random();
        Dice dice = new Dice();
        public int D6 { get; set; }

        public FoxDraw myfoxDraw { get; set; }
        public int XCoordinate { get; set; }
        public int YCoordinate { get; set; }
        public int XCoor { get; set; }
        public int YCoor { get; set; }

        public string Type { get; set; }
        public int MaxHealthPoint { get; set; }
        public int CurrentHealthPoint { get; set; }
        public int DefendPoint { get; set; }
        public int StrikePoint { get; set; }
        public int Level { get; set; } = 1;

        public Characters(Map map)
        {
            D6 = dice.Throw();

            XCoor = random.Next(0, 10);
            YCoor = random.Next(0, 10);

            while (map.GenerateMap()[XCoor, YCoor] != 0)
            {
            XCoor = random.Next(0, 10);
            YCoor = random.Next(0, 10);
            }

            XCoordinate = XCoor * 50;
            YCoordinate = YCoor * 50;
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
                if (character.Type == "Hero")
                {
                    foxDraw.AddImage("./hero-down.png", character.XCoordinate, character.YCoordinate);
                }

                if (character.Type == "Boss")
                {
                    foxDraw.AddImage("./boss.png", character.XCoordinate, character.YCoordinate);
                }

                if (character.Type == "Skeleton")
                {
                    foxDraw.AddImage("./skeleton.png", character.XCoordinate, character.YCoordinate);
                }
            }
        }

    }
}
