using FilmSelector.Models;
using FilmSelector.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FilmSelector.Services
{
    public class ProgramService
    {
        private FilmRepository filmRepository;
        private SeriesRepository seriesRepository;

        public ProgramService(FilmRepository filmRepository, SeriesRepository seriesRepository)
        {
            this.filmRepository = filmRepository;
            this.seriesRepository = seriesRepository;
        }

        public List<Film> AllFilm()
        {
            return filmRepository.AllFilm();
        }

        public List<Series> AllSeries()
        {
            return seriesRepository.AllSeries();
        }
    }
}
