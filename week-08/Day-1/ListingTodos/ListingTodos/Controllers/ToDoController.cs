using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ListingTodos.Models;
using ListingTodos.Repositories;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ListingTodos.Controllers
{
    [Route("")]
    public class ToDoController : Controller
    {
        public TodoRepository todoRepository;

        public ToDoController(TodoRepository todoRepository)
        {
            this.todoRepository = todoRepository;
        }

        [Route("todo")]
        public IActionResult Index()
        {
            return View();
        }

        [Route("")]
        [Route("/list")]
        public IActionResult List()
        {
            ToDo newToDo = new ToDo()
            {
                Title = "coffee"
            };

            todoRepository.AddNewTodo(newToDo);

            return View(todoRepository.ListOfToDos());
        }
    }
}
