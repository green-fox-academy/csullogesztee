using JetBrains.Annotations;
using Microsoft.EntityFrameworkCore;
using PallidaOrientation.Models;

namespace PallidaOrientation.Entities
{
    public class ShopContext : DbContext
    {
        public ShopContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Clothes> Clothes { get; set; }
    }
}
