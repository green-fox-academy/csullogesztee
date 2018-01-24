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
        public string TypeOfSearch { get; set; } = string.Empty;
        public string SearchedText { get; set; } = string.Empty;

        public ToDo GetOneToDo()
        {
             return ToDoList.FirstOrDefault(todo => todo.Id == ToDoId);
        }

        public User GetOneUser()
        {
            return UserList.FirstOrDefault(user => user.UserId == UserId);
        }

        public List<ToDo> FilteredToDos()
        {
            List<ToDo> filteredList = ToDoList;
            if (TypeOfSearch == "assignee")
            {
                filteredList = ToDoList.Where(x => x.Assignee.Name == SearchedText).Select(x => x).ToList();
            }
            if (TypeOfSearch == "creator")
            {
                filteredList = ToDoList.Where(x => x.Creator.Name == SearchedText).Select(x => x).ToList();
            }
            if (TypeOfSearch == "title")
            {
                filteredList = ToDoList.Where(x => x.Title == SearchedText).Select(x => x).ToList();
            }
            if (TypeOfSearch == "date")
            {
                filteredList = ToDoList.Where(x => x.Date == SearchedText).Select(x => x).ToList();
            }
            return filteredList;
        }
    }
}
