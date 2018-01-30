using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Quiz.Models;
using Quiz.Services;

namespace Quiz.Controllers
{
    [Route("")]
    public class HomeController : Controller
    {
        private QuizService quizService;

        public HomeController(QuizService quizService)
        {
            this.quizService = quizService;
        }

        [Route("")]
        [HttpGet("home")]
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet("home/{score}")]
        public IActionResult Score()
        {
            return Ok();
        }

        [HttpGet("home/question")]
        public IActionResult AddQuestion()
        {
            return View();
        }

        [HttpPost("home/question")]
        public IActionResult AddQuestion(Exercise exercise)
        {
            quizService.AddNewExercise(exercise);
            return RedirectToAction("Index");
        }

        [HttpGet("home/quiz")]
        public IActionResult Quiz()
        {
            return View(quizService.GetQuestion());
        }
    }
}
