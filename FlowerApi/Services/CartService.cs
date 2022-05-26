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
                user.Cart = CalculateNewCartPrice(user.Cart, product.Price);
                return true;
            }
            catch(NullReferenceException) {
                return false;
            }
            
        }

        public Cart CalculateNewCartPrice(Cart cart,PriceType price) {
            int euros = cart.Price.Euros;
            int cents = cart.Price.Cents;
            euros -= price.Euros;
            cents -= price.Cents;
            if (cents < 0) {
                euros--;
                cents = 100 - cents;
            }
            cart.Price = new PriceType() { Euros = euros, Cents = cents };
            return cart;
        }

        public bool UpdateCart(Guid id, PriceType price, List<Product> products)
        {
            var user = this._userRepo.GetUserById(id);
            user.Cart = new Cart(price,products);
            //_userRepo.UpdateUser(user);
            return true;
        }
    }
}
