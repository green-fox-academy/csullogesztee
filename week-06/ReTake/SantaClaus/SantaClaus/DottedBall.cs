using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SantaClaus
{
    // - Dotted ball, costs 10, and can be different colour and size.
    public class DottedBall : Toys
    {
        private int size;
        private string color;

        public DottedBall(string color, int size)
        {
            Cost = 10;
            Type = "ball";
            this.size = size;
            this.color = color;
        }
    }
}
