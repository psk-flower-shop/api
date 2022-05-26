using System;
using System.Collections.Generic;
using System.Linq;
using FlowerApi.Entities;
using FlowerApi.Repositories.Interfaces;

namespace FlowerApi.Repositories
{
    public class MockCategoryRepository : ICategoryRepository
    {
        private readonly List<Category> categories = new()
        {
            new Category {Id = Guid.NewGuid(), Name = "Rozes"},
            new Category {Id = Guid.NewGuid(), Name = "Tulpes"},
            new Category {Id = Guid.NewGuid(), Name = "Juodos orchidejos"}
        };

        public IEnumerable<Category> GetCategories()
        {
            return categories;
        }

        public Category GetCategoryById(Guid id)
        {
            return categories.Where(category => category.Id == id).SingleOrDefault();
        }
    }
}