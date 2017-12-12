using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garden_app
{
    class Tree : Garden
    {

        public int WaterAmountTree;
        public string ColorOfTree { get; set; }

        public Tree(string colorOfTree, int waterAmountTree)
        {
            this.ColorOfTree = colorOfTree;
            this.WaterAmountTree = waterAmountTree;
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
