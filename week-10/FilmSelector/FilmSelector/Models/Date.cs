using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FilmSelector.Models
{
    public class Date
    {
        [Key]
        public DateTime When { get; set; }
        public Film DailyFilm { get; set; }
        public Series DailySeries { get; set; }
    }
}
