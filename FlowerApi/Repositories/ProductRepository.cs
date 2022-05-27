using System;
using FlowerApi.Entities;
using FlowerApi.Repositories.Interfaces;
using FlowerApi.Data;
using Microsoft.EntityFrameworkCore;

namespace FlowerApi.Repositories
{
	public class ProductRepository : IProductRepository
	{

        private FlowersContext _context;

		public ProductRepository(FlowersContext context)
		{
            this._context = context;
		}

        public Product GetProductById(Guid id) => _context.Products.ToList().FirstOrDefault(x => x.Id == id);

        public IEnumerable<Product> GetProducts() => _context.Products.Include(e => e.Category).ToList();

        public void AddToCart(Product product, Guid cartId)
        {
            
            
        }
        public void DeleteProduct(Product product)
        {
            _context.Products.Remove(product);
            _context.SaveChanges();
        }

        public void UpdateProduct(Guid id, Product product)
        {
            var oldProduct = _context.Products.ToList().FirstOrDefault(x => x.Id == id);
            DeleteProduct(oldProduct);
            _context.Products.Add(product);
            _context.SaveChanges();

        }
        public void AddProduct(Product product)
        {
            _context.Products.Add(product);
            _context.SaveChanges();
        }
    }
}
