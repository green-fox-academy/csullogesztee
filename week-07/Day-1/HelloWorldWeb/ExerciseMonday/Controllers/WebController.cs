using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ExerciseMonday.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ExerciseMonday.Controllers
{
    [Route("web")]
    public class WebController : Controller
    {
        [Route("greeting")]
        public IActionResult Greeting()
        {
            var greeting = new Greeting()
            {
                Id = 1,
                Content = "World"
            };

            return View(greeting);
        }
    }
}
