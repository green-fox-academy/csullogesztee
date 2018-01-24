using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace IAmGroot.Controllers
{
    [Route("")]
    public class GuardianController : Controller
    {

        [HttpGet("groot")]
        public IActionResult Groot(string message)
        {
            if (message == null)
            {
                return Json(new { error = "I am Groot!" });
            }
            return Json(new { received = message, translated = "I am Groot!" });
        }
    }
}
