using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ListingTodos2.Models;
using ListingToDos2.Services;
using Microsoft.AspNetCore.Mvc;

namespace ListingToDos2.Controllers
{
    [Route("")]
    [Route("/todo")]
    public class ToDoController : Controller
    {
        public ToDoService toDoService;
        public UserService userService;

        public ToDoController(ToDoService toDoService, UserService userService)
        {
            this.toDoService = toDoService;
            this.userService = userService;
        }

        [Route("")]
        [HttpGet("/todo/list")]
        public IActionResult List()
        {
            return View(toDoService.ListOfToDos());
        }

        [HttpPost("/todo/add")]
        public IActionResult Add(string title, string username, string assigneename)
        {
            toDoService.toDoRepository.AddNewTodo(toDoService.
                CreateNewToDo(title, userService.GetTheUser(username), 
                userService.GetTheUser(assigneename)));
            return RedirectToAction("list");
        }

        [HttpGet("/todo/add")]
        public IActionResult Add()
        {
            return View(userService.ListOfToUsers());
        }
    }
}
