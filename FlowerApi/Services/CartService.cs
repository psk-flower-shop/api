using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using FlowerApi.Entities;
using FlowerApi.Services.Interfaces;

namespace FlowerApi.Services
{
    public class CartService : ICartService
    {

        public CartService()
        {
        }

        public Task<bool> AddCart(User user, Cart cart)
        {
            throw new NotImplementedException();
        }

        public Task<bool> AddProductToCart(int id, Product product)
        {
            throw new NotImplementedException();
        }

        public Task<bool> CreateCart(User user, int cents, int euros, List<Product> products)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteCart(User user, int id)
        {
            throw new NotImplementedException();
        }

        public Task<Cart> FindCart(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> RemoveProductFromCart(int id, Product product)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateCart(int id, PriceType price, List<Product> products)
        {
            throw new NotImplementedException();
        }
    }
}
