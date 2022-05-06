using System;
using System.Collections.Generic;

namespace FlowerApi.Entities
{
    public class User
    {
        public Guid Id { get; set; }
        public string? Name { get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; }
        public List<Product>? FavoriteProducts { get; set; }
        public Cart? Cart { get; set; }

        public User() {
        }

        public User(Guid ID,string name, string email, string password, List<Product> favProducts, Cart cart) {
            this.Id = ID;
            this.Name = name;
            this.Email = email;
            this.Password = password;
            this.FavoriteProducts = favProducts;
            this.Cart = cart;
        }

        public override bool Equals(object? obj)
        {
            if (obj != null && obj.GetType().Equals("User")) {
                User user = obj as User;
                if (Name.Equals(user.Name) && Email.Equals(user.Email)) {
                    return true;
                }
                return false;
            }
            return false;
        }

        public override int GetHashCode()
        {
            return this.Id.GetHashCode();
        }
    }
}