using BlazerUdumyLearning.Server.Configurations.Entities;
using BlazerUdumyLearning.Server.Models;
using BlazerUdumyLearning.Shared.Domain;
using IdentityServer4.EntityFramework.Options;
using Microsoft.AspNetCore.ApiAuthorization.IdentityServer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazerUdumyLearning.Server.Data
{
    public class ApplicationDbContext : ApiAuthorizationDbContext<ApplicationUser>
    {
        public ApplicationDbContext(
            DbContextOptions options,
            IOptions<OperationalStoreOptions> operationalStoreOptions) : base(options, operationalStoreOptions)
        {
        }

        public DbSet<Vehicle> Vehicles { get; set; }
        public DbSet<VehicleModel> Models { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<VehicleColor> VehicleColors { get; set; }
        public DbSet<Booking> Bookings { get; set; }
        public DbSet<Customer> Customers { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            //builder.Entity<Brand>()
            // .Property(b => b.Id).ValueGeneratedOnAdd();//.Metadata.BeforeSaveBehavior = PropertySaveBehavior.save; 

            builder.ApplyConfiguration(new ColorSeedConfig());
            builder.ApplyConfiguration(new BrandSeedConfig());
            builder.ApplyConfiguration(new ModelSeedConfig());
            builder.ApplyConfiguration(new RoleSeedConfig());
            builder.ApplyConfiguration(new UserSeedConfig());
            builder.ApplyConfiguration(new UserRoleSeedConfig());
        }
    }
}
