using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenFox
{
    class PallidaClass
    {
        public string ClassName { get; set; }
        public List<Student> Students { get; set; }
        public List<Mentor> Mentors { get; set; }

        PallidaClass(string className)
        {
            this.ClassName = className;
        }

        public void AddStudent()
        {
            foreach (Student student in Students)
            {
                Students.Add(student);
            }
        }

        public void AddMentor()
        {
            foreach (Mentor mentor in Mentors)
            {
                Mentors.Add(mentor);
            }
        }

        public void Info()
        {
            Console.WriteLine("Pallida " + ClassName + " class has " + Students.Count + " students and " + Mentors.Count + " mentors.");
        }
    }
}
