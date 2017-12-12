using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal
{
    class Animal
    { 
        private int Hunger = 50;
        private int Thirst = 50;

        public Animal(int hunger, int thirst)
        {
            hunger = Hunger;
            thirst = Thirst;
        }
        public void Eat()
        {
            Hunger--;
        }
        public void Drink()
        {
            Thirst--;
        }
        public void Play()
        {
            Hunger++;
            Thirst++;
        }
        public int GetHunger()
        {
            return Hunger;
        }

        public int GetThirst()
        {
            return Thirst;
        }
    }
}
