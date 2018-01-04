using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SantaClaus
{
    public class SantaClaus
    {
        public static List<string> Children = new List<string>() { "Peter", "Lily", "John", "Jane" };

        public static void Main(string[] args)
        {
            // Create SantaFactory and help Santa bring the remaining toys to the poor children.
            // There are 3 kind of toys:
            // - Doll, it costs 25, and can be different colour(String).
            // - Dotted ball, costs 10, and can be different colour and size.
            // - Jumping rope, costs 15, and can be different length(int).
            // Each toy have an owner, when produced the owner should be null.
            // The starting balance of the factory is 200.
            // It can produce toys until the balance is higher than 0.
            // Create the produce method.
            // The produced toys are going into Santa's bag as you can see below in the example.
            // Santa brings the toys to the children until there is something in the bag.
            // When a toy is being delivered, it gets it's owner (a random children name) and gets removed from the bag.
            // Create the bring method.
            var santaBag = new SantaBag();

            var santaFactory = new SantaFactory();
           // santaBag.Add(santaFactory.Produce("doll", "pink"));
            santaBag.Add(santaFactory.Produce("ball", "blue", 3));
            santaBag.Add(santaFactory.Produce("ball", "yellow", 1));
           // santaBag.Add(santaFactory.Produce("rope", 22));

            // The output should be "The factory's balance is: 140";
            Console.WriteLine("The factory's balance is: {0}", santaFactory.GetBalance());
            // The output should be "There are 4 undelivered toys in Santa's bag.";
            Console.WriteLine("There are {0} toys in Santa's bag.", santaBag.GetNumberOfItems());

            santaBag.BringToysToChildren();
            // The output should be "There are 0 undelivered toys in Santa's bag.";
            Console.WriteLine("There are {0} toys in Santa's bag.", santaBag.GetNumberOfItems());

            Console.ReadKey();
        }
    }
}
