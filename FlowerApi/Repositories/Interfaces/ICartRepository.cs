using System;
using System.Collections.Generic;
using FlowerApi.Entities;

namespace FlowerApi.Repositories
{
    public interface ICartRepository
    {
        public IEnumerable<Cart> GetCarts();

        public Cart GetCartById(Guid id);
    }
}
