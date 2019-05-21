using System;
using System.Collections.Generic;
using System.Data.Entity;

namespace FarmManagement.Core.Models
{
    /// <summary>
    /// DBContext Entity Framework
    /// </summary>
    class FarmManagementDBContext : DbContext
    {
        public FarmManagementDBContext()
        {

        }

        // Entities
        public DbSet<Product> Products { get; set; }
        public DbSet<CareWork> CareWorks { get; set; }

        public DbSet<CareWorkDetail> CareWorkDetails { get; set; }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<DiseasePreventionDetail> DiseasePreventionDetails { get; set; }

        public DbSet<DiseasePrevention> DiseasePreventions { get; set; }

        public DbSet<FarmingSeason> FarmingSeasons { get; set; }
        public DbSet<Food> Foods { get; set; }
        public DbSet<FoodBatch> FoodBatches { get; set; }

        public DbSet<Location> Locations { get; set; }
        public DbSet<Medicine> Medicines { get; set; }

        public DbSet<MedicineBatch> MedicineBatches { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<ProductBatch> ProductBatches { get; set; }

        public DbSet<ProductForFarmingSeason> ProductForFarmings { get; set; }
        public DbSet<ProductForFarmingSeasonDetail> ProductForFarmingDetails { get; set; }

        public DbSet<ProductGroup> ProductGroups { get; set; }

        public DbSet<ProductType> ProductTypes { get; set; }

        public DbSet<Role> Roles { get; set; }

        public DbSet<Staff> Staffs { get; set; }

        public DbSet<Supplier> Suppliers { get; set; }

        public DbSet<UserInRole> UserInRoles { get; set; }

    }
}
