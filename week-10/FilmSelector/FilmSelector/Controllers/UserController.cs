using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FilmSelector.Models;
using FilmSelector.Services;
using Microsoft.AspNetCore.Mvc;

namespace FilmSelector.Controllers
{
    [Route("user")]
    public class UserController : Controller
    {
        private UserService userService;
        private ProgramService programService;

        public UserController(UserService userService, ProgramService programService)
        {
            this.userService = userService;
            this.programService = programService;
        }

        [HttpGet("add")]
        public IActionResult AddUser()
        {
            return View();
        }

        [HttpPost("add")]
        public IActionResult AddUser(string name)
        {
            userService.AddUser(name);
            return RedirectToAction("Login", "Login", userService.ListOfUsers());
        }

        [HttpGet("{id}/mylist")]
        public IActionResult MyList(int id)
        {
            User user = userService.GetUserWithId(id);
            return View(user);
        }

        [HttpPost("{id}/watched/{programId}")]
        public IActionResult Watched([FromQuery]string type, [FromRoute]int id, [FromRoute]int programId)
        {
            programService.UpdateProgram(type, programId);
            return RedirectToAction("mylist", id);
        }

        [HttpGet("{id}/otheruserlist/{otheruserid}")]
        public IActionResult OtherUserList(int id, int otherUserId)
        {
            var myView = programService.GenerateOtherView();
            myView.MyId = id;
            myView.OtherUser = userService.GetUserWithId(otherUserId);
            return View(myView);
        }
    }
}

