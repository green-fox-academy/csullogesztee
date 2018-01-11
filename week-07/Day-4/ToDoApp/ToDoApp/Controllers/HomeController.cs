using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ToDoApp.Models;

namespace ToDoApp.Controllers
{
    [Route("")]
    public class HomeController : Controller
    {
        public ToDoList toDoList { get; set; }

        public HomeController(ToDoList toDoList)
        {
            this.toDoList = toDoList;
        }

        [HttpGet("")]
        public IActionResult Index()
        {
            return View(toDoList);
        }

        [Route("Rest")]
        public IActionResult Rest()
        {
            return View();
        }

        [HttpPost("Add")]
        public IActionResult AddList(string exercise, string urgent)
        {
            toDoList.AddTodo(new Todo(exercise, urgent));
            return RedirectToAction("Index");
        }

        [HttpPost("Complete")]
        public IActionResult Complete(int index)
        {
            toDoList.Ready(index);
            return RedirectToAction("Index");
        }

        [HttpPost("Delete")]
        public IActionResult Delete(int index)
        {
            toDoList.Delete(index);
            return toDoList.ListOfToDos.Count != 0 ? RedirectToAction("Index") : RedirectToAction("Rest");
        }
    }
}
