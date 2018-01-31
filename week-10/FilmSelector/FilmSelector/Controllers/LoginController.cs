using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FilmSelector.Services;
using Microsoft.AspNetCore.Mvc;

namespace FilmSelector.Controllers
{
    [Route("")]
    public class LoginController : Controller
    {
        private LoginService loginService;

        public LoginController(LoginService loginService)
        {
            this.loginService = loginService;
        }

        [HttpGet("")]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost("")]
        public IActionResult Login(string name)
        {
            var id = loginService.userService.GetUserWithName(name).UserId;
            return loginService.CheckUser(name) ? Redirect($"/user/{id}") : Redirect("/");
        }
    }
}
