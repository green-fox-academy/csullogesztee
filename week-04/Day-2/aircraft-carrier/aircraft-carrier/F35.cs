using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aircraft_carrier
{
    class F35 : Aircraft
    {
        public F35() : base(12, 50)
        {

        }

        public override string ToString()
        {
            return "F35";
        }
    }
}
