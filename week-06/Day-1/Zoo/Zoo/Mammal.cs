using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    class Mammal : Animal
    {
        public override bool WantChild()
        {
            return "want a child from my uterus!";
        }
    }
}
