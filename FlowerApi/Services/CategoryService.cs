using System;
using FlowerApi.Entities;
using FlowerApi.Services.Interfaces;
using FlowerApi.Repositories.Interfaces;
using FlowerApi.DTO;

namespace FlowerApi.Services
{
	public class CategoryService : ICategoryService
	{
        private readonly ICategoryRepository _categoryRepository;

		public CategoryService(ICategoryRepository repository)
		{
            this._categoryRepository = repository;
		}

        public void AddCategory(Category categoryModel)
        {
            _categoryRepository.AddCategory(categoryModel);
        }

        public Task<Category> DeleteCategory()
        {
            throw new NotImplementedException();
        }

        public Task<Category> UpdateCategory()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Category> GetCategories()
        {
            return _categoryRepository.GetCategories();
        }

        public Category GetCategoryById(Guid id)
        {
            return _categoryRepository.GetCategoryById(id);
        }
    }
}

