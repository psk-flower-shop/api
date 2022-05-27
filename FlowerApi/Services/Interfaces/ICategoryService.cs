using System;
using FlowerApi.DTO;
using FlowerApi.Entities;

namespace FlowerApi.Services.Interfaces
{
	public interface ICategoryService
	{
		IEnumerable<Category> GetCategories();
		Category GetCategoryById(Guid id);
		void AddCategory(Category categoryModel);
		Task<Category> DeleteCategory();
		Task<Category> UpdateCategory();
	}
}

