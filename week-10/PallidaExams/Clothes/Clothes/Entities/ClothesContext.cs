using ClothesMarket.Models;
using Microsoft.EntityFrameworkCore;

namespace ClothesMarket.Entities
{
    public class ClothesContext : DbContext
    {
        public ClothesContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Clothes> Warehouse { get; set; }
    }
}
