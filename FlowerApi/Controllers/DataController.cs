using System;
using System.Collections.Generic;
using FlowerApi.Entities;
using Microsoft.AspNetCore.Mvc;
using FlowerApi.Services.Interfaces;
using FlowerApi.DTO;
using AutoMapper;
using FlowerApi.Repositories.Interfaces;

namespace FlowerApi.Controllers
{
	[ApiController]
	[Route("api/data")]
	public class DataController : Controller
	{

		private readonly IUserRepository _userRepository;
		private readonly IProductRepository _productRepository;
		private readonly ICategoryRepository _categoryRepository;


		public DataController(IUserRepository userRepository, IProductRepository productRepository, ICategoryRepository categoryRepository)
		{
			_userRepository = userRepository;
			_productRepository = productRepository;
			_categoryRepository = categoryRepository;
		}

		[HttpPost]
		[Route("add")]
		public ActionResult PopulateDatabase()
        {
			User user = new User() { Email = "test@test.com", Name = "Testas", Password = "Testas", Cart = new Cart()};
			User user2 = new User() { Email = "test2@test.com", Name = "Testas2", Password = "Testas2", Cart = new Cart() };

			_userRepository.AddUser(user);
			_userRepository.AddUser(user2);

			Category flowers = new Category() { Name = "flowers" };
			Category gifts = new Category() { Name = "gifts" };
			Category trappings = new Category() { Name = "trappings" };
			Category plants = new Category() { Name = "plants" };

			_categoryRepository.AddCategory(flowers);
			_categoryRepository.AddCategory(gifts);
			_categoryRepository.AddCategory(trappings);
			_categoryRepository.AddCategory(plants);

			Product product = new Product() { Name = "Gele", Price = 20, Amount = 5, Category = flowers };
			Product product2 = new Product() { Name = "Papuosalas", Price = 20, Amount = 5, Category = gifts };
			Product product3 = new Product() { Name = "Palme", Price = 20, Amount = 5, Category = plants };

			return Ok();

		}
	}
}

