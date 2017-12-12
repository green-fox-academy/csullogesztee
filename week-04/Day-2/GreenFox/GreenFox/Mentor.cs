using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenFox
{
    class Mentor : Person
    {
        public string Level { get; set; }

        public Mentor() : base()
        {
            Level = "intermediate";
        }

        public Mentor(string name, int age, string gender, string level) : base(name, age, gender)
        {
            this.Level = level;
        }

        public override void Introduce()
        {
            Console.WriteLine("Hi, I'm " + Name + ", a " + Age + " year old " + Gender + Level + " mentor.");
        }

        public override void GetGoal()
        {
            Console.WriteLine("Educate brilliant junior software developers.");
        }
    }
}
