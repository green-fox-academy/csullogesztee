using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise10
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Fox> foxList = new List<Fox>();

            foxList.Add(new Fox("Lajos", "red", "pallida"));
            foxList.Add(new Fox("Tihamer", "green", "pallida"));
            foxList.Add(new Fox("Karcsi", "green", "corsac"));
            foxList.Add(new Fox("Zakarias", "blue", "corsac"));
            foxList.Add(new Fox("Oyondur", "red", "pallida"));

            var greenFoxes = foxList.Where(fox => fox.Color == "green");
            var corsacFoxes = foxList.Where(fox => fox.Type == "corsac" && fox.Color == "green");


            Console.WriteLine("The green foxes:");
            foreach (Fox fox in greenFoxes)
            {
                Console.WriteLine(fox.Name);
            }

            Console.WriteLine("The green corsac foxes:");
            foreach (Fox fox in corsacFoxes)
            {
                Console.WriteLine(fox.Name);
            }


            Console.ReadKey();
        }
    }
}
