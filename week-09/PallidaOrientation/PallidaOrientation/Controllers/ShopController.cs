using Microsoft.AspNetCore.Mvc;
using PallidaOrientation.Services;

namespace PallidaOrientation.Controllers
{
    [Route("shoppingplanner")]
    public class ShopController : Controller
    {

        private ClothesService clothesService;

        public ShopController(ClothesService clothesService)
        {
            this.clothesService = clothesService;
        }

        [HttpGet("")]
        public IActionResult Index()
        {
            return View(clothesService.GetTheList());
        }

        [HttpPost("summary")]
        public IActionResult Summary(string name, string size, int amount)
        {
            return View(clothesService.CreateSummary(name, size, amount));
        }
    }
}
