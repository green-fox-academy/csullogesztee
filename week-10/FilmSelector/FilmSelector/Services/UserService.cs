using FilmSelector.Models;
using FilmSelector.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FilmSelector.Services
{
    public class UserService
    {
        private UserRepository userRepository;

        public UserService(UserRepository userRepository)
        {
            this.userRepository = userRepository;
        }

        public List<User> ListOfUsers()
        {
            return userRepository.AllUser();
        }

        public User GetUserWithName(string name)
        {
            return userRepository.GetUserWithName(name);
        }

        public User GetUserWithId(int id)
        {
            return userRepository.GetUserWithId(id);
        }

        public void AddUser(string name)
        {
            userRepository.AddUser(name);
        }

        public List<Film> CommonFilmList(int myId, string otherName)
        {
            var Me = userRepository.GetUserWithId(myId);
            var OtherUser = userRepository.GetUserWithName(otherName);
            List<Film> Films = new List<Film>();
            foreach(var film in Me.Films)
            {
                if (OtherUser.Films.Contains(film))
                    Films.Add(film.Film);
            }
            return Films;
        }

        public List<Series> CommonSeriesList(int myId, string otherName)
        {
            var Me = userRepository.GetUserWithId(myId);
            var OtherUser = userRepository.GetUserWithName(otherName);
            List<Series> Series = new List<Series>();
            foreach (var series in Me.Series)
            {
                if (OtherUser.Series.Contains(series))
                    Series.Add(series.Series);
            }
            return Series;
        }
    }
}
