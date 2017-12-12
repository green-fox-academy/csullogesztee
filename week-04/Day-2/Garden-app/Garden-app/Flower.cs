using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garden_app
{
    class Flower
    {
        private int WaterAmountFlower;

        public string ColorOfFlower { get; set; }

        public Flower(string colorOfFlower)
        {
            this.ColorOfFlower = colorOfFlower;
            WaterAmountFlower = 2;
        }

        public void NeedWater()
        {
            if (WaterAmountFlower < 10)
            {
                Console.WriteLine("The " + ColorOfFlower + " tree needs water");
            }
            else
            {
                Console.WriteLine("The " + ColorOfFlower + " tree doesn't need water");
            }
        }
    }
}
