using MongoDB.Driver;
using Catalog.API.Entities;

namespace Catalog.API.Data
{
    public class CatalogContextSeed
    {
        public static void SeedData(IMongoCollection<Product> productCollection)
        {
            bool existProduct = productCollection.Find(p => true).Any();
            if (existProduct)
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
                Id = "65ca71ba3c9e6d50eef76271",
                Category = "Mobile",
                Summary = "Summary",
                Description = "Description",
                Price = 88.93M,
                ImageFile = "product-3.png",
                },
                new Product()
                {
                Id = "65ca71ba3c9e6d50eef76272",
                Name = "Oneplus Nord CE3",
                Category = "Mobile",
                Summary = "Summary",
                Description = "Description",
                Price = 20.93M,
                ImageFile = "product-4.png",
                },
                new Product()
                {
                Id = "65ca71ba3c9e6d50eef76273",
                Name = "Samsung S24",
                Category = "Mobile",
                Summary = "Summary",
                Description = "Description",
                Price = 100.93M,
                ImageFile = "product-5.png",
                },
            };
        }
    }
 }
