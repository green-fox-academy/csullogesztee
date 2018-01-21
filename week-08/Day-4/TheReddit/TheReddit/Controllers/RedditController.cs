using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TheReddit.Services;

namespace TheReddit.Controllers
{
    [Route("")]
    public class RedditController : Controller
    {
        private RedditService redditService;

        public RedditController(RedditService redditService)
        {
            this.redditService = redditService;
        }

        [Route("")]
        [HttpGet("/posts")]
        public IActionResult Index()
        {
            redditService.redditViewModel.allPost = redditService.AllPost();
            return View(redditService.redditViewModel);
        }

        [HttpPost("/posts/add")]
        public IActionResult Add(string content)
        {
            redditService.redditRepository.AddNewPost(redditService.CreatePost(content));
            return RedirectToAction("index");
        }

        [HttpGet("/posts/add")]
        public IActionResult Add()
        {
            return View();
        }

        [HttpGet("posts/increase/{id}")]
        public IActionResult Increase(long id)
        {
            redditService.redditRepository.IncreaseScore(id);
            return RedirectToAction("index");
        }

        [HttpGet("posts/decrease/{id}")]
        public IActionResult Decrease(long id)
        {
            redditService.redditRepository.DecreaseScore(id);
            return RedirectToAction("index");
        }
    }
}
