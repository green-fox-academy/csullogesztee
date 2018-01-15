using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EFCoreIntro.Entities;
using EFCoreIntro.Models;
using Microsoft.AspNetCore.Mvc;

namespace EFCoreIntro.Controllers
{
    [Route("")]
    public class HomeController : Controller
    {

        private PersonContext personContext;

        public HomeController(PersonContext personContext)
        {
            this.personContext = personContext;
        }

        [HttpGet("")]
        public IActionResult Index()
        {
            var newPerson = new Person()
            {
                Name = "Aristid"
            };

            personContext.Persons.Add(newPerson);
            personContext.SaveChanges();
            var lastPerson = personContext.Persons.LastOrDefault();

            return Json(lastPerson);
        }
    }
}
