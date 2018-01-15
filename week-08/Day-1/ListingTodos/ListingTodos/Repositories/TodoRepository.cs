using ListingTodos.Entities;
using ListingTodos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ListingTodos.Repositories
{
    public class TodoRepository
    {
        public ToDoContext toDoContext;

        public TodoRepository(ToDoContext toDoContext)
        {
            this.toDoContext = toDoContext;
        }

        public List<ToDo> ListOfToDos()
        {
            List<ToDo> ListOfToDos = new List<ToDo>();

            foreach (var item in toDoContext.ToDos)
            {
                ListOfToDos.Add(item);
            }

            return ListOfToDos;
        }

        public void AddNewTodo(ToDo toDo)
        {
            toDoContext.Add(toDo);
            toDoContext.SaveChanges();
        }
    }
}
