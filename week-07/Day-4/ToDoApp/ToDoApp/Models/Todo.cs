using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ToDoApp.Models
{
    public class Todo : ToDoList
    {
        public string Exercise { get; set; }
        public string Complete { get; set; }
        public string Urgent { get; set; }

        public Todo()
        {
        }

        public Todo(string exercise, string urgent)
        {
            Exercise = exercise;
            Complete = "[ ]";
            if (urgent.Equals("yes"))
                Urgent = "!";
        }
    }
}
