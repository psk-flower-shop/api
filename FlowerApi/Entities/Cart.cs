using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FlowerApi.Entities
{

    public class Cart
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        public decimal Price  { get; set; }
        public List<CartItem>? ProductsInCart { get; set; }

        public Guid UserId { get; set; }

        public Cart() { }

        public Cart(decimal price, List<CartItem> productsInCart) {
            this.Price = price;
            this.ProductsInCart = productsInCart;
        }

        public override bool Equals(object? obj)
        {
            if (obj != null && obj.GetType().Equals("Cart"))
            {
                Cart cart = obj as Cart;
                if (Id.Equals(cart.Id))
                {
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
