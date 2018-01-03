using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    public abstract class Animal
    {
        protected string name;
        protected int age;
        protected string gender;
        protected bool carnivorous;
        protected bool herbivorous;

        public abstract void Greet();

        public abstract bool WantChild();
    }
}
