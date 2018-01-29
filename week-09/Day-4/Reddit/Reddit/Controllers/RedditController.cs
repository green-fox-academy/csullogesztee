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
            return Json(new { posts = redditService.ListOfPosts() });
        }

        [HttpPost("posts")]
        public IActionResult AddPost(PostCreator postCreator)
        {
            postCreator.Owner = Request.Headers["Owner"].FirstOrDefault();

            if(string.IsNullOrEmpty(postCreator.Owner))
            {
                postCreator.Owner = "Anyád";
               // postCreator.Owner = Request.Body["Owner"].FirstOrDefault();
            }

            Post newPost = redditService.CreatePost(postCreator);
            return Json(newPost);
        }

        [HttpPut("/posts/{id}/upvote")]
        public IActionResult UpVote(long id)
        {
            if (!redditService.IdValidation(id))
            {
                return BadRequest();
            }
            else
            {
                redditService.VoteUp(id, Request.Headers["Owner"].FirstOrDefault());
                return Ok();
            }
        }

        [HttpPut("/posts/{id}/downvote")]
        public IActionResult DownVote(long id)
        {
            if (!redditService.IdValidation(id))
            {
                return BadRequest();
            }
            else
            {
                redditService.VoteDown(id, Request.Headers["Owner"].FirstOrDefault());
                return Ok();
            }
        }
    }
}
