using BankOfSimba.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankOfSimba.ViewModels
{
    public class AccountsViewModel
    {
        public List<BankAccount> AccountList { get; set; } = new List<BankAccount>();

        public AccountsViewModel()
        {
            AddCharacters();
        }

        private void AddCharacters()
        {
            AccountList.Add(new BankAccount("Simba", 2000, "Lion", "good", "king"));
            AccountList.Add(new BankAccount("Nala", 50, "Lion", "good"));
            AccountList.Add(new BankAccount("Zazu", 100, "Kakadu", "good"));
            AccountList.Add(new BankAccount("Rafiki", 500, "Monkey", "good"));
            AccountList.Add(new BankAccount("Zordon", 1500, "Lion", "bad"));
        }
    }
}
