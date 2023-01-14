﻿using Catalog.API.Entities;
using MongoDB.Driver;

namespace Catalog.API.Data
{
    public class CatalogContext : ICatalogContext
    {
        public CatalogContext(IConfiguration configuration)
        {
            var client = new MongoClient(configuration.GetValue<string>("DatabaseSettings:MongoConnectionString"));
            var db = client.GetDatabase(configuration.GetValue<string>("DatabaseSettings:MongoDatabaseName"));

            Products = db.GetCollection<Product>(configuration.GetValue<string>("DatabaseSettings:CollectionName"));
           
            CatalogContextSeed.SeedData(Products);
        }

        public IMongoCollection<Product> Products { get; }
    }
}
