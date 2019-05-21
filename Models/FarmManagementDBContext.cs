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
    }
}
