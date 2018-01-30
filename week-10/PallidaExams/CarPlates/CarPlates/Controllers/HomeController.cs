using CarPlates.Models;
using CarPlates.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace CarPlates.Controllers
{
    [Route("")]
    public class HomeController : Controller
    {
        private PlateService plateService;

        public HomeController(PlateService plateService)
        {
            this.plateService = plateService;
        }

        [HttpGet("search")]
        public IActionResult Search([FromQuery]SearchItem search)
        {
            return View(plateService.SearchedCar(search));
        }

        [HttpGet("search/{brand}")]
        public IActionResult BrandSearch([FromRoute]string brand)
        {
            return View("Search", plateService.SearchBrand(brand));
        }

        [HttpGet("api/search/{brand}")]
        public IActionResult ApiSearch(string brand)
        {
            return Json(new { result = "ok", data = plateService.SearchBrand(brand) });
        }
    }
}
