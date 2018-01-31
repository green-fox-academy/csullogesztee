using FilmSelector.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FilmSelector.Services
{
    public class FilmService
    {
        private FilmRepository filmRepository;

        public FilmService(FilmRepository filmRepository)
        {
            this.filmRepository = filmRepository;
        }
    }
}
