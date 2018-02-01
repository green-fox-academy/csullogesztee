using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FilmSelector.Models;
using FilmSelector.Services;
using Microsoft.AspNetCore.Mvc;

namespace FilmSelector.Controllers
{
    [Route("user")]
    public class UserController : Controller
    {
        private UserService userService;

        public UserController(UserService userService)
        {
            this.userService = userService;
        }

        [HttpGet("add")]
        public IActionResult AddUser()
        {
            return View();
        }

        [HttpPost("add")]
        public IActionResult AddUser(string name)
        {
            userService.AddUser(name);
            return RedirectToAction("Login", "Login", userService.ListOfUsers());
        }

        [HttpGet("{id}/mylist")]
        public IActionResult MyList(int id)
        {
            User user = userService.GetUserWithId(id);
            return View(user);
        }
    }
}

