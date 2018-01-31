using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FilmSelector.Models
{
    public class User
    {
        public int UserId { get; set; }
        public string Name { get; set; }
        public IList<Film> Films { get; set; } = new List<Film>();
        public IList<Series> Series { get; set; } = new List<Series>();
    }
}
