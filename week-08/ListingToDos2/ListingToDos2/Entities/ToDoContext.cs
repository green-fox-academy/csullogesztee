using ListingTodos2.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ListingTodos2.Entities
{
    public class TodoContext : DbContext
    {
        public TodoContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<ToDo> ToDos { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<User>()
                .HasMany(x => x.CreatedToDos)
                .WithOne(x => x.Creator)
                .HasPrincipalKey(x => x.UserId);

            modelBuilder.Entity<User>()
                .HasMany(x => x.ToDos)
                .WithOne(x => x.Assignee)
                .HasPrincipalKey(x => x.UserId);
        }

    }
}