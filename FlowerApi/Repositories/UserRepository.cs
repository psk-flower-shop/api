using System;
using FlowerApi.Data;
using FlowerApi.Entities;
using FlowerApi.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

using System.Data.SqlClient;
using System.Linq;
using System.Transactions;

namespace FlowerApi.Repositories
{
	public class UserRepository : IUserRepository
	{
		FlowersContext _context;
		public UserRepository(FlowersContext context)
		{
			_context = context;

		}

        public bool AddUser(User user)
        {
            user.Cart = new Cart();
            user.Cart.ProductsInCart = new List<CartItem>();
            _context.Users.Add(user);
            _context.SaveChanges();

            return true;
        }

        public bool DeleteUser(User user)
        {
            throw new NotImplementedException();
        }

        public bool AddProductToUserCart(CartItem item, Guid id) {
            _context.Users.Include(x => x.Cart).Include(x => x.Cart.ProductsInCart).ToList().First(x => x.Id == id).Cart.ProductsInCart.Add(item);
            _context.SaveChanges();
            return true;
        
        }

        public bool AddProductToWishlist(Product product, Guid userId)
        {
            _context.Users.Include(x => x.FavoriteProducts).ToList().First(x => x.Id == userId).FavoriteProducts.Add(product);
            _context.SaveChanges();
            return true;
        }

        public List<CartItem> getUsersCartItems(Guid userId) {
           var users = _context.Users.Include(x => x.Cart).Include(x => x.Cart.ProductsInCart).ToList();
            if (users != null)
            {
                return users.FirstOrDefault(x => x.Id == userId).Cart.ProductsInCart;
            }
            return null;
        }

        public User GetUserById(Guid id)
        {

           return _context.Users.Include(x => x.Cart).Include(x => x.Cart.ProductsInCart).ToList().First(us => us.Id == id);
        
        }

        public IEnumerable<User> GetUsers() => _context.Users.Include(x => x.Cart).ToList();

        public void StartOwnTransactionWithinContext(string email)
        {
            using (var context = new FlowersContext())
            {
                using (var dbContextTransaction = context.Database.BeginTransaction())
                {
                    context.Database.ExecuteSqlRaw(
                        @"UPDATE Users SET Name = 'testukas2'" +
                            " WHERE Email LIKE '%" + email + "'"
                        );

                    context.SaveChanges();

                    dbContextTransaction.Commit();
                }
            }
        }

        public List<Product> getWishList(Guid userId)
        {
            return _context.Users.FirstOrDefault(x => x.Id == userId).FavoriteProducts.ToList();
        }
    } 
}

