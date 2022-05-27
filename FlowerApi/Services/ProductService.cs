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

        public Product CreateProduct(Product product)
        {
            _productRepository.AddProduct(product);
            return product;
        }

        public bool DeleteProduct(Guid id)
        {
            try
            {
                Product product = GetProducts().Single(x => x.Id == id);
                _productRepository.DeleteProduct(product);
                return true;
            }
            catch (Exception)
            {
                Console.WriteLine("rip bozo. No such product");
                return false;
            }
            
        }

        public Product GetProductById(Guid id)
        {
            return _productRepository.GetProductById(id);
        }

        public IEnumerable<Product> GetProducts()
        {
            return _productRepository.GetProducts();
        }

        public Product UpdateProduct(Guid id)
        {
            var product = GetProducts().FirstOrDefault(x => x.Id == id);
            if (product != null)
                _productRepository.UpdateProduct(id, product);
            else return new Product();

            return product;
        }
    }
}