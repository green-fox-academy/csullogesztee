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

        [Route("greeting/{name}")]
        public IActionResult Greeting([FromRoute] string name)
        {
            var hello = new Greeting(name);
            return new JsonResult(hello);
        }
    }
}
