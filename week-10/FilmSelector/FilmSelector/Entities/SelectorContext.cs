
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
        public DbSet<UserFilm> UserFilm { get; set; }
        public DbSet<UserSeries> UserSeries { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UserSeries>()
                .HasKey(us => new { us.UserId, us.Id });

            modelBuilder.Entity<UserSeries>()
                .HasOne(us => us.User)
                .WithMany(u => u.Series)
                .HasForeignKey(us => us.UserId);

            modelBuilder.Entity<UserSeries>()
                .HasOne(us => us.Series)
                .WithMany(s => s.Users)
                .HasForeignKey(us => us.Id);

            modelBuilder.Entity<UserFilm>()
                .HasKey(bc => new { bc.UserId, bc.Id });

            modelBuilder.Entity<UserFilm>()
                .HasOne(bc => bc.User)
                .WithMany(b => b.Films)
                .HasForeignKey(bc => bc.UserId);

            modelBuilder.Entity<UserFilm>()
                .HasOne(bc => bc.Film)
                .WithMany(c => c.Users)
                .HasForeignKey(bc => bc.Id);
        }
    }
}
