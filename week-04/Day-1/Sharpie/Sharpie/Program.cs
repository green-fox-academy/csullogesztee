using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sharpie
{
    class Program
    {
        static void Main(string[] args)
        {
            var newsharpie = Sharpie("Black", 5.5);

            newsharpie.Use();
            newsharpie.Use();

            Console.WriteLine(newsharpie.GetInkAmount());
            Console.ReadLine();
        }
    }
}
