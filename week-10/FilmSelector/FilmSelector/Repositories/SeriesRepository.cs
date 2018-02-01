using FilmSelector.Entities;
using FilmSelector.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FilmSelector.Repositories
{
    public class SeriesRepository
    {
        private SelectorContext selectorContext;

        public SeriesRepository(SelectorContext selectorContext)
        {
            this.selectorContext = selectorContext;
        }

        public List<Series> AllSeries()
        {
            selectorContext.Users.Load();
            return selectorContext.Series.ToList();
        }

        public void AddSeries(Creator seriesCreator, User user)
        {
            Series newSeries = new Series()
            {
                Title = seriesCreator.Title,
                IMdB = seriesCreator.IMdB,
                Link = seriesCreator.Link,
                Users = new List<UserSeries>()
                {
                    new UserSeries()
                    {
                        User = user
                    }
                }
            };
            selectorContext.Series.Add(newSeries);
            selectorContext.SaveChanges();
        }

        public Series GetSeriesWithId(int Id)
        {
            return selectorContext.Series.Single(x => x.Id == Id);
        }
    }
}
