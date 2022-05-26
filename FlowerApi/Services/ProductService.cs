using System;
using FlowerApi.Services.Interfaces;
using FlowerApi.Entities;
using FlowerApi.Repositories;

namespace FlowerApi.Services
{
	public class ProductService : IProductService
	{

        private readonly MockProductRepository _mockProductRepository;

		public ProductService(MockProductRepository repository)
		{
            _mockProductRepository = repository;
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
            return _mockProductRepository.GetProducts();
        }

        public Task<Product> UpdateProduct()
        {
            throw new NotImplementedException();
        }
    }
}