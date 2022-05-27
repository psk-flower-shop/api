using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FlowerApi.Entities
{
    public class Product
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        public decimal Price { get; set; }
        public int Amount { get; set; }
        public string? Name { get; set; }
        public string Category { get; set; }
        public List<User> Users { get; set; }

        public Product() { }

        public Product(Guid ID, decimal price, int amount, string name, string category) {
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
