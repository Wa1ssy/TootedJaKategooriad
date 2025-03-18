using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TootedJaKategooriad
{
    public class ProductsContext : DbContext
    {
        public DbSet<Product> Products { get; set;}
        public DbSet<Category> Categories { get; set;}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) => optionsBuilder.UseSqlite
            ("Data Source=products.db");

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category { CategoryID = 1, CategoryName = "Exotic Fruits"},
                new Category { CategoryID = 2, CategoryName = "Fruits"},
                new Category { CategoryID = 3, CategoryName = "Meat Products"},
                new Category { CategoryID = 4, CategoryName = "Milk Products"}
                );
            modelBuilder.Entity<Product>().HasData(
                new Product { ProductID = 1,CategoryID = 1, ProductName = "Durian"},
                new Product { ProductID = 2,CategoryID = 1, ProductName = "Lychee"},
                new Product { ProductID = 3,CategoryID = 1, ProductName = "Dragon Fruit"},
                new Product { ProductID = 4,CategoryID = 1, ProductName = "Passion Fruit"},
                new Product { ProductID = 5,CategoryID = 1, ProductName = "Guava"},
                new Product { ProductID = 6,CategoryID = 1, ProductName = "Papaya"},
                new Product { ProductID = 7,CategoryID = 1, ProductName = "Starfruit"},
                new Product { ProductID = 8,CategoryID = 1, ProductName = "Rambutan"},
                new Product { ProductID = 9,CategoryID = 2, ProductName = "Banana"},
                new Product { ProductID = 10,CategoryID = 2, ProductName = "Strawberry"},
                new Product { ProductID = 11,CategoryID = 2, ProductName = "Watermelon"},
                new Product { ProductID = 12,CategoryID = 2, ProductName = "Grape"},
                new Product { ProductID = 13,CategoryID = 2, ProductName = "Melon"},
                new Product { ProductID = 14,CategoryID = 2, ProductName = "Orange"},
                new Product { ProductID = 15,CategoryID = 2, ProductName = "Lime"},
                new Product { ProductID = 16,CategoryID = 2, ProductName = "Lemon"},
                new Product { ProductID = 17,CategoryID = 3, ProductName = "Steak"},
                new Product { ProductID = 18,CategoryID = 3, ProductName = "Sausages"},
                new Product { ProductID = 19,CategoryID = 3, ProductName = "Wagyu beef"},
                new Product { ProductID = 20,CategoryID = 3, ProductName = "Chicken thighs"},
                new Product { ProductID = 21,CategoryID = 3, ProductName = "Chicken"},
                new Product { ProductID = 22,CategoryID = 3, ProductName = "Jamon"},
                new Product { ProductID = 23,CategoryID = 3, ProductName = "Salami"},
                new Product { ProductID = 24,CategoryID = 3, ProductName = "Ham"},
                new Product { ProductID = 25,CategoryID = 3, ProductName = "Chocolate milk"},
                new Product { ProductID = 26,CategoryID = 3, ProductName = "Strawberry milk"},
                new Product { ProductID = 27,CategoryID = 3, ProductName = "Banana milk"},
                new Product { ProductID = 28,CategoryID = 3, ProductName = "Milk"},
                new Product { ProductID = 29,CategoryID = 3, ProductName = "Blue cheese"},
                new Product { ProductID = 30,CategoryID = 3, ProductName = "Cheese strings"},
                new Product { ProductID = 31,CategoryID = 3, ProductName = "Quark snack"},
                new Product { ProductID = 32,CategoryID = 3, ProductName = "Heavy cream"},
                new Product { ProductID = 33,CategoryID = 3, ProductName = "Almond milk"}
                );
        }
    }
}
