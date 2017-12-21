using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Petrol_Station
{
    class Program
    {
        static void Main(string[] args)
        {
            Station station = new Station();
            Car car = new Car();

            Console.WriteLine("The amount of gas of the station: {0}, and the car: {1}", station.GasAmount, car.GasAmount);
            station.ReFill(car);
            Console.WriteLine("The amount of gas of the station: {0}, and the car: {1}", station.GasAmount, car.GasAmount);

            Console.ReadLine();
        }
    }
}
