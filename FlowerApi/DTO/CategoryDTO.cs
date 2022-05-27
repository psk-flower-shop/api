using System;
using FlowerApi.Entities;

namespace FlowerApi.DTO
{
	public class CategoryDTO
	{
		public Guid Id { get; set; }
		public string? Name { get; set; }

		public List<Product> Products { get; set; }

		public CategoryDTO()
		{
		}
	}
}

