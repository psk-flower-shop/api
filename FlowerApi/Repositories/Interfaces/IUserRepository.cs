using System;
using System.Collections.Generic;
using FlowerApi.Entities;

namespace FlowerApi.Repositories.Interfaces
{
    public interface IUserRepository
    { 
            public IEnumerable<User> GetUsers();
            public User GetUserById(Guid id);
            public bool AddUser(User user);
            public bool AddProductToUserCart(CartItem item, Guid id);
        public bool AddProductToWishlist(Product product, Guid userId);
            public List<CartItem> getUsersCartItems(Guid userId);
            public void StartOwnTransactionWithinContext(string email);

        public List<Product> getWishList(Guid userId);
    }
}
