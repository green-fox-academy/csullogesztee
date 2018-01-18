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
        public UserService userService;

        public UserController(UserService userService)
        {
            this.userService = userService;
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
    }
}
