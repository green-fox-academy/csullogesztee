using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FilmSelector.Models
{
    public class Calendar
    {
        [Key]
        public DateTime Date { get; set; }
        public List<Program> Programs { get; set; } = new List<Program>();
    }
}
