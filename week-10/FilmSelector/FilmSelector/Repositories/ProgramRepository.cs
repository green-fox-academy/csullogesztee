using FilmSelector.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FilmSelector.Repositories
{
    public class ProgramRepository
    {
        private SelectorContext selectorContext { get; set; }

        public ProgramRepository(SelectorContext selectorContext)
        {
            this.selectorContext = selectorContext;
        }
    }
}
