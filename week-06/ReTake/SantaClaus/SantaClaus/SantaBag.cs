using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SantaClaus
{
    // The produced toys are going into Santa's bag as you can see below in the example.
    // Santa brings the toys to the children until there is something in the bag.
    // When a toy is being delivered, it gets it's owner (a random children name) and gets removed from the bag.
    // Create the bring method.
    public class SantaBag
    {
        List<Toys> santaBag = new List<Toys>();

        public SantaBag()
        {

        }

        public void Add(Toys toy)
        {
            santaBag.Add(toy);
        }

        public void BringToysToChildren()
        {
            if(santaBag.Count != 0)
            {
                santaBag[0].Owner = "Peter";
                santaBag.RemoveAt(0);
            }
        }

        public int GetNumberOfItems()
        {
            return santaBag.Count();
        }
    }
}
