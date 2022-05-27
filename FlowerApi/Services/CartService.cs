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
        IProductRepository _productRepository;

        public CartService( IUserRepository userRepository, IProductRepository productRepository)
        {
            this._userRepo = userRepository;
            this._productRepository = productRepository;
        }

        public bool AddProductToCart(Guid id, Product product)
        {

            CartItem cartItem = new CartItem()
            {
                Price = product.Price,
                Quantity = 1,
                Product = product

            };
            _userRepo.AddProductToUserCart(cartItem, id);
            return false;
        }

        public bool CreateCart(User user, int cents, int euros, List<Product> products)
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
               // user.Cart?.ProductsInCart?.Remove(product);
                return true;
            }
            catch(NullReferenceException) {
                return false;
            }
            
        }


        public bool UpdateCart(Guid id, decimal price, List<Product> products)
        {
            var user = this._userRepo.GetUserById(id);
           // user.Cart = new Cart(price,products);
            //_userRepo.UpdateUser(user);
            return true;
        }
    }
}
