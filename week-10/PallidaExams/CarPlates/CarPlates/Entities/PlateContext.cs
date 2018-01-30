using CarPlates.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarPlates.Entities
{
    public class PlateContext : DbContext
    {
        public PlateContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<LicencePlate> LicencePlates { get; set; }
    }
}
