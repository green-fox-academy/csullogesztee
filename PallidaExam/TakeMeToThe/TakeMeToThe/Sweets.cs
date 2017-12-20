using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TakeMeToThe
{
    public class Sweets
    {
        public double Price { get; set; }
        public double NeedSugar { get; set; }
        public string Type { get; set; }

        public Sweets(double price, double needSugar, string type)
        {
            Price = price;
            NeedSugar = needSugar;
            Type = type;
        }
    }
}
