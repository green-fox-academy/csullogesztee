using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sharpie
{
    class SharpieA
    {
        public string Color { get; set; }
        public float Width { get; set; }
        public float InkAmount { get; set; }

        public SharpieA(string color, float width)
        {
            color = Color;
            width = Width;
            InkAmount = 100;
        }

        public void Use()
        {
            InkAmount--;
        }

        public float GetInkAmount()
        {
            return InkAmount;
        }
    }
}
