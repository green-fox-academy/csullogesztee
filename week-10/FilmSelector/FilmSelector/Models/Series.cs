using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FilmSelector.Models
{
    public class Series
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public double IMdB { get; set; }
        public string About { get; set; }
        public string Link { get; set; }
        public User User { get; set; }
        public DateTime Date { get; set; }
        public bool Seen { get; set; } = false;
        public int Season { get; set; }
        public int StartYear { get; set; }
        public int EndYear { get; set; }
    }
}
