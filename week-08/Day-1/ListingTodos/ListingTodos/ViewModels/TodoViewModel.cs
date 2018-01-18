using ListingTodos.Models;
using ListingTodos.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ListingTodos.ViewModels
{
    public class TodoViewModel
    {
        public List<User> userList { get; set; } = new List<User>();
        public List<ToDo> todoList { get; set; } = new List<ToDo>();
        public long IdOfTodo { get; set; }

        public TodoViewModel()
        {
        }

        public ToDo OneToDo(long id)
        {
            var oneTodo = todoList.FirstOrDefault(x => x.Id == id);
            return oneTodo;
        }
    }
}
