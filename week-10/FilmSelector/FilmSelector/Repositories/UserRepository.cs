using FilmSelector.Entities;
using FilmSelector.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FilmSelector.Repositories
{
    public class UserRepository
    {
        private SelectorContext selectorContext;

        public UserRepository(SelectorContext selectorContext)
        {
            this.selectorContext = selectorContext;
        }

        public List<User> AllUser()
        {
            selectorContext.Films.Load();
            selectorContext.Series.Load();
            return selectorContext.Users.ToList();
        }

        public void AddUser(string name)
        {
            User newUser = new User()
            {
                Name = name
            };
            selectorContext.Users.Add(newUser);
            selectorContext.SaveChanges();
        }

        public User GetUserWithId(int UserId)
        {
            selectorContext.UserFilm.Load();
            selectorContext.UserSeries.Load();
            selectorContext.Users.Load();
            selectorContext.Films.Load();
            selectorContext.Series.Load();
            return selectorContext.Users.Single(x => x.UserId == UserId);
        }

        public User GetUserWithName(string UserName)
        {
            selectorContext.UserFilm.Load();
            selectorContext.UserSeries.Load();
            selectorContext.Users.Load();
            selectorContext.Films.Load();
            selectorContext.Series.Load();
            return selectorContext.Users.Single(x => x.Name == UserName);
        }
    }
}
