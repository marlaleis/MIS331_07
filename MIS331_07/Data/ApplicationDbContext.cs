using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking.Internal;
using MIS331_07.Models;
using System.Security.Authentication.ExtendedProtection;

namespace MIS331_07.Data
{
    public class ApplicationDbContext : DbContext

    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }

        public DbSet<PriceList> PriceLists { get; set; }    

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PriceList>().HasData(
                new PriceList { Id = 1, Date = new DateTime(2024, 10, 11, 0, 0, 0, DateTimeKind.Utc), Item = "Lean Ground Beef", UOM = "grams", Amount = 450, Brand = "Your Fresh Market", OriginalPrice = 7.48, Discount = 0, ExtendedPrice = 7.48 }
                
                );            
        }
    }
}

