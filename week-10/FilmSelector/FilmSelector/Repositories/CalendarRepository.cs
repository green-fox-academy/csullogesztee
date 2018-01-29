using FilmSelector.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FilmSelector.Repositories
{
    public class CalendarRepository
    {
        private SelectorContext selectorContext { get; set; }

        public CalendarRepository(SelectorContext selectorContext)
        {
            this.selectorContext = selectorContext;
        }
    }
}
