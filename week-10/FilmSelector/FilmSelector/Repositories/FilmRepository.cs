using FilmSelector.Entities;
using FilmSelector.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FilmSelector.Repositories
{
    public class FilmRepository
    {
        private SelectorContext selectorContext;

        public FilmRepository(SelectorContext selectorContext)
        {
            this.selectorContext = selectorContext;
        }

        public List<Film> AllFilm()
        {
            selectorContext.Users.Load();
            return selectorContext.Films.ToList();
        }

        public void AddFilm(Creator filmCreator, User user)
        {
            Film newFilm = new Film()
            {
                Title = filmCreator.Title,
                IMdB = filmCreator.IMdB,
                Link = filmCreator.Link,
                Users = new List<UserFilm>()
                {
                    new UserFilm()
                    {
                        User = user
                    }
                }
            };
            selectorContext.Films.Add(newFilm);
            selectorContext.SaveChanges();
        }

        public Film GetFilmWithId(int Id)
        {
            return selectorContext.Films.Single(x => x.Id == Id);
        }
    }
}
