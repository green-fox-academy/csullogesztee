using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dice
{
    class Dice
    {
        int[] Dices = new int[6];
        static Random RandomValue;

    public int[] Roll()
    {
        for (int i = 0; i < Dices.Length; i++)
        {
                Dices[i] = RandomValue.Next(1, 6);
        }
        return Dices;
    }
    public int[] ReRoll()
    {
        for (int i = 0; i < Dices.Length; i++)
        {
            Dices[i] = RandomValue.Next(1, 6);
        }
        return Dices;
    }
    public int[] GetCurrent()
        {
            return Dices;
        }
        public int GetCurrent(int i)
        {
            return Dices[i];
        }
    }
}
