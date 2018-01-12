using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ToDoApp.Models
{
    public class ToDoList
    {
        public Dictionary<int, Todo> ListOfToDos { get; set; }

        public ToDoList()
        {
            ListOfToDos = new Dictionary<int, Todo>();
        }

        public void AddTodo(Todo todo)
        {
                ListOfToDos.Add((ListOfToDos.Count + 1), todo);
        }

        public void Ready(int number)
        {
            foreach (var exercise in ListOfToDos)
            {
                if (exercise.Key == number)
                    exercise.Value.Complete = "[X]";
            }
        }

        public void Delete(int number)
        {
            ListOfToDos.Remove(number);
        }
    }
}
