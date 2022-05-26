using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using FlowerApi.Entities;

namespace FlowerApi.Services.Interfaces
{
    public interface ICartService
    {
        public Task<bool> CreateCart(User user,int cents, int euros, List<Product> products);
        public bool DeleteCart(User user);
        public Cart FindCart(Guid id);
        public bool UpdateCart(Guid id, PriceType price, List<Product> products);
        public Task<bool> AddProductToCart(Guid id, Product product);
        public bool RemoveProductFromCart(Guid id, Product product);

    }
}
