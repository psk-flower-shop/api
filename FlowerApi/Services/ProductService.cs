using System;
using FlowerApi.Services.Interfaces;
using FlowerApi.Entities;
using FlowerApi.Repositories.Interfaces;

namespace FlowerApi.Services
{
	public class ProductService : IProductService
	{

        private readonly IProductRepository _productRepository;

		public ProductService(IProductRepository repository)
		{
            _productRepository = repository;
		}

        public Task<Product> CreateProduct()
        {
            throw new NotImplementedException();
        }

        public Task<Product> DeleteProduct()
        {
            throw new NotImplementedException();
        }

        public Product GetProductById(Guid id)
        {
            return _productRepository.GetProductById(id);
        }

        public IEnumerable<Product> GetProducts()
        {
            return _productRepository.GetProducts();
        }

        public Task<Product> UpdateProduct()
        {
            throw new NotImplementedException();
        }
    }
}