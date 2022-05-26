using System;
using System.Collections.Generic;
using System.Linq;
using FlowerApi.Entities;
using FlowerApi.Repositories.Interfaces;

namespace FlowerApi.Repositories
{
    public class MockProductRepository : IProductRepository
    {
        private readonly List<Product> products = new()
        {
            new Product {Id = Guid.NewGuid(), Price = 30, Amount = 20, Name = "Roze"},
            new Product { Id = Guid.NewGuid(), Price = 25, Amount = 5, Name = "Tulpe"},
            new Product {Id = Guid.NewGuid(), Price = 23, Amount = 1, Name = "Juoda orchideja"}
        };

        public IEnumerable<Product> GetProducts()
        {
            return products;
        }

        public Product GetProductById(Guid id)
        {
            return products.Where(product => product.Id == id).SingleOrDefault();
        }
    }
}