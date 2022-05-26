using System;
using FlowerApi.Entities;

namespace FlowerApi.Services.Interfaces
{
	public interface IProductService
	{
		IEnumerable<Product> GetProducts();
		Product GetProductById(Guid id);
		Task<Product> CreateProduct();
		Task<Product> DeleteProduct();
		Task<Product> UpdateProduct();
	}
}
