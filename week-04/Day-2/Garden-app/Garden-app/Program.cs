using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garden_app
{
    class Program
    {
        static void Main(string[] args)
        {
            Garden plantsofgarden = new Garden();

            Flower flower1 = new Flower("yellow", 2);
            plantsofgarden.AddFlower(flower1);
            Flower flower2 = new Flower("blue", 2);
            plantsofgarden.AddFlower(flower2);
            Tree tree1 = new Tree("purple", 2);
            plantsofgarden.AddTree(tree1);
            Tree tree2 = new Tree("orange", 5);
            plantsofgarden.AddTree(tree2);

            int addsomewater = 400;

            

            for (int i = 0; i < 2; i++)
            {
                plantsofgarden.Flowers[i].NeedWater();
                plantsofgarden.Trees[i].NeedWater();
                Console.WriteLine("flower: " + plantsofgarden.Flowers[i].WaterAmountFlower + " tree: " + plantsofgarden.Trees[i].WaterAmountTree);
                plantsofgarden.WateringFlower(addsomewater, plantsofgarden.Flowers[i]);
                plantsofgarden.WateringTree(addsomewater, plantsofgarden.Trees[i]);
                
                Console.WriteLine("flower: " + plantsofgarden.Flowers[i].WaterAmountFlower + " tree: " + plantsofgarden.Trees[i].WaterAmountTree);
            }
            Console.ReadLine();
        }
    }
}
