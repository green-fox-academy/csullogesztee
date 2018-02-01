using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FilmSelector.Models;
using FilmSelector.Services;
using Microsoft.AspNetCore.Mvc;

namespace FilmSelector.Controllers
{
    [Route("{id}/program")]
    public class ProgramController : Controller
    {
        private ProgramService programService;

        public ProgramController(ProgramService programService)
        {
            this.programService = programService;
        }

        [HttpGet("")]
        public IActionResult Index()
        {
            return View(programService.GenerateView());
        }

        [HttpGet("add")]
        public IActionResult AddProgram(int id)
        {
            return View(id);
        }

        [HttpPost("add")]
        public IActionResult AddProgram(Creator creator, string type, int id)
        {
            programService.AddProgram(type, creator, id);
            return RedirectToAction("Index");
        }

        [HttpGet("onefilm")]
        public IActionResult OneFilm(int filmid)
        {
            var film = programService.GetOneFilm(1);
            return View(film);
        }

        [HttpGet("oneseries")]
        public IActionResult OneSeries(int seriesid)
        {
            var series = programService.GetOneSeries(seriesid);
            return View(series);
        }
    }
}
