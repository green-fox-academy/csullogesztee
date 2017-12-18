using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aircraft_carrier
{
    class Program
    {
        static void Main(string[] args)
        {
            Carrier carrier1 = new Carrier();
            Carrier carrier2 = new Carrier(5000);

            carrier1.GetStatusCarrier();

            carrier1.AddAirCraft("F35");
            carrier1.AddAirCraft("F35");
            carrier1.AddAirCraft("F35");
            carrier1.AddAirCraft("F16");
            carrier1.AddAirCraft("F16");

            carrier1.GetStatusAirCrafts();

            carrier1.Fill();

            carrier1.GetStatusCarrier();
            carrier1.GetStatusAirCrafts();

            carrier2.GetFight(carrier1);

            carrier2.GetStatusCarrier();

            Console.ReadKey();
        }
    }
}
