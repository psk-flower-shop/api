using System;
using FlowerApi.Entities;

namespace FlowerApi.DTO
{
	public class ProductDTO
	{

        public Guid Id { get; set; }
        public decimal Price { get; set; }
        public int Amount { get; set; }
        public string? Name { get; set; }

        public Category? Category { get; set; }

        public ProductDTO()
		{
		}
	}
}

