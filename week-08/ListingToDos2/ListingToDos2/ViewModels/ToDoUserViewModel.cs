using ListingTodos2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ListingToDos2.ViewModels
{
    public class ToDoUserViewModel
    {
        public List<User> UserList { get; set; } = new List<User>();
        public List<ToDo> ToDoList { get; set; } = new List<ToDo>();
        public long UserId { get; set; }
        public long ToDoId { get; set; }

        public ToDo GetOneToDo()
        {
             return ToDoList.FirstOrDefault(todo => todo.Id == ToDoId);
        }

        public User GetOneUser()
        {
            return UserList.FirstOrDefault(user => user.UserId == UserId);
        }
    }
}
