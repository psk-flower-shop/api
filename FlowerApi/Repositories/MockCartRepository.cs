using FlowerApi.Entities;

namespace FlowerApi.Repositories
{
    public class MockCartRepository
    {
        private readonly List<Cart> carts = new()
        {
            new Cart {Id = Guid.NewGuid(), Price = new PriceType {Euros = 40, Cents = 56}},
            new Cart {Id = Guid.NewGuid(), Price = new PriceType {Euros = 60, Cents = 34}},
            new Cart {Id = Guid.NewGuid(), Price = new PriceType {Euros = 23, Cents = 20}}
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