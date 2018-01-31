
using FilmSelector.Models;
using Microsoft.EntityFrameworkCore;

namespace FilmSelector.Entities
{
    public class SelectorContext : DbContext
    {
        public SelectorContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Film> Films { get; set; }
        public DbSet<Series> Series { get; set; }
        public DbSet<Date> Dates { get; set; }
    }
}
