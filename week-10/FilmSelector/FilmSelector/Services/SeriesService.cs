using FilmSelector.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FilmSelector.Services
{
    public class SeriesService
    {
        private SeriesRepository seriesRepository;

        public SeriesService(SeriesRepository seriesRepository)
        {
            this.seriesRepository = seriesRepository;
        }
    }
}
