using MongoDB.Driver;
using Catalog.API.Entities;
namespace Catalog.API.Data
{
    public class CatalogContext : ICatalogContext
    {
        public CatalogContext(IConfiguration configuration) 
        {
            var client=new MongoClient(configuration.GetValue<string>("Database settings:ConnectionString"));
            var database = client.GetDatabase(configuration.GetValue<string>("Database settings:DatabaseName"));

            Products = database.GetCollection<Product>(configuration.GetValue<string>("Database settings:CollectionName"));
            CatalogContextSeed.SeedData(Products);
        } 
        public IMongoCollection<Product> Products {  get; }
    }
}
