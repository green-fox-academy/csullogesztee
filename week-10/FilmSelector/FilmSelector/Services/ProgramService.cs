using FilmSelector.Models;
using FilmSelector.Repositories;
using FilmSelector.ViewModels;
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
        private UserRepository userRepository;

        public ProgramService(FilmRepository filmRepository, SeriesRepository seriesRepository, UserRepository userRepository)
        {
            this.filmRepository = filmRepository;
            this.seriesRepository = seriesRepository;
            this.userRepository = userRepository;
        }

        public List<Film> AllFilm()
        {
            return filmRepository.AllFilm();
        }

        public List<Series> AllSeries()
        {
            return seriesRepository.AllSeries();
        }

        public void AddProgram(string type, Creator creator, int id)
        {
            var currentUser = userRepository.GetUserWithId(id);
            if(type.Equals("film"))
            {
               filmRepository.AddFilm(creator, currentUser);
            }
            if(type.Equals("series"))
            {
                seriesRepository.AddSeries(creator, currentUser);
            }
        }

        public ProgramViewModel GenerateView()
        {
            ProgramViewModel view = new ProgramViewModel()
            {
                ListOfFilms = AllFilm(),
                ListOfSeries = AllSeries()
            };
            return view;
        }

        public Film GetOneFilm(int id)
        {
            return filmRepository.GetFilmWithId(id);
        }

        public Series GetOneSeries(int id)
        {
            return seriesRepository.GetSeriesWithId(id);
        }
    }
}
