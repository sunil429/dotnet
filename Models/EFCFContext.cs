using Microsoft.EntityFrameworkCore;
using MVCCoreEFCF_DropDownDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCCoreEFCF_DropDownDemo.Models
{
    public class EFCFContext : DbContext
    {
        public EFCFContext(DbContextOptions<EFCFContext> options) : base(options)
        { }

        //collections
        public DbSet<Category> Categories { get; set; }

        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelbuilder)
        {
            modelbuilder.Entity<Category>().ToTable("Category");
            modelbuilder.Entity<Product>().ToTable("Product");
        }
    }
}
