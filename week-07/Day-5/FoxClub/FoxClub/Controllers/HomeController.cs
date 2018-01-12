using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FoxClub.Models;
using Microsoft.AspNetCore.Mvc;

namespace FoxClub.Controllers
{
    [Route("")]
    public class HomeController : Controller
    {

        [Route("Index")]
        public IActionResult Index()
        {
            return View();
        }

        private User user;

        public HomeController(User user)
        {
            this.user = user;
        }

        [HttpGet("")]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost("")]
        public IActionResult Login(string name)
        {
            user.Name = name;
            return name.Equals("Esztee") ? Redirect("Index") : Redirect("/");
        }
    }
}
