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
        public IActionResult Index(int id)
        {
            var myView = programService.GenerateView();
            myView.UserId = id;
            return View(myView);
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

        [HttpGet("onefilm/{filmid}")]
        public IActionResult OneFilm(int id, int filmid)
        {
            var film = programService.GenerateFilm();
            film.Film = programService.GetOneFilm(filmid);
            film.MyId = id;
            return View(film);
        }

        [HttpGet("oneseries/{seriesid}")]
        public IActionResult OneSeries(int id, int seriesid)
        {
            var series = programService.GenerateSeries();
            series.Series = programService.GetOneSeries(seriesid);
            series.MyId = id;
            return View(series);
        }
    }
}
