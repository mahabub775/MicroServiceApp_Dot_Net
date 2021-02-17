using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ProductMicroService.Models;

namespace ProductMicroService.DBContexts
{
        public class ProductContext : DbContext
        {
            public ProductContext(DbContextOptions<ProductContext> options) : base(options)
            {

            }
            public DbSet<Product> Products { get; set; }
          public DbSet<Category> Categories { get; set; }

        //it will be create when will first time run
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category
                {
                    Id = 1,
                    Name = "Electronics",
                    Description = "Electronic Items",
                },
                new Category
                {
                    Id = 2,
                    Name = "Clothes",
                    Description = "Dresses",
                },
                new Category
                {
                    Id = 3,
                    Name = "Grocery",
                    Description = "Grocery Items",
                }
            );
        }

    }
}
