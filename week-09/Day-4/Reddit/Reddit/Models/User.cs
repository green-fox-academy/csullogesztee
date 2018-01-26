using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Reddit.Models
{
    public class User
    {
        public long? UserId { get; set; }
        public string Name { get; set; }
        public IList<Post> PostsOfTheUser { get; set; } = new List<Post>();
    }
}
