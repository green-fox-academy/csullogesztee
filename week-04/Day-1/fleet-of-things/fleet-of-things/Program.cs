using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FleetOfThings
{
    public class FleetOfThings
    {
        public static void Main(string[] args)
        {
            var fleet = new Fleet();
            // Create a fleet of things to have this output:
            // 1. [ ] Get milk
            // 2. [ ] Remove the obstacles
            // 3. [x] Stand up
            // 4. [x] Eat lunch
            // Hint: You have to create a Print method also

            var thing0 = new Thing("Get milk");
            var thing1 = new Thing("Remove the obstacles");
            var thing2 = new Thing("Stand up");
            var thing3 = new Thing("Eat lunch");

            fleet.Add(thing0);
            fleet.Add(thing1);
            fleet.Add(thing2);
            fleet.Add(thing3);
            thing2.Complete();
            thing3.Complete();

            fleet.Printer();

            Console.ReadLine();
        }

    }
}