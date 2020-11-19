using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SPM.API.Configuration;
using SPM.API.Models;

namespace SPM.API.Data
{
    public class ProductContext: DbContext
    {
        public ProductContext(DbContextOptions<ProductContext> opt): base(opt)
        {
            
        }

        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ProductDataSeedingConfiguration());
        }
    }
}
