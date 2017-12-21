using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversedOrder
{
    class Program
    {
        static void Main(string[] args)
        {
            string pathFrom = @"C:\Users\Esztee\greenfox\csullogesztee\CatchingUp\ReversedOrder\ReversedOrder\reversed-order.txt";
            string pathTo = @"C:\Users\Esztee\greenfox\csullogesztee\CatchingUp\ReversedOrder\ReversedOrder\original-order.txt";

            string[] content = File.ReadAllLines(pathFrom);

            File.WriteAllLines(pathTo, content.Reverse());
        }

    }
}
