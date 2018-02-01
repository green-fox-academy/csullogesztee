using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FilmSelector.Services;
using Microsoft.AspNetCore.Mvc;

namespace FilmSelector.Controllers
{
    [Route("")]
    [Route("login")]
    public class LoginController : Controller
    {
        private LoginService loginService;
        private UserService userService;

        public LoginController(LoginService loginService, UserService userService)
        {
            this.loginService = loginService;
            this.userService = userService;
        }

        [HttpGet("")]
        public IActionResult Login()
        {
            return View(userService.ListOfUsers());
        }

        [HttpPost("")]
        public IActionResult Login(string name)
        {
            var id = loginService.userService.GetUserWithName(name).UserId;
            return loginService.CheckUser(name) ? Redirect($"/{id}/program") : Redirect("/");
        }
    }
}
