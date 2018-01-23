using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ListingToDos2.Services;
using Microsoft.AspNetCore.Mvc;

namespace ListingToDos2.Controllers
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
            var id = loginService.userService.GetTheUserWithName(name).UserId;
            return loginService.CheckUser(name) ? Redirect($"/user/{id}") : Redirect("/");
        }
    }
}
