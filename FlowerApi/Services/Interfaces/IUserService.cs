using System;
using FlowerApi.Entities;

namespace FlowerApi.Services.Interfaces
{
	public interface IUserService
	{
		IEnumerable<User> GetUsers();
		User GetUserById(Guid id);
		Task<User> CreateUser();
		Task<User> DeleteUser();
		public User UpdateUser(string email);

		List<CartItem> getUsersCartItems(Guid userId);
	}
}

