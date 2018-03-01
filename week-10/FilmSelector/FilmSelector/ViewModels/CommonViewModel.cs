using FilmSelector.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FilmSelector.ViewModels
{
    public class CommonViewModel
    {
        public User Me { get; set; }
        public User OtherUser { get; set; }
        public List<Film> CommonFilms { get; set; }
        public List<Series> CommonSeries { get; set; }
    }
}
