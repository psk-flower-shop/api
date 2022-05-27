using System;
using System.Collections.Generic;
using System.Linq;
using FlowerApi.Entities;

namespace FlowerApi.Repositories
{
    public class MockCartRepository : ICartRepository
    {
        private readonly List<Cart> carts = new()
        {
            new Cart {Id = Guid.NewGuid(), Price = 44},
            new Cart {Id = Guid.NewGuid(), Price = 23},
            new Cart {Id = Guid.NewGuid(), Price = 14}
        };

        public IEnumerable<Cart> GetCarts()
        {
            return carts;
        }

        public Cart GetCartById(Guid id)
        {
            return carts.Where(cart => cart.Id == id).SingleOrDefault();
        }
    }
}