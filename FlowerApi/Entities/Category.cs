using System;
using System.Collections.Generic;

namespace FlowerApi.Entities
{
    public class Category
    {
        public Guid Id { get; set; }
        public string? Name { get; set; }
        public List<Product>? Products { get; set; }

        public Category() { }

        public Category(Guid ID, string Name, List<Product> Products) {
            Id = ID;
            this.Name = Name;
            this.Products = Products;
        }
        
        public override bool Equals(object? obj)
        {
            if (obj != null && obj.GetType().Equals("Category"))
            {
                Category category = obj as Category;
                if (Name.Equals(category.Name))
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
