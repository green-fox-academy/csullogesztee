using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dice
{
    class Program
    {
        static void Main(string[] args)
        {
           var dices = new List<Dice>();
           for (int i = 0; i < 6; i++)
           {
                dices.Add(new Dice());
           }
           for (int j = 0; j < 6; j++)
           {
                dices[j].Roll();
                if (dices[j].GetCurrentNumber() != 6)
                {
                    dices[j].ReRoll();
                }
                Console.WriteLine(dices[j].GetCurrentNumber());
           }
           Console.ReadLine();
        }
    }
}
