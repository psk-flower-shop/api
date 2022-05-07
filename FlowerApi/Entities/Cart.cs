namespace FlowerApi.Entities
{
    public struct PriceType {
        public int Euros;
        public int Cents;
    }
    public class Cart
    {
        public Guid Id { get; set; }
        public PriceType Price  { get; set; }
        public List<Product>? ProductsInCart { get; set; }

        public Cart() { }

        public Cart(Guid ID, PriceType price, List<Product> productsInCart) {
            this.Id = ID;
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
