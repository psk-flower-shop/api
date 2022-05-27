using System;
using FlowerApi.Entities;
using FlowerApi.Services.Interfaces;
using FlowerApi.Repositories.Interfaces;

namespace FlowerApi.Services
{
	public class UserService : IUserService
	{

        private readonly IUserRepository _userRepository;
        private readonly IProductService _productService;

        public UserService(IUserRepository repository, IProductService productService)
		{
            this._userRepository = repository;
            this._productService = productService;
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

        public List<CartItem> getUsersCartItems(Guid userId)
        {
            var items = _userRepository.getUsersCartItems(userId);
            return items;
        }

        public bool AddProductToWishlist(Guid userId, Guid productId)
        {
            var product = this._productService.GetProductById(productId);

            if (product == null)
            {
                return false;
            }

            this._userRepository.AddProductToWishlist(product, userId);
            return true;
        }
    }
}

