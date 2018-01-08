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

        public IActionResult Index()
        {
            return View();
        }

        [Route("greeting")]
        public IActionResult Greeting()
        {
            var hello = new Greeting();
            return new JsonResult(hello);
        }
    }
}
