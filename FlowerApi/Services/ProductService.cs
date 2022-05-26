using System;
using FlowerApi.Services.Interfaces;
using FlowerApi.Entities;

namespace FlowerApi.Services
{
	public class ProductService : IProductService
	{
		public ProductService()
		{
		}

        public Task<Product> CreateProduct()
        {
            throw new NotImplementedException();
        }

        public Task<Product> DeleteProduct()
        {
            throw new NotImplementedException();
        }

        public Product GetProductById(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Product> GetProducts()
        {
            throw new NotImplementedException();
        }

        public Task<Product> UpdateProduct()
        {
            throw new NotImplementedException();
        }
    }
}