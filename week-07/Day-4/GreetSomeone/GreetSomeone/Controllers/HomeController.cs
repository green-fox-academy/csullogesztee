using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GreetSomeone.Models;
using Microsoft.AspNetCore.Mvc;

namespace GreetSomeone.Controllers
{
    [Route("")]
    public class HomeController : Controller
    {
        Greeting Greeting;

        public HomeController(Greeting greeting)
        {
            Greeting = greeting;
        }

        [HttpGet("")]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost("")]
        public IActionResult AddName(Greeting greeting)
        {
            Greeting.Name = greeting.Name;
            return RedirectToAction("Hello");
        }

        [HttpGet("Hello")]
        public IActionResult Hello()
        {
            return View(Greeting);
        }
    }
}
