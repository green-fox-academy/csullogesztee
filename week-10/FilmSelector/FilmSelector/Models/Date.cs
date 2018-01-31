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
        public DateTime Date { get; set; }
        public Program DailyProgram { get; set; }
    }
}
