using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankOfSimba.Models
{
    public class BankAccount
    {
        public string Name { get; set; }
        public string Balance { get; set; }
        public string AnimalType { get; set; }
        public string Title { get; set; }
        public string Side { get; set; }

        public BankAccount(string name, double balance, string type, string side)
        {
            Name = name;
            Balance = balance.ToString(".00") + " Zebra";
            AnimalType = type;
            if (side == "good")
            {
                Side = "Good One";
            }
            else
            {
                Side = "Bad Guy";
            }
            Title = "servant";
        }
        public BankAccount(string name, double balance, string type, string side, string king)
        {
            Name = name;
            Balance = balance.ToString(".00") + " Zebra";
            AnimalType = type;
            if (side == "good")
            {
                Side = "Good One";
            }
            else
            {
                Side = "Bad Guy";
            }
            if (king == "king")
            {
                Title = "THE KING";
            }
        }
    }
}
