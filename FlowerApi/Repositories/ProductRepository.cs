using System;
using FlowerApi.Entities;
using FlowerApi.Repositories.Interfaces;
using FlowerApi.Data;

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

        public IEnumerable<Product> GetProducts() => _context.Products.ToList();
    }
}
