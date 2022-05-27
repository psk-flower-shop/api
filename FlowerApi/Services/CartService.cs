using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using FlowerApi.Entities;
using FlowerApi.Repositories;
using FlowerApi.Repositories.Interfaces;
using FlowerApi.Services.Interfaces;

namespace FlowerApi.Services
{
    public class CartService : ICartService
    {
        IUserRepository _userRepo;

        public CartService( IUserRepository userRepository)
        {
            this._userRepo = userRepository;
        }

        public Task<bool> AddProductToCart(Guid id, Product product)
        {
            throw new NotImplementedException();
        }

        public Task<bool> CreateCart(User user, int cents, int euros, List<Product> products)
        {
            throw new NotImplementedException();
        }

        public bool DeleteCart(User user)
        {
            user.Cart = null;
            return true;
        }

        public Cart FindCart(Guid id)
        {
           var user = _userRepo.GetUserById(id);
            if (user.Cart != null)
            {
                return  user.Cart;
            }
            return null;
        }

        public bool RemoveProductFromCart(Guid id, Product product)
        {
            try
            {
                var user = _userRepo.GetUserById(id);
                user.Cart?.ProductsInCart?.Remove(product);
                return true;
            }
            catch(NullReferenceException) {
                return false;
            }
            
        }


        public bool UpdateCart(Guid id, decimal price, List<Product> products)
        {
            var user = this._userRepo.GetUserById(id);
            user.Cart = new Cart(price,products);
            //_userRepo.UpdateUser(user);
            return true;
        }
    }
}
