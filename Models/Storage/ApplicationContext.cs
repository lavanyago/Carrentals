
using System;
using Microsoft.EntityFrameworkCore;
using carrentals.Models.Storage.EFModels;

using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;


namespace hakucarrental.Models.Storage
{
    public class ApplicationContext : IdentityDbContext<IdentityUser>
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options) 
        {
            
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            
        }

        public DbSet<HakuCAR> Cars { get; set; }
        public DbSet<Rent> Rents { get; set; }
        public DbSet<Customer> Customers { get; set; }
    }
}
