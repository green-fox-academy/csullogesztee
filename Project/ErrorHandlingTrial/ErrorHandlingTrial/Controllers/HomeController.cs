using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ErrorHandlingTrial.Models;
using ErrorHandlingTrial.Services;
using Microsoft.AspNetCore.Mvc;


namespace ErrorHandlingTrial.Controllers
{
    public class HomeController : Controller
    {
        private StudentService studentService;

        public HomeController(StudentService studentService)
        {
            this.studentService = studentService;
        }

        [Route("")]
        [HttpGet("list")]
        public IActionResult Index()
        {
            return Json(studentService.StudentList);
        }

        [HttpGet("id")]
        public IActionResult SearchById(int id)
        {
            return Json(studentService.SearchById(id));
        }

        [HttpGet("name")]
        public IActionResult SearchByName(string name)
        {
            return Json(studentService.SearchByName(name));
        }
    }
}
