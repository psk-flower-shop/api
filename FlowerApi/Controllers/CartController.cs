using System;
using FlowerApi.Entities;
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
            var cart = _cartService.GetUserCart(userId);
            if (cart == null)
            {
                return Ok("Cart is empty");
            }
            return Ok(cart);
        }
        
        [HttpPost]
        [Route("add")]
        public ActionResult AddProduct(Guid userId, Guid productId)
        {
            if(userId == null || userId == Guid.Empty || productId == null || productId == Guid.Empty)
            {
                return NotFound("no such user or product.");
            }
            _cartService.AddProductToCart(productId, userId);
            return Ok($"Added to cart");
        }
        
        [HttpDelete]
        public ActionResult DeleteProductFromCart(Guid productId)
        {
            if(productId == null || productId == Guid.Empty)
            {
                return NotFound($"No product with id: {productId}");
            }
            _cartService.Remove(productId);
            return Ok($"Product with id: {productId} deleted from cart");
        }
        
    }
}