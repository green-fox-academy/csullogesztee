using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExerciseMonday.Models
{
    public class Greeting
    {
        public long Id { get; set; }
        public string Content { get; set; }

        public Greeting()
        {
            Id = 1;
            Content = "Hello";
        }
    }
}
