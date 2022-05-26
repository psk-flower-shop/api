using System;
using System.Collections.Generic;
using FlowerApi.Entities;

namespace FlowerApi.Repositories.Interfaces
{
    public interface IProductRepository
    {
        public IEnumerable<Product> GetProducts();

        public Product GetProductById(Guid id);
    }
}
