using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ClothesMarket.Services;
using Microsoft.AspNetCore.Mvc;

namespace ClothesMarket.Controllers
{
    [Route("")]
    public class HomeController : Controller
    {
        private ClothesService clothesService;

        public HomeController(ClothesService clothesService)
        {
            this.clothesService = clothesService;
        }

        [Route("")]
        [HttpGet("warehouse")]
        public IActionResult Index()
        {
            return View(clothesService.GenerateViewModel());
        }

        [HttpPost("warehouse/summary")]
        public IActionResult Summary(string name, string size, int quantity)
        {
            return View(clothesService.GetSummary(name, size, quantity));
        }

        [HttpGet("warehouse/query")]
        public IActionResult Query(double price, string type)
        {
            return Json(clothesService.SearchWithSize(price, type));
        }

        [HttpGet("warehouse/test")]
        public IActionResult Like(string like)
        {

        }
    }
}
