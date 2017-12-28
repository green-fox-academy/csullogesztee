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

        public string Type { get; set; }
        public int MaxHealthPoint { get; set; }
        public int CurrentHealthPoint { get; set; }
        public int DefendPoint { get; set; }
        public int StrikePoint { get; set; }
        public int Level { get; set; } = 1;

        public Characters(Map map)
        {
            D6 = dice.Throw();
        }

        public void LevelUp(Characters character)
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

        List<Characters> Enemies = new List<Characters>();

        public void AddEnemies(Characters enemy)
        {
            Enemies.Add(enemy);
        }
    }
}
