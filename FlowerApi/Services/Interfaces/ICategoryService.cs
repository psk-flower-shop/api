using System;
using FlowerApi.Entities;

namespace FlowerApi.Services.Interfaces
{
	public interface ICategoryService
	{
		IEnumerable<Category> GetCategories();
		Category GetCategoryById(Guid id);
		Task<Category> CreateCategory();
		Task<Category> DeleteCategory();
		Task<Category> UpdateCategory();
	}
}

