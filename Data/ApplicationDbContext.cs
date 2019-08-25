using AlbaniaCheckCar.Models;
using IdentityServer4.EntityFramework.Options;
using Microsoft.AspNetCore.ApiAuthorization.IdentityServer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AlbaniaCheckCar.Data
{
    public class ApplicationDbContext : ApiAuthorizationDbContext<ApplicationUser>
    {
        public ApplicationDbContext(
            DbContextOptions options,
            IOptions<OperationalStoreOptions> operationalStoreOptions) : base(options, operationalStoreOptions)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            
            modelBuilder.Entity<ApplicationRole>().HasData(
                new ApplicationRole { Name = "Admin", NormalizedName = "Admin".ToUpper(), CanDelete = false},
                new ApplicationRole { Name = "Worker", NormalizedName = "Worker".ToUpper(), CanDelete = false},
                new ApplicationRole { Name = "Shop", NormalizedName = "Shop".ToUpper(), CanDelete = false},
                new ApplicationRole { Name = "Client", NormalizedName = "Client".ToUpper(), CanDelete = false}
            );
            
            modelBuilder.Entity<ApplicationRole>()
                .HasMany(e => e.Users)
                .WithOne()
                .HasForeignKey(e => e.RoleId)
                .IsRequired();
            
            modelBuilder.Entity<ApplicationRole>()
                .HasMany(e => e.Users)
                .WithOne()
                .HasForeignKey(e => e.RoleId)
                .IsRequired();
        }
    }
}