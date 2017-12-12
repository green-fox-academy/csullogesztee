using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garden_app
{
    class Tree
    {
        private int WaterAmountTree;

        public string ColorOfTree { get; set; }

        public Tree(string colorOfTree)
        {
            this.ColorOfTree = colorOfTree;
            WaterAmountTree = 2;
        }

        public void NeedWater()
        {
            if (WaterAmountTree < 10)
            {
                Console.WriteLine("The " + ColorOfTree + " tree needs water");
            }
            else
            {
                Console.WriteLine("The " + ColorOfTree + " tree doesn't need water");
            }
        }
    }
}
