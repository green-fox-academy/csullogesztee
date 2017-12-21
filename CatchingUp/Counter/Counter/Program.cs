using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CounterProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Counter counter = new Counter();

            Console.WriteLine(counter.MyNumber);
            counter.AddOne();
            Console.WriteLine(counter.MyNumber);
            counter.AddNumber(10);
            Console.WriteLine(counter.MyNumber);
            Console.WriteLine(counter.GetNumber());
            counter.Reset();
            Console.WriteLine(counter.MyNumber);

            Console.ReadLine();

        }
    }
}
