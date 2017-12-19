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
            Carrier mycarrier= new Carrier();
            Carrier enemy = new Carrier();

            Console.WriteLine(mycarrier.GetStatusCarrier());

            mycarrier.AddAirCraft("F35");
            mycarrier.AddAirCraft("F35");
            mycarrier.AddAirCraft("F35");
            mycarrier.AddAirCraft("F16");
            mycarrier.AddAirCraft("F16");

            Console.WriteLine(mycarrier.GetStatusCarrier());
            foreach (string status in mycarrier.GetStatusAirCrafts())
            {
                Console.WriteLine(status);
            }

            mycarrier.Fill();

            Console.WriteLine(mycarrier.GetStatusCarrier());
            foreach (string status in mycarrier.GetStatusAirCrafts())
            {
                Console.WriteLine(status);
            }

            enemy.GetFight(mycarrier);

            Console.WriteLine(mycarrier.GetStatusCarrier());
            foreach (string status in mycarrier.GetStatusAirCrafts())
            {
                Console.WriteLine(status);
            }
            Console.WriteLine(enemy.GetStatusCarrier());

            mycarrier.Fill();

            Console.WriteLine(mycarrier.GetStatusCarrier());
            foreach (string status in mycarrier.GetStatusAirCrafts())
            {
                Console.WriteLine(status);
            }

            enemy.GetFight(mycarrier);

            Console.WriteLine(mycarrier.GetStatusCarrier());
            foreach (string status in mycarrier.GetStatusAirCrafts())
            {
                Console.WriteLine(status);
            }
            Console.WriteLine(enemy.GetStatusCarrier());

            Console.ReadKey();
        }
    }
}
