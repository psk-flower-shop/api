using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using FlowerApi.Entities;

namespace FlowerApi.Services.Interfaces
{
    public interface ICartService
    {
        public Task<bool> AddCart(User user,Cart cart);
        public Task<bool> CreateCart(User user,int cents, int euros, List<Product> products);
        public Task<bool> DeleteCart(User user,int id);
        public Task<Cart> FindCart(Guid id);
        public Task<bool> UpdateCart(int id, PriceType price, List<Product> products);
        public Task<bool> AddProductToCart(int id, Product product);
        public Task<bool> RemoveProductFromCart(int id, Product product);

    }
}
