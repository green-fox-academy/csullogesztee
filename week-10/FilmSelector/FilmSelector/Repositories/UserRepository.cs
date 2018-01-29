using FilmSelector.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FilmSelector.Repositories
{
    public class UserRepository
    {
        private SelectorContext selectorContext { get; set; }

        public UserRepository(SelectorContext selectorContext)
        {
            this.selectorContext = selectorContext;
        }
    }
}
