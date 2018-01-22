using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TheReddit.Models;

namespace TheReddit.Entities
{
    public class RedditContext : DbContext
    {
        public RedditContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Post> Posts { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
                .HasMany(x => x.PostsOfTheUser)
                .WithOne(x => x.User)
                .HasPrincipalKey(x => x.UserId);
        }
    }
}
