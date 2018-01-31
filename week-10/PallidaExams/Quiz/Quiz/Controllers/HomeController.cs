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
        public IActionResult Score(int score)
        {
            return Json(score);
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
            return quizService.IsThereAnyQuestion() ? View(quizService.GenerateView()) : View("Index");
        }

        [HttpGet("home/quiz/{id}/{selected}/{score}")]
        public IActionResult QuizWithParameters(int id, int selected, int score)
        {
            return quizService.CorrectAnswer(id, selected) ?
                (ActionResult)View("Quiz", quizService.GenerateView(++score)) :
                RedirectToAction("Score", score);
        }
    }
}
