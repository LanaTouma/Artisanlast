using Microsoft.EntityFrameworkCore;
using Artisan.Domain;
using System.Collections.Generic;
using System.Reflection.Emit;
using Artisan.Domain.Entities; 

namespace Artisan.Infrastructure.Data
{ 
    public class ArtisanDBContext : DbContext
    {
        public ArtisanDBContext(DbContextOptions<ArtisanDBContext> options)
            : base(options)
        {
        }

        public DbSet<Artisans> Artisans{ get; set; }
        public DbSet<Products> Products { get; set; }
        public DbSet<Category> Category { get; set; }
        public DbSet<OrderItems> OrderItems { get; set; }
        public DbSet<Orders> Orders { get; set; }
        public DbSet<Customer> Customer { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            
        }
    }
}
