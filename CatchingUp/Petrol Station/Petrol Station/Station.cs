using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Petrol_Station
{
    class Station
    {
        public int GasAmount { get; set; }

        public Station()
        {
            GasAmount = 5000;
        }

        public void ReFill(Car car)
        {
            GasAmount -= car.Capacity;
            car.GasAmount = car.Capacity;
        }

    }
}
