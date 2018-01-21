using ListingTodos2.Entities;
using ListingTodos2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ListingToDos2.Repositories
{
    public class ToDoRepository
    {
        public TodoContext toDoContext;

        public ToDoRepository(TodoContext toDoContext)
        {
            this.toDoContext = toDoContext;
        }

        public void AddNewTodo(ToDo toDo)
        {
            toDoContext.ToDos.Add(toDo);
            toDoContext.SaveChanges();
        }

        public void DeleteToDo(long id)
        {
            foreach (var item in toDoContext.ToDos)
            {
                if (item.Id == id)
                    toDoContext.Remove(item);
            }
            toDoContext.SaveChanges();
        }

        public void EditToDo(ToDo toDo, long id)
        {
            var toDoToUpdate = toDoContext.ToDos.Where(t => t.Id == id).FirstOrDefault();

            toDoToUpdate.Title = toDo.Title;
            toDoToUpdate.IsDone = toDo.IsDone;
            toDoToUpdate.IsUrgent = toDo.IsUrgent;
            toDoToUpdate.Assignee = toDo.Assignee;

            toDoContext.SaveChanges();
        }
    }
}
