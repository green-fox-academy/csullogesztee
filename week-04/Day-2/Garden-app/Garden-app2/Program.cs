using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garden_app2
{
    class Program
    {
        static void Main(string[] args)
        {
            Garden mygarden = new Garden();

            mygarden.Plants.Add(new Flower("yellow"));
            mygarden.Plants.Add(new Flower("blue"));
            mygarden.Plants.Add(new Tree("purple"));
            mygarden.Plants.Add(new Tree("orange"));

            mygarden.WriteOutState();
            mygarden.Watering(40);
            mygarden.WriteOutState();
            mygarden.Watering(70);
            mygarden.WriteOutState();

            Console.ReadKey();
        }
    }
}
