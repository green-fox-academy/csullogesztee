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
        public List<Student> Students
        {
            get
            {
                return students; 
            }
            set
            {
                students = value;
            }
        }
        public List<Mentor> Mentors
        {
            get
            {
                return mentors;
            }
            set
            {
                mentors = value;
            }
        }

        public PallidaClass(string className)
        {
            this.ClassName = className;
        }

        public void AddStudent(Student student)
        {
                Students.Add(student);
        }

        public void AddMentor(Mentor mentor)
        {
                Mentors.Add(mentor);
        }

        public void Info()
        {
            Console.WriteLine("Pallida " + ClassName + " class has " + Students.Count + " students and " + Mentors.Count + " mentors.");
        }
    }
}
