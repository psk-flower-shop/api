using System;
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
        
        public CartController(ICartService service)
        {
            _cartService = service;
        }
        
        [HttpGet]
        public ActionResult<Cart> GetUserCart(Guid userId)
        {
            throw new NotImplementedException();
        }
        
        [HttpPost]
        [Route("add")]
        public ActionResult AddProduct(Guid userId, Guid productId)
        {
            throw new NotImplementedException();
        }
        
        [HttpDelete]
        public ActionResult DeleteProductFromCart(Guid productId)
        {
            throw new NotImplementedException();
        }
        
    }
}