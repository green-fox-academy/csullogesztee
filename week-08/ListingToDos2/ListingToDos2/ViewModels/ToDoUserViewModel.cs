using ListingTodos2.Models;
using System.Collections.Generic;

namespace ListingToDos2.ViewModels
{
    public class ToDoUserViewModel
    {
        public List<User> UserList { get; set; } = new List<User>();
        public List<ToDo> ToDoList { get; set; } = new List<ToDo>();
        public ToDo OneToDo { get; set; }
        public User OneUser { get; set; }
    }
}
