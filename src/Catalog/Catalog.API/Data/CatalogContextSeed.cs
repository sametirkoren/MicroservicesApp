using Catalog.API.Entities;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Catalog.API.Data
{
    public class CatalogContextSeed
    {
        public static void SeedData(IMongoCollection<Product> productCollection)
        {
            bool existProduct = productCollection.Find(p => true).Any();
            if (!existProduct)
            {
                productCollection.InsertManyAsync(GetPreconfiguredProducts());
            }
        }

        private static IEnumerable<Product> GetPreconfiguredProducts()
        {
            return new List<Product>()
            {
                new Product()
                {
                    Name = "Iphone X",
                    Summary = "Summary",
                    Description = "Description",
                    ImageFile = "product-1.png",
                    Price = 850.00M,
                    Category = "Smart Phone"
                },
                new Product()
                {
                    Name = "Redmi Note 8 ",
                    Summary = "Summary",
                    Description = "Description",
                    ImageFile = "product-2.png",
                    Price = 550.00M,
                    Category = "Smart Phone"
                },
                new Product()
                {
                    Name = "Iphone 6",
                    Summary = "Summary",
                    Description = "Description",
                    ImageFile = "product-3.png",
                    Price = 350.00M,
                    Category = "Smart Phone"
                },
                new Product()
                {
                    Name = "Samsung S10",
                    Summary = "Summary",
                    Description = "Description",
                    ImageFile = "product-4.png",
                    Price = 750.00M,
                    Category = "Smart Phone"
                },
                new Product()
                {
                    Name = "Note 5",
                    Summary = "Summary",
                    Description = "Description",
                    ImageFile = "product-5.png",
                    Price = 650.00M,
                    Category = "Smart Phone"
                },
            };
        }
    }
}
