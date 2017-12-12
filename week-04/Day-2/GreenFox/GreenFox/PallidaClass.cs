using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenFox
{
    class PallidaClass
    {
        private List<Student> students = new List<Student>();
        private List<Mentor> mentors = new List<Mentor>();

        public string ClassName { get; set; }
        //public List<Student> Students
        //{ get
        //    { return students }
        //    set
        //    { return students = value} };
        //public List<Mentor> Mentors { get; set; }

        public PallidaClass(string className)
        {
            this.ClassName = className;
        }

        public void AddStudent(Student student)
        {
                students.Add(student);
        }

        public void AddMentor(Mentor mentor)
        {
                mentors.Add(mentor);
        }

        public void Info()
        {
            Console.WriteLine("Pallida " + ClassName + " class has " + students.Count + " students and " + mentors.Count + " mentors.");
        }
    }
}
