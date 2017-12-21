using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pirates
{
    class Pirates
    {
        Random random = new Random();
        public int BloodAlcohol { get; set; }
        public bool Alive { get; set; }
        public bool Sleep { get; set; }

        public Pirates()
        {
            BloodAlcohol = random.Next(1, 5);
            Alive = true;
            Sleep = false;
        }

        public int DrinkSomeRum()
        {
            return BloodAlcohol++;
        }

        public void HowsItGoingMate()
        {

        }

        public void Brawl()
        {
            int possibility = random.Next(1, 4);

            if (possibility == 1)
            {
                Die();
            }
            else
            {
                PassesOut();
            }

        }

        public bool PassesOut()
        {
            Sleep = true;
            return Sleep;
        }

        public bool Die()
        {
            Alive = false;
            return Alive;
        }
    }
}
