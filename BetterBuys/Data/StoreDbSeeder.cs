﻿using BetterBuys.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BetterBuys.Data
{
    public class StoreDbSeeder
    {
        public static async Task SeedAsync(StoreDbContext db)
        {
            if (!await db.Categories.AnyAsync())
            {
                await db.Categories.AddRangeAsync(GetPreconfiguredCategories());
                await db.SaveChangesAsync();
            }

            if (!await db.Products.AnyAsync())
            {
                await db.Products.AddRangeAsync(GetPreconfiguredProducts());
                await db.SaveChangesAsync();
            }
        }

        static IEnumerable<Product> GetPreconfiguredProducts()
        {
            return new List<Product>
            {
                new Product(2,".NET Bot Black Sweatshirt", ".NET Bot Black Sweatshirt", 19.5m,  "/images/products/1.png"),
                new Product(1,".NET Black & White Mug", ".NET Black & White Mug", 8.50m, "/images/products/2.png"),
                new Product(2,"Prism White T-Shirt", "Prism White T-Shirt", 12m,  "/images/products/3.png"),
                new Product(2,".NET Foundation Sweatshirt", ".NET Foundation Sweatshirt", 12m, "/images/products/4.png"),
                new Product(3,"Roslyn Red Sheet", "Roslyn Red Sheet", 8.5m, "/images/products/5.png"),
                new Product(2,".NET Blue Sweatshirt", ".NET Blue Sweatshirt", 12m, "/images/products/6.png"),
                new Product(2,"Roslyn Red T-Shirt", "Roslyn Red T-Shirt",  12m, "/images/products/7.png"),
                new Product(2,"Kudu Purple Sweatshirt", "Kudu Purple Sweatshirt", 8.5m, "/images/products/8.png"),
                new Product(1,"Cup<T> White Mug", "Cup<T> White Mug", 12m, "/images/products/9.png"),
                new Product(3,".NET Foundation Sheet", ".NET Foundation Sheet", 12m, "/images/products/10.png"),
                new Product(3,"Cup<T> Sheet", "Cup<T> Sheet", 8.5m, "/images/products/11.png"),
                new Product(2,"Prism White TShirt", "Prism White TShirt", 12m, "/images/products/12.png")
            };
        }

        static IEnumerable<Category> GetPreconfiguredCategories()
        {
            return new List<Category>
            {
                new Category("Mug"),
                new Category("T-Shirt"),
                new Category("Sheet"),
                new Category("USB Memory Stick")
            };
        }
    }
}
