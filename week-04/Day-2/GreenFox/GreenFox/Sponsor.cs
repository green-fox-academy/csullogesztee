using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenFox
{
    class Sponsor : Person
    {
        public string Company { get; set; }
        public int HiredStudents { get; set; }

        public Sponsor() : base()
        {
            Company = "Google";
            HiredStudents = 0;
        }

        public Sponsor(string name, int age, string gender, string company) : base(name, age, gender)
        {
            this.Company = company;
        }

        public override void Introduce()
        {
            Console.WriteLine("Hi, I'm " + Name + " , a " + Age + " year old " + Gender + " who represents " + Company + " and hired " + HiredStudents + " students so far.");
        }

        public override void GetGoal()
        {
            Console.WriteLine("Hire brilliant junior software developers.");
        }

        public int Hire()
        {
            HiredStudents++;
            return HiredStudents;
        }
    }
}
