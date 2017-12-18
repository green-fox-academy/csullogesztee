using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aircraft_carrier
{
    class F16 : Aircraft
    {
        public F16() : base(8, 30)
        {

        }

        public override string ToString()
        {
            return "F16";
        }
    }
}
