using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FilmSelector.Models
{
    public class UserFilm
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public Film Film { get; set; }
    }
}
