using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FilmSelector.Models
{
    public abstract class Program
    {
        public long? Id { get; set; }
        public User Creator { get; set; }
        public string Type { get; set; }
        public string Title { get; set; }
        public string Style { get; set; }
        public string IMDBLink { get; set; }
        public double IMBBScore { get; set; }
        public string About { get; set; }
        public bool Watched { get; set; } = false;
        public DateTime Date { get; set; }
    }
}
