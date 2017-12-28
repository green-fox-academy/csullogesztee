using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGGame
{
    public class Dice
    {
        Random dice = new Random();
        public int DicedNumber { get; set; }

        public int Throw()
        {
            return DicedNumber = dice.Next(1,7);
        }
    }
}
