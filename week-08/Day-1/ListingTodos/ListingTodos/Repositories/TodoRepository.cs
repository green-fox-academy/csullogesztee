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

        public void Edit(ToDo toDo, long id)
        {
            var toDoToUpdate = toDoContext.ToDos.Where(t => t.Id == id).FirstOrDefault();

            toDoToUpdate.Title = toDo.Title;
            toDoToUpdate.IsDone = toDo.IsDone;
            toDoToUpdate.IsUrgent = toDo.IsUrgent;
            toDoToUpdate.Assignee = toDo.Assignee;

            toDoContext.SaveChanges();
        }

        public List<User> ListOfToUsers()
        {
            List<User> ListOfUsers = new List<User>();

            foreach (var user in toDoContext.Users)
            {
                ListOfUsers.Add(user);
            }

            return ListOfUsers;
        }

        public void AddNewUser(User user)
        {
            toDoContext.Users.Add(user);
            toDoContext.SaveChanges();
        }
    }
}
