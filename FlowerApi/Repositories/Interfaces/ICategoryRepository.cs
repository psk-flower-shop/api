using System;
using System.Collections.Generic;
using FlowerApi.Entities;
using FlowerApi.DTO;

namespace FlowerApi.Repositories.Interfaces
{
    public interface ICategoryRepository
    {
        public IEnumerable<Category> GetCategories();

        public Category GetCategoryById(Guid id);

        public void AddCategory(Category categoryModel);

        public void UpdateCategory(Guid id, CategoryDTO model);

        public void DeleteCategory(Guid id);
    }
}
