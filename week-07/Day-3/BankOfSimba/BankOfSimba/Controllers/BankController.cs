using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BankOfSimba.Models;
using BankOfSimba.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace BankOfSimba.Controllers
{
    [Route ("")]
    public class BankController : Controller
    {
        [Route ("Simba")]
        public IActionResult Simba()
        {
            BankAccount account = new BankAccount("Simba", 2000, "Lion");
            return View(account);
        }

        [Route("AllAccount")]
        public IActionResult AllAccount()
        {
            AccountsViewModel accounts = new AccountsViewModel();
            return View(accounts);
        }
    }
}
