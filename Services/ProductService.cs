using System;
using System.Text.Json;

namespace MauiApp1.Services
{
    public class ProductService
    {
        private List<Models.Product> products;

        public void Load()
        {
#pragma warning disable CA1416 // Validate platform compatibility
            using var stream = FileSystem.OpenAppPackageFileAsync("products.json").Result;
#pragma warning restore CA1416 // Validate platform compatibility
            products = JsonSerializer.DeserializeAsync<List<Models.Product>>(stream).Result;
        }

        public List<Models.Product> GetProducts(Models.CategoryType category, Models.SubCategoryType subType)
        {
            return (from p in products
                    where p.category == category
                    & p.subcategory == subType
                    select p).ToList();
        }
    }
}

