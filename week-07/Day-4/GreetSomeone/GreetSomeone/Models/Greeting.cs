using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GreetSomeone.Models
{
    public class Greeting
    {
        public string Name { get; set; }

        public Greeting(string name)
        {
            Name = name;
        }

        public Greeting()
        {
        }

        public string SayHello()
        {
            return "Hello, " + Name;
        }

    }
}
