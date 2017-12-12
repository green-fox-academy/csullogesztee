using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garden_app
{
    class Flower : Garden
    {

        public int WaterAmountFlower;
        public string ColorOfFlower { get; set; }

        public Flower(string colorOfFlower, int waterAmountFlower)
        {
            this.ColorOfFlower = colorOfFlower;
            this.WaterAmountFlower = waterAmountFlower;
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
