using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Instruments
{
    public class ElectricGuitar : StringedInstrument
    {
        public ElectricGuitar()
        {
            name = "Electric Guitar";
            numberOfStrings = 6;
        }

        public ElectricGuitar(int numberOfStrings)
        {
            name = "Electric Guitar";
            this.numberOfStrings = numberOfStrings;
        }

        public override string Sound()
        {
            return "Twang";
        }
    }
}
