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
        public IList<UserFilm> Films { get; set; }
        public IList<UserSeries> Series { get; set; }
    }
}
