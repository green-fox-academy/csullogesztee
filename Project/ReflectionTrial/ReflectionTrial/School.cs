using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionTrial
{
    class School
    {
        public List<People> SchoolMembers { get; set; }

        public School()
        {
            SchoolMembers = CreateList();
        }

        private List<People> CreateList()
        {
            List<People> newList = new List<People>();

            newList.Add(new Student() { Name = "Pisti", Age = 12, Clever = true, Status = "student"});
            newList.Add(new Student() { Name = "Peti", Age = 12, Clever = false, Status = "student"});
            newList.Add(new Student() { Name = "Emese", Age = 14, Clever = true, Status = "student"});
            newList.Add(new Teacher() { Name = "Kata", Age = 42, Clever = false, Status = "teacher"});
            newList.Add(new Teacher() { Name = "Barna", Age = 50, Clever = true, Status = "teacher"});
            newList.Add(new Teacher() { Name = "Ivan", Age = 60, Clever = false, Status = "teacher"});


            return newList;
        }
    }
}
