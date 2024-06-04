using Microsoft.EntityFrameworkCore;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmlakTakip.Models
{
    public class AppDbContext : DbContext
    {
        public DbSet<Properties> Properties { get; set; }
        public DbSet<Listing> Listing { get; set; }
        public DbSet<PropertyOwner> PropertyOwner { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("data source=.;initial catalog=CBS03DB;user id=Erencem; password=123;TrustServerCertificate=True");
        }
    }
}
