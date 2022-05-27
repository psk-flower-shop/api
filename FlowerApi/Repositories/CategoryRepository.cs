using System;
using FlowerApi.Entities;
using FlowerApi.Repositories.Interfaces;
using FlowerApi.Data;
using FlowerApi.DTO;

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

        public void AddCategory(Category categoryModel)
        {
            _context.Categories.Add(categoryModel);
            _context.SaveChanges();
        }

        public void UpdateCategory(Guid id, CategoryDTO model)
        {
            //var category = _context.Categories.ToList().FirstOrDefault(x => x.Id == id);
            throw new NotImplementedException();

        }

        public void DeleteCategory(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
