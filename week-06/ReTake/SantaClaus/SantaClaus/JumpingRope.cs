using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SantaClaus
{
    // - Jumping rope, costs 15, and can be different length(int).
    public class JumpingRope : Toys
    {
        private int length;

        public JumpingRope(int length)
        {
            Cost = 15;
            Type = "rope";
            this.length = length;
        }
    }
}
