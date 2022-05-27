using System;
using FlowerApi.Entities;
using FlowerApi.Services.Interfaces;
using FlowerApi.Repositories.Interfaces;

namespace FlowerApi.Services
{
	public class CategoryService : ICategoryService
	{
        private readonly ICategoryRepository _categoryRepository;

		public CategoryService(ICategoryRepository repository)
		{
            this._categoryRepository = repository;
		}

        public Task<Category> CreateCategory()
        {
            throw new NotImplementedException();
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

