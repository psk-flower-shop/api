using System;
using FlowerApi.Entities;
using FlowerApi.Services.Interfaces;
using FlowerApi.Repositories.Interfaces;

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

        public Task<User> UpdateUser()
        {
            throw new NotImplementedException();
        }

        public User GetUserById(Guid id)
        {
            return _userRepository.GetUserById(id);
        }

        public IEnumerable<User> GetUsers()
        {
            return _userRepository.GetUsers();
        }

    }
}

