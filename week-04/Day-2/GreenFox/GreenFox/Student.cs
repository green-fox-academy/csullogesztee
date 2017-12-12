using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenFox
{
    class Student : Person
    {
        public string PreviousOrganization { get; set; }
        public int SkippedDays { get; set; }

        public Student():base()
        {
            PreviousOrganization = "The School of Life";
            SkippedDays = 0;
        }

        public Student(string name, int age, string gender, string previousOrganization):base(name,age,gender)
        {
            this.PreviousOrganization = previousOrganization;
        }

        public override void Introduce()
        {
            Console.WriteLine("Hi, I'm " + Name + ", a " + Age + " year old " + Gender + " from " + PreviousOrganization + " who skipped " + SkippedDays + " days from the course already.");
        }

        public override void GetGoal()
        {
            Console.WriteLine("Be a junior software developer.");
        }

        public int SkipDays(int numberOffDays)
        {
            SkippedDays = SkippedDays - numberOffDays;
            return SkippedDays;
        }
    }
}
