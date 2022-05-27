using System;
using FlowerApi.Entities;

namespace FlowerApi.DTO
{
	public class UserDTO
	{
		public Guid Id { get; set; }
		public string? Name { get; set; }
		public string? Email { get; set; }
		public string? Password { get; set; }
		public List<Product>? FavoriteProducts { get; set; }
		public Cart Cart { get; set; }

		public UserDTO()
		{
		}
	}
}

