using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Instruments
{
    public class BassGuitar : StringedInstrument
    {
        public BassGuitar()
        {
            name = "Bass Guitar";
            numberOfStrings = 4;
        }

        public BassGuitar(int numberOfStrings)
        {
            name = "Bass Guitar";
            this.numberOfStrings = numberOfStrings;
        }

        public override string Sound()
        {
            return "Duum-duum-duum";
        }
    }
}
