using System;
using System.Collections.Generic;
using FlowerApi.Entities;

namespace FlowerApi.Repositories.Interfaces
{
    public interface IProductRepository
    {
        public IEnumerable<Product> GetProducts();

        public Product GetProductById(Guid id);

        public IEnumerable<Product> GetProductsByCategory(string categoryName);

        public void AddToCart(Product product, Guid cartId);

        public void DeleteProduct(Product product);

        public void UpdateProduct(Guid id, Product product);

        public void AddProduct(Product product);

        public Task MakeReservation(Guid userid);
    }
}
