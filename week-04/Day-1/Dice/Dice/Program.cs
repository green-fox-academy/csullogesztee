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
            Dice myDice = new Dice();

            Console.WriteLine(myDice.Roll());
            Console.ReadLine();
        }
    }
}
