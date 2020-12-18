
using System;
using Microsoft.EntityFrameworkCore;


using carrentals.Models.Storage;
using carrentals.Models.Storage.EFModels;

using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;


namespace carrentals.Models.Storage
{
    public class ApplicationContext : IdentityDbContext<IdentityUser>
    {
        internal object HakuCAR;

        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options) 
        {
            
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            
        }

        public DbSet<HakuCAR> Cars { get; set; }
        public DbSet<Rent> Rents { get; set; }
        public DbSet<CustomerEF> Customers { get; set; }
        // public object HakuCAR { get; internal set; }
    }
}
