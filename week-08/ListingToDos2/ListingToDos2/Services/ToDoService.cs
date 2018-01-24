using ListingTodos2.Models;
using ListingToDos2.Repositories;
using ListingToDos2.ViewModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ListingToDos2.Services
{
    public class ToDoService
    {
        public ToDoRepository toDoRepository;
        public ToDoUserViewModel toDoUserViewModel;

        public ToDoService(ToDoRepository toDoRepository, ToDoUserViewModel toDoUserViewModel)
        {
            this.toDoRepository = toDoRepository;
            this.toDoUserViewModel = toDoUserViewModel;
        }

        public List<ToDo> ListOfToDos()
        {
            List<ToDo> ListOfToDos = new List<ToDo>();

            toDoRepository.toDoContext.Users.Load();
            foreach (var item in toDoRepository.toDoContext.ToDos)
            {
                ListOfToDos.Add(item);
            }
            return ListOfToDos;
        }

        public ToDo CreateNewToDo(string title, User creator, User assignee)
        {
            ToDo newToDo = new ToDo()
            {
                Title = title,
                Creator = creator,
                Assignee = assignee
            };
            return newToDo;
        }

        public ToDo GetOneTodo(long id)
        {
            return toDoRepository.toDoContext.ToDos.FirstOrDefault(x => x.Id == id);
        }

        public List<ToDo> FilteredToDos(string TypeOfSearch, string SearchedText)
        {
            List<ToDo> filteredList = ListOfToDos();
            if (TypeOfSearch == "assignee")
            {
                filteredList = ListOfToDos().Where(x => x.Assignee.Name == SearchedText).Select(x => x).ToList();
            }
            if (TypeOfSearch == "creator")
            {
                filteredList = ListOfToDos().Where(x => x.Creator.Name == SearchedText).Select(x => x).ToList();
            }
            if (TypeOfSearch == "title")
            {
                filteredList = ListOfToDos().Where(x => x.Title == SearchedText).Select(x => x).ToList();
            }
            if (TypeOfSearch == "date")
            {
                filteredList = ListOfToDos().Where(x => x.Date == SearchedText).Select(x => x).ToList();
            }
            return filteredList;
        }
    }
}
