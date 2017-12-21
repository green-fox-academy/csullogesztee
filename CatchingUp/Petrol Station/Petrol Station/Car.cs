using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Petrol_Station
{
    class Car
    {
        public int GasAmount { get; set; }
        public int Capacity { get; }

        public Car()
        {
            GasAmount = 0;
            Capacity = 100;
        }

    }
}
