using System;
using FlowerApi.Entities;
using FlowerApi.Repositories.Interfaces;
using FlowerApi.Data;

namespace FlowerApi.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {

        private FlowersContext _context;

        public CategoryRepository(FlowersContext context)
        {
            this._context = context;
        }

        public Category GetCategoryById(Guid id) => _context.Categories.ToList().FirstOrDefault(x => x.Id == id);

        public IEnumerable<Category> GetCategories() => _context.Categories.ToList();
    }
}
