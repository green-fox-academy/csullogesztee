using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal
{
    class Program
    {
        static void Main(string[] args)
        {
            var tiger = new Animal(50, 50);

            tiger.Drink();
            tiger.Eat();
            tiger.Play();
            tiger.Play();
            tiger.Play();

            Console.WriteLine("The tiger's hunger is: " + tiger.GetHunger() + " and the tiger thirth is: " + tiger.GetThirst());

            Console.ReadLine();
        }
    }
}
