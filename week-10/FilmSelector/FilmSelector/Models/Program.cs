using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FilmSelector.Models
{
    public abstract class Program
    {
        public int Id { get; set; }
        public double IMdB { get; set; }
        public string About { get; set; }
        public string Link { get; set; }
        public User User { get; set; }
        public DateTime Date { get; set; }
        public bool Seen { get; set; } = false;
    }
}
