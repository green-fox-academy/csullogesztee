using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Instruments
{
    public class Violin : StringedInstrument
    {
        public Violin()
        {
            name = "violin";
            numberOfStrings = 4;
        }

        public override string Sound()
        {
            return "Screech";
        }
    }
}
