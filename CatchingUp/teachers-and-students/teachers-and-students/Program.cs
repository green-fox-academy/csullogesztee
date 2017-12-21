using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teachers_and_students
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            Teacher teacher = new Teacher();

            Console.WriteLine(teacher.Teach(student.Learn()));
            Console.WriteLine(student.Question(teacher.Answer()));

            Console.ReadLine();
        }
    }
}
