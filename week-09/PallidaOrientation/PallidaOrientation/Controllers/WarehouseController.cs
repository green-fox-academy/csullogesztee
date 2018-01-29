using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PallidaOrientation.Models;
using PallidaOrientation.Services;

namespace PallidaOrientation.Controllers
{
    [Route("Warehouse")]
    public class WarehouseController : Controller
    {
    private ClothesService clothesService;

    public WarehouseController(ClothesService clothesService)
    {
            this.clothesService = clothesService;
    }

        [Route("query")]
        [HttpGet]
        public IActionResult ListClothes(int price, PriceType type)
        {
            return Json(clothesService.SortClothes(price, type));
        }
    }
}
