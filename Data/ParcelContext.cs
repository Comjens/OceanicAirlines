using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using OceanicAirlines.Model;

namespace OceanicAirlines.Data
{
    public class ParcelContext : DbContext
    {
        public ParcelContext(DbContextOptions<ParcelContext> options) : base(options)
        {
        }

        public DbSet<LocationModel> Locations { get; set; }
        public DbSet<RouteModel> Routes { get; set; }
        public DbSet<ShipmentModel> Shipments { get; set; }
        public DbSet<ShipmentTypeModel> ShipmentTypes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ShipmentModel>().ToTable("Shipment");
            modelBuilder.Entity<ShipmentTypeModel>().ToTable("ShipmentType");
            modelBuilder.Entity<RouteModel>().ToTable("Route");
            modelBuilder.Entity<LocationModel>().ToTable("Location");
        }
    }
}

