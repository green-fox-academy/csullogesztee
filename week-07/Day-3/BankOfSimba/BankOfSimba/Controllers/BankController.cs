using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BankOfSimba.Models;
using BankOfSimba.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace BankOfSimba.Controllers
{
    [Route("")]
    public class BankController : Controller
    {
        static AccountsViewModel accounts = new AccountsViewModel();

        [Route("")]
        public IActionResult Index()
        {
            return View();
        }

        [Route ("Simba")]
        public IActionResult Simba()
        {
            BankAccount account = new BankAccount("Simba", 2000, "Lion", "good", "king");
            return View(account);
        }


        [HttpGet("AllAccount")]
        public IActionResult AllAccount()
        {
            return View(accounts);
        }

        [HttpGet("add")]
        public IActionResult ShowForm()
        {
            return View("Add");
        }

        [HttpPost("add")]
        public IActionResult AddCharacter(BankAccount bankAccount)
        {
            accounts.AccountList.Add(bankAccount);
            return RedirectToAction("AllAccount");
        }


    }
}
