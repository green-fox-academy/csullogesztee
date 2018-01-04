using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SantaClaus
{
    // - Doll, it costs 25, and can be different colour(String)
    public class Doll : Toys
    {
        private string color;

        public Doll(string color)
        {
            Cost = 25;
            Type = "doll";
            this.color = color;
        }
    }
}
