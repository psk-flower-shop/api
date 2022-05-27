using System;
using FlowerApi.Entities;

namespace FlowerApi.DTO
{
	public class CartDTO
	{
		public Guid Id { get; set; }
		public decimal Price { get; set; }
		public List<Product>? ProductsInCart { get; set; }


		public CartDTO()
		{
		}
	}
}

