using System;
using System.Collections.Generic;
using FlowerApi.Entities;

namespace FlowerApi.Repositories.Interfaces
{
    public interface ICategoryRepository
    {
        public IEnumerable<Category> GetCategories();

        public Category GetCategoryById(Guid id);
    }
}
