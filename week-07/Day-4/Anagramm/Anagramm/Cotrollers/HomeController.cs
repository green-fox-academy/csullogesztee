using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Anagramm.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Anagramm.Cotrollers
{
    [Route("")]
    public class HomeController : Controller
    {
        Anagrammas anagramms;

        public HomeController(Anagrammas anagramms)
        {
            this.anagramms = anagramms;
        }

        [HttpGet("")]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost("")]
        public IActionResult Checker(Anagrammas anagrammas)
        {
            anagramms.Word1 = anagrammas.Word1;
            anagramms.Word2 = anagrammas.Word2;

            return RedirectToAction("Result");
        }

        [HttpGet("Result")]
        public IActionResult Result()
        {
            return View(anagramms);
        }
    }
}
