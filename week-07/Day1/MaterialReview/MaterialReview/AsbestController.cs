using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MaterialReview
{
    [Route("duck")]
    public class AsbestController : Controller
    {
        [Route("")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
