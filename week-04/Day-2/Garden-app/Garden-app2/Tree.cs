using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garden_app2
{
    class Tree : Plant
    {
        public Tree(string color) : base(color, 0.4, 5)
        {

        }

        public override string ToString()
        {
            return "tree";
        }

        public override bool NeedsWater
        {
            get
            {
                return WaterAmount < 10;
            }
        }
    }
}
