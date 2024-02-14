using MongoDB.Driver;
using Catalog.API.Entities;

namespace Catalog.API.Data
{
    public interface ICatalogContext
    {

        // All the applications using this interface gets the Product data as a a Product calss obj
        IMongoCollection<Product> Products { get; }
    }
}
