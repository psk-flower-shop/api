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

        public List<Product> GetWishList(Guid id)
        {
            return _userRepository.getWishList(id);
        }
    }
}

