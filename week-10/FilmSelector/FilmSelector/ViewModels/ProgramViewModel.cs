using FilmSelector.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FilmSelector.ViewModels
{
    public class ProgramViewModel
    {
        public int UserId { get; set; }
        public List<Film> ListOfFilms { get; set; }
        public List<Series> ListOfSeries { get; set; }
    }
}
