using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ListingTodos2.Models;
using ListingToDos2.Services;
using Microsoft.AspNetCore.Mvc;

namespace ListingToDos2.Controllers
{
    [Route("/todo")]
    public class ToDoController : Controller
    {
        private ToDoService toDoService;
        private UserService userService;

        public ToDoController(ToDoService toDoService, UserService userService)
        {
            this.toDoService = toDoService;
            this.userService = userService;
        }

        [HttpGet("/todo/list")]
        public IActionResult List(string type, string text)
        {
            //toDoService.toDoUserViewModel.ToDoList = toDoService.FilteredToDos(type, text);
            return View(toDoService.toDoUserViewModel);
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
            toDoService.toDoUserViewModel.OneToDo = toDoService.GetOneTodo(id);
            return View(toDoService.toDoUserViewModel);
        }

        [HttpGet("/todo/{id}")]
        public IActionResult Todo(long id)
        {
            toDoService.toDoUserViewModel.OneToDo = toDoService.GetOneTodo(id);
            return View(toDoService.toDoUserViewModel);
        }

        [HttpPost("/todo/search")]
        public IActionResult Search(string type, string text)
        {
            toDoService.toDoUserViewModel.ToDoList = toDoService.FilteredToDos(type, text);
            return text == null ? RedirectToAction("list") : (IActionResult)View("List", toDoService.toDoUserViewModel);
            //return RedirectToAction("list", new { type = type, text = text });
            //return View(toDoService.toDoUserViewModel);
        }
    }
}
