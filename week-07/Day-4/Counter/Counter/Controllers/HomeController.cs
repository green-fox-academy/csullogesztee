using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Counter.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Counter.Controllers
{
    [Route("")]
    public class HomeController : Controller
    {
        private CounterModel counter;

        public HomeController(CounterModel counter)
        {
            this.counter = counter;
        }

        [HttpGet("")]
        public IActionResult Index()
        {
            return View(counter);
        }

        [HttpPost("")]
        public IActionResult IndexPost()
        {
            counter.AddTen();
            return RedirectToAction("Index");
        }
    }
}
