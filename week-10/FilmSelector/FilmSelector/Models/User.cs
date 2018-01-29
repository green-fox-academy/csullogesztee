using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FilmSelector.Models
{
    public class User
    {
        public long? Id { get; set; }
        public string Name { get; set; }
        public List<Program> Programs { get; set; } = new List<Program>();
    }
}
