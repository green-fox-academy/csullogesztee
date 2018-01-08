using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ExerciseMonday.Models;
using Microsoft.AspNetCore.Mvc;

namespace ExerciseMonday.Controllers
{
    [Route("api")]
    public class RESTController : Controller
    {
        public static int counter { get; set; } = 0;

        public IActionResult Index()
        {
            return View();
        }

        [Route("greeting/{name}")]
        public IActionResult Greeting([FromRoute] string name)
        {
            counter++;
            var hello = new Greeting(name, counter);
            return new JsonResult(hello);
        }
    }
}
