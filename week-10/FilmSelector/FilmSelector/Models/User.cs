using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FilmSelector.Models
{
    public class User
    {
        public int UserId { get; set; }
        public int Name { get; set; }
        public IList<Program> Programs { get; set; } = new List<Program>();
    }
}
