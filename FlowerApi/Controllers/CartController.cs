using System;
using AutoMapper;
using FlowerApi.DTO;
using FlowerApi.Entities;
using FlowerApi.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace FlowerApi.Controllers
{

    

    [ApiController]
    [Route("api/cart")] 
    public class CartController : Controller
    {
        private readonly ICartService _cartService;    // TODO DI in program.cs
        private readonly IUserService _userService;
        private readonly IProductService _productService;
        private readonly IMapper _mapper;
        
        public CartController(ICartService service, IUserService userservice, IProductService productservice, IMapper mapper)
        {
            _cartService = service;
            _userService = userservice;
            _productService = productservice;
            _mapper = mapper;
        }
        
        [HttpGet]
        public ActionResult<Cart> GetUserCart(Guid userId)
        {
            throw new NotImplementedException();
        }
        
        [HttpPost]
        [Route("add/{userId}/{productId}")]
        public ActionResult<User> AddProduct(Guid userId,Guid productId)
        {
            var user = _userService.GetUserById(userId);
            var product = _productService.GetProductById(productId);
            if (user != null && product != null)
            {
                _cartService.AddProductToCart(user.Id, product);
                return Ok(_mapper.Map<UserDTO>(user));
            }
            return NotFound();
        }
        
        [HttpDelete]
        public ActionResult DeleteProductFromCart(Guid productId)
        {
            throw new NotImplementedException();
        }
        
    }
}