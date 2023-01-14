using Catalog.API.Entities;
using MongoDB.Driver;
using System.Collections;
using System.Net.NetworkInformation;
using System.Security.Cryptography;
using System.Xml.Linq;

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
                    Id = "63c13f1a0b0f3045107c5306",
                    Name = "Samsung Galaxy",
                    Summary =  "Mobile phone with 5g technology",
                    Description =  "A vew with the edge-cutting technology of 5g is what this phone offers you",
                    Imagefile =  "Imagefile",
                    Price =  54.93M,
                    Category = "Mobile",
               },
               new Product()
               {
                    Id = "63c13f1a0b0f3045107c5307",
                    Name = "Vivo 1801",
                    Summary =  "A mobile of dreams",
                    Description =  "this is a mobile at a low cost with high features and long battery life",
                    Imagefile =  "Imagefile",
                    Price =  28.90M,
                    Category = "Mobile Phone",
               },
               new Product()
               {
                    Id = "63c13f1a0b0f3045107c5308",
                    Name = "ONePLus8",
                    Summary =  "A budget friendly mobile if you're looking for a goood looking camera ",
                    Description =  "A high quality 1080mp camera with dolby audio drivers",
                    Imagefile =  "Imagefile",
                    Price =  54.93M,
                    Category = "Mobile",
               },
           };
        }
    }
}
