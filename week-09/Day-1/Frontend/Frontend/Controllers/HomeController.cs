using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Frontend.Entities;
using Frontend.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Frontend.Controllers
{
    [Route("api")]
    public class HomeController : Controller
    {
        public LogContext logContext;

        public HomeController(LogContext logContext)
        {
            this.logContext = logContext;
        }

        [Route("")]
        public IActionResult Index()
        {
            logContext.Logs.Add(new Log() { EndPoint = "", Data = ""});
            logContext.SaveChanges();

            return File("index.html", "text/html");
        }


        [HttpGet("doubling")]
        public IActionResult Doubling(int? input)
        {

            logContext.Logs.Add(new Log() { EndPoint = "doubling", Data = $"{input}" });
            logContext.SaveChanges();

            if (input == null)
            {
                return Json(new { error = "Please provide an input!" });
            }
            return Json(new { received = input, result = input * 2 });
        }

        [HttpGet("greeter")]
        public IActionResult Greeter(string name, string title)
        {

            logContext.Logs.Add(new Log() { EndPoint = "greeter", Data = $"{name}, {title}" } );
            logContext.SaveChanges();

            if (name == null)
            {
                return Json(new { error = "Please provide a name!" });
            }
            if (title == null)
            {
                return Json(new { error = "Please provide a title!" });
            }
            return Json(new { welcome_message = string.Format("Oh, hi there {0}, my dear {1}!", name, title) });
        }

        [HttpGet("appenda/{appendable}")]
        public IActionResult Greeter(string appendable)
        {
            logContext.Logs.Add(new Log() { EndPoint = "appenda", Data = $"{appendable}" });
            logContext.SaveChanges();

            return Json(new { appended = appendable + "a" });
        }

        [HttpGet("appenda")]
        public IActionResult Greeter()
        {
            return NotFound();
        }

        [HttpPost("dountil/{what}")]
        public IActionResult DoUntil([FromBody] Until item, [FromRoute]string what)
        {

            logContext.Logs.Add(new Log() { EndPoint = "dountil", Data = $"{item.ToString()}, {what}" });
            logContext.SaveChanges();

            if (item.until == null)
            {
                return Json(new { error = "Please provide a number!" });
            }
            if (what.Equals("sum"))
            {
                int result = 0;
                for (int i = 0; i < item.until + 1; i++)
                {
                    result += i;
                }
                return Json(new { result = result });
            }
            if (what.Equals("factor"))
            {
                int result = 1;
                for (int i = 1; i < item.until + 1; i++)
                {
                    result *= i;
                }
                return Json(new { result = result });
            }
            return NotFound();
        }

        [HttpPost("arrays")]
        public IActionResult Arrays([FromBody] NumbersArray numbers)
        {

            logContext.Logs.Add(new Log() { EndPoint = "arrays", Data = $"{numbers.ToString()}" });
            logContext.SaveChanges();

            if (numbers.What.Equals("sum"))
            {
                int result = 0;
                foreach (var number in numbers.Numbers)
                {
                    result += number;
                }
                return Json(new { result = result });
            }
            if (numbers.What.Equals("multiply"))
            {
                int result = 1;
                foreach (var number in numbers.Numbers)
                {
                    result *= number;
                }
                return Json(new { result = result });
            }
            if (numbers.What.Equals("double"))
            {
                int[] result = new int[4];
                for (int i = 0; i < result.Length; i++)
                {
                    result[i] = numbers.Numbers[i] * 2;
                }
                return Json(new { result = result });
            }
            return Json(new { error = "Please provide what to do with the numbers!" });
        }

        [HttpGet("log")]
        public IActionResult Log()
        {
            logContext.Logs.Add(new Log() { EndPoint = "log", Data = "" });
            logContext.SaveChanges();

            return Json(new { entries = logContext.Logs, entry_count = logContext.Logs.ToList().Count });
        }
    }
}
