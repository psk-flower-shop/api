namespace FlowerApi.Entities
{
    public class Product
    {
        public Guid Id { get; set; }
        public PriceType Price { get; set; }
        public int Amount { get; set; }
        public string? Name { get; set; }
        public Category? Category { get; set; }

        public Product() { }

        public Product(Guid ID, PriceType price, int amount, string name, Category category) {
            this.Id = ID;
            this.Price = price;
            this.Amount = amount;
            this.Name = name;
            this.Category = category;
        }

        public override bool Equals(object? obj)
        {
            if (obj != null && obj.GetType().Equals("Product"))
            {
                Product product = obj as Product;
                if (Name.Equals(product.Name) && Category.Equals(product.Category))
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
