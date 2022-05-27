using System;
using FlowerApi.Entities;

namespace FlowerApi.Services.Interfaces
{
	public interface IProductService
	{
		IEnumerable<Product> GetProducts();
		Product GetProductById(Guid id);
		Product CreateProduct(Product product);
		bool DeleteProduct(Guid id);
		Product UpdateProduct(Guid id);
	}
}
