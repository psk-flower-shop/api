using System;
using FlowerApi.Entities;
using FlowerApi.Services.Interfaces;
using FlowerApi.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace FlowerApi.Services
{
	public class UserService : IUserService
	{

        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository repository)
		{
            this._userRepository = repository;
		}

        public Task<User> CreateUser()
        {
            throw new NotImplementedException();
        }

        public Task<User> DeleteUser()
        {
            throw new NotImplementedException();
        }

        public User UpdateUser(string email)
        {
            IEnumerable<User> users = _userRepository.GetUsers();
            User user = users.Single(users => users.Email == email);

            try
            {
                _userRepository.StartOwnTransactionWithinContext(user.Email);
            }catch(DbUpdateConcurrencyException ex)
            {
                return null;
            }
            

            return user;
        }

        public User GetUserById(Guid id)
        {
            return _userRepository.GetUserById(id);
        }

        public IEnumerable<User> GetUsers()
        {
            return _userRepository.GetUsers();
        }

        public List<CartItem> getUsersCartItems(Guid userId)
        {
            var items = _userRepository.getUsersCartItems(userId);
            return items;
        }
    }
}

