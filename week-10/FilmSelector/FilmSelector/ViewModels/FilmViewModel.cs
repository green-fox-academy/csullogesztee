using FilmSelector.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FilmSelector.ViewModels
{
    public class FilmViewModel
    {
        public int MyId { get; set; }
        public Film Film { get; set; }
    }
}
