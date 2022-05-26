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
            new Product {Id = Guid.NewGuid(), Price = new PriceType {Euros = 3, Cents = 20}, Amount = 20, Name = "Roze"},
            new Product {Id = Guid.NewGuid(), Price = new PriceType {Euros = 2, Cents = 90}, Amount = 30, Name = "Tulpe"},
            new Product {Id = Guid.NewGuid(), Price = new PriceType {Euros = 999, Cents = 99}, Amount = 1, Name = "Juoda orchideja"}
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