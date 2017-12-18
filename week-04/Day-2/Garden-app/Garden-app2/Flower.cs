using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garden_app2
{
    class Flower : Plant
    {
        public Flower(string color) : base(color, 0.75, 2)
        {
            
        }

        public override string ToString()
        {
            return "flower";
        }

        public override bool NeedsWater
        {
            get
            {
                return WaterAmount < 5;
            }
        }
    }
}
