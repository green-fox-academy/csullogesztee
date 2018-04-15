using ErrorHandlingTrial.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ErrorHandlingTrial.Services
{
    public class StudentService
    {
        public List<Student> StudentList { get; set; } = new List<Student>();

        public StudentService()
        {
            AddStudents();
        }

        public void AddStudents()
        {
            StudentList.Add(new Student(1, "Anna"));
            StudentList.Add(new Student(2, "Bela"));
            StudentList.Add(new Student(3, "Sanyi"));
            StudentList.Add(new Student(4, "Nori"));
            StudentList.Add(new Student(5, "Lejla"));
            StudentList.Add(new Student(6, "Luke"));
        }

        public Student SearchByName(string name)
        {
            return StudentList.Single(x => x.Name.Equals(name));
        }

        public Student SearchById(int id)
        {
            if(StudentList.Count < id)
            {
                throw new HttpStatusCodeException(404, "sorry not found");
            }
            else
            {
                return StudentList.Single(x => x.Id == id); ;
            }
        }
    }
}
