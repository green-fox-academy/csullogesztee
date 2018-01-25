using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Reddit.Models;
using Reddit.Services;

namespace Reddit.Controllers
{
    [Route("")]
    public class RedditController : Controller
    {
        public RedditService redditService;

        public RedditController(RedditService redditService)
        {
            this.redditService = redditService;
        }

        [HttpGet("posts")]
        public IActionResult Posts()
        {
            return Json(new { posts = redditService.redditRepository.GetPosts() });
        }

        [HttpPost("posts")]
        public IActionResult AddPost(PostCreator postCreator)
        {
            Post newPost = redditService.redditRepository.AddPost(postCreator);
            return Json(newPost);
        }
    }
}
