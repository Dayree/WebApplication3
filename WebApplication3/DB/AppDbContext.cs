using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebApplication3.DB;

namespace WebApplication3.DB
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options):base(options)
        {

        }
        public DbSet<User> Users { get; set; }
        public DbSet<Siparis> Siparises { get; set; }
        public DbSet<WebApplication3.DB.Urun> Urun { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().ToTable("User");
            modelBuilder.Entity<Siparis>().ToTable("Siparis");
            modelBuilder.Entity<Urun>().ToTable("Urun");
        }

   
    }
}
