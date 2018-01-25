using Microsoft.EntityFrameworkCore;
using Reddit.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Reddit.Entities
{
    public class RedditContext : DbContext
    {
        public RedditContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Post> Reddit { get; set; }
    }
}
