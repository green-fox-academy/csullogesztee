using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SantaClaus
{
    // The starting balance of the factory is 200.
    // It can produce toys until the balance is higher than 0.
    // Create the produce method.
    public class SantaFactory
    {
        public int Balance { get; set; }

        public SantaFactory()
        {
            Balance = 200;
        }

        public Toys Produce(string type, string color, int size)
        {
            Toys createdToy = new Toys();
            if (Balance > 0)
            {
                if (type == "ball")
                {
                    createdToy = new DottedBall(color, size);
                    Balance -= createdToy.Cost;
                }
            }
            return createdToy;
        }
        public Toys Produce(string type, int size)
        {
            Toys createdToy = new Toys();
            if (Balance > 0)
            {
                if (type == "rope")
                {
                    createdToy = new JumpingRope(size);
                    Balance -= createdToy.Cost;
                }
            }

            return createdToy;
        }
        public Toys Produce(string type, string color)
        {
            Toys createdToy = new Toys();
            if (Balance > 0)
            {
                if (type == "doll")
                {
                    createdToy = new Doll(color);
                    Balance -= createdToy.Cost;
                }
            }
            return createdToy;
        }

        public int GetBalance()
        {
            return Balance;
        }

    }
}
