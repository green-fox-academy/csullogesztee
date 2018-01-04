using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SantaClaus
{
    // Each toy have an owner, when produced the owner should be null.
    public class Toys
    {
        public string Owner { get; set; }
        public int Cost { get; set; }
        public string Type { get; set; }
    }
}
