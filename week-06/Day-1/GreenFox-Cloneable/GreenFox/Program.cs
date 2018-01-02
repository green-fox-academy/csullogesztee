using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();

            Student john = new Student("John Doe", 20, "male", "BME");
            people.Add(john);

            Student johnTheClone = john.Clone() as Student;
            people.Add(johnTheClone);

            foreach (Person person in people)
            {
                person.Introduce();
                person.GetGoal();
            }

            Console.ReadLine();
        }
    }
}
