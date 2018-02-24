using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FilmSelector.Models
{
    public class Film
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string About { get; set; }
        public string Link { get; set; }
        public IList<UserFilm> Users { get; set; }
        public DateTime Date { get; set; }
        public bool Seen { get; set; } = false;
        public int Year { get; set; }
    }
}
