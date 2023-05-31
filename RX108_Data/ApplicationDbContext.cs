using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace RX108_Data
{
    public class ApplicationDbContext: IdentityDbContext<ApplicationUser>
    {
        

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder
                .Entity<ApplicationUser>()
                .Property(e => e.EmailConfirmed)
                .HasConversion<int>();
            builder
    .Entity<ApplicationUser>()
    .Property(e => e.LockoutEnabled)
    .HasConversion<int>();

            builder
    .Entity<ApplicationUser>()
    .Property(e => e.TwoFactorEnabled)
    .HasConversion<int>();

            builder
    .Entity<ApplicationUser>()
    .Property(e => e.PhoneNumberConfirmed)
    .HasConversion<int>();

        }
    }
}
