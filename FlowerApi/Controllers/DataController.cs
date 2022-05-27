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

		public DataController(IUserRepository userRepository, IProductRepository productRepository)
		{
			_userRepository = userRepository;
			_productRepository = productRepository;

		}

		[HttpPost]
		[Route("add")]
		public ActionResult PopulateDatabase()
        {
			User user = new User() { Email = "test@test.com", Name = "Testas", Password = "Testas", Cart = new Cart() { ProductsInCart = new List<CartItem>() } };
			User user2 = new User() { Email = "test2@test.com", Name = "Testas2", Password = "Testas2", Cart = new Cart() { ProductsInCart = new List<CartItem>() } };

			_userRepository.AddUser(user);
			_userRepository.AddUser(user2);

			Product product = new Product() { Name = "Gele", Price = 20, Amount = 5, Category = "flowers" };
			Product product2 = new Product() { Name = "Papuosalas", Price = 20, Amount = 5, Category = "gifts" };
			Product product3 = new Product() { Name = "Palme", Price = 20, Amount = 5, Category = "plants" };

			_productRepository.AddProduct(product);
			_productRepository.AddProduct(product2);
			_productRepository.AddProduct(product3);

			return Ok();

		}
	}
}

