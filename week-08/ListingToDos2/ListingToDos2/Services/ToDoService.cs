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

        public ToDo GetTheTodo(long id)
        {
            return toDoRepository.toDoContext.ToDos.FirstOrDefault(x => x.Id == id);
        }
    }
}
