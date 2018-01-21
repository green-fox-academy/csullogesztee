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
        private ToDoService toDoService;
        private UserService userService;

        public ToDoController(ToDoService toDoService, UserService userService)
        {
            this.toDoService = toDoService;
            this.userService = userService;
            toDoService.toDoUserViewModel.ToDoList = toDoService.ListOfToDos();
            toDoService.toDoUserViewModel.UserList = userService.ListOfToUsers();
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
            var currentCreator = userService.GetTheUserWithName(username);
            var currentAssignee = userService.GetTheUserWithName(assigneename);
            toDoService.toDoRepository.AddNewTodo(toDoService.
                CreateNewToDo(title, currentCreator, currentAssignee));
            return RedirectToAction("list");
        }

        [HttpGet("/todo/add")]
        public IActionResult Add()
        {
            return View(userService.ListOfToUsers());
        }

        [HttpGet("/todo/delete/{id}")]
        public IActionResult Delete(long id)
        {
            toDoService.toDoRepository.DeleteToDo(id);
            return RedirectToAction("list");
        }

        [HttpPost("/todo/edit/{id}")]
        public IActionResult Edit(ToDo toDo, long id, long assigneeid)
        {
            var currentAssignee = userService.GetTheUserWithId(assigneeid);
            toDo.Assignee = currentAssignee;
            toDoService.toDoRepository.EditToDo(toDo, id);
            return RedirectToAction("list");
        }

        [HttpGet("/todo/edit/{id}")]
        public IActionResult Edit(long id)
        {
            toDoService.toDoUserViewModel.ToDoId = id;
            return View(toDoService.toDoUserViewModel);
        }
    }
}
