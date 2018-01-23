using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ListingTodos2.Models;
using ListingToDos2.Services;
using Microsoft.AspNetCore.Mvc;

namespace ListingToDos2.Controllers
{
    [Route("/user")]
    public class UserController : Controller
    {
        private UserService userService;
        private ToDoService toDoService;

        public UserController(UserService userService, ToDoService toDoService)
        {
            this.userService = userService;
            this.toDoService = toDoService;
            userService.toDoUserViewModel.ToDoList = toDoService.ListOfToDos();
            userService.toDoUserViewModel.UserList = userService.ListOfToUsers();
        }

        [HttpGet("/user/list")]
        public IActionResult List()
        {
            return View(userService.ListOfToUsers());
        }

        [HttpPost("/user/add")]
        public IActionResult Add(string name, string email, int phoneNumber)
        {
            userService.userRepository.
                AddNewUser(userService.CreateNewUser(name, email, phoneNumber));
            return RedirectToAction("list");
        }

        [HttpGet("/user/add")]
        public IActionResult Add()
        {
            return View();
        }

        [HttpGet("/user/delete/{id}")]
        public IActionResult Delete(long id)
        {
            userService.userRepository.DeleteUser(id);
            return RedirectToAction("list");
        }

        [HttpPost("/user/edit/{id}")]
        public IActionResult Edit(User user, long id)
        {
            userService.userRepository.EditUser(user, id);
            return RedirectToAction("list");
        }

        [HttpGet("/user/edit/{id}")]
        public IActionResult Edit(long id)
        {
            toDoService.toDoUserViewModel.UserId = id;
            return View(toDoService.toDoUserViewModel);
        }

        [HttpGet("/user/{id}")]
        public IActionResult User(long id)
        {
            toDoService.toDoUserViewModel.UserId = id;
            return View(toDoService.toDoUserViewModel);
        }
    }
}
