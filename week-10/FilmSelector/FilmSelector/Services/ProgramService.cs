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

        public void UpdateProgram(string type, int programId)
        {
            if (type.Equals("film"))
            {
                filmRepository.UpdateFilm(programId);
            }
            if (type.Equals("series"))
            {
                seriesRepository.UpdateSeries(programId);
            }
        }

        public void AddOtherUser(string type, int programId, int userID)
        {
            if (type.Equals("film"))
            {
                filmRepository.AddOtherUser(programId, userID);
            }
            if (type.Equals("series"))
            {
                seriesRepository.AddOtherUser(programId, userID);
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

        public OthersClassViewModel GenerateOtherView()
        {
            return new OthersClassViewModel();
        }

        public FilmViewModel GenerateFilm()
        {
            return new FilmViewModel();
        }

        public SeriesViewModel GenerateSeries()
        {
            return new SeriesViewModel();
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
