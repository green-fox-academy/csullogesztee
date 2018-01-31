using FilmSelector.Entities;
using FilmSelector.Models;
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
            return selectorContext.Films.ToList();
        }

        public void AddFilm(Creator filmCreator)
        {
            Film newFilm = new Film()
            {
                Title = filmCreator.Title,
                IMdB = filmCreator.IMdB,
                Link = filmCreator.Link
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
