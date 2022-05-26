using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FlowerApi.Entities
{
    public class Category
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        public string? Name { get; set; }

        public List<Product> Products { get; set; }

        public Category() { }

        public Category(Guid ID, string Name) {
            Id = ID;
            this.Name = Name;
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
