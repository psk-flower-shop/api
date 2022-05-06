using System;
using FlowerApi.Entities;
using Microsoft.AspNetCore.Mvc;

namespace FlowerApi.Controllers
{
    [ApiController]
    [Route("api/product")] 
    public class ProductController : Controller
    {
        
        private readonly IProductService _productService;    // TODO DI in program.cs
        
        public ProductController(IProductService service)
        {
            _productService = service;
        }
        
        // /api/product/{id}
        // nzn ar visu getu cia reikia, tai jei ka, istrint
        
        [HttpGet]
        [Route("userId")]
        public ActionResult<Product> GetAllUsersProducts(Guid userId)
        {
            var products = _productService.GetAllProductsByUserId(userId);
            if (products == null)
            {
                return NotFound("No products found");
            }
            return Ok(products);
        }
        
        [HttpGet]
        [Route("{id}")]
        public ActionResult<Product> GetProductById(Guid id)
        {
            if(id == null || id == Guid.Empty)
            {
                return NotFound($"No product with id: {id}");
            }
            Product product = _productService.GetProductById(id);
            if (product == null)
            {
                return NotFound("Product not found");
            }
            return Ok(product);
        }
        
        [HttpGet]
        [Route("{category}")]
        public ActionResult<Product> GetProductsByCategory(string category)
        {
            Product products = _productService.GetAllProductsByCategory(category);
            if (products == null)
            {
                return NotFound($"No products in {category} category.");
            }
            return Ok(products);
        }
        
        [HttpGet]
        [Route("{name}")]
        public ActionResult<Product> GetProductByName(string name)
        {
            Product products = _productService.GetAllProductsByName(name);
            if (products == null)
            {
                return NotFound($"No products by {name} name.");
            }
            return Ok(products);
        }
        
        [HttpPost]
        [Route("add")]
        public ActionResult AddProduct(string email, Product product)
        {
            
            if (!string.IsNullOrEmpty(email) || product == null)
            {
                return BadRequest("user email or product is bad");
            }
            
            _productService.AddProduct(email, product);
            return Ok($"Added {product.Name} to users {email} sellables");
        }
        
        [HttpPut]
        [Route("{id}")]
        public ActionResult<ProductDto> Update(ProductDto newProduct, Guid id)    // TODO import productdto when db done
        {
            var product = _productService.Update(newProduct, id);
            if (product == null)
            {
                return NotFound($"No product with id: {id}");
            }

            return Ok(product);
        }
        
        [HttpDelete]
        [Route("{id}")]
        public ActionResult Delete(Guid id)
        {
            if(id == null || id == Guid.Empty)
            {
                return NotFound($"No product with id: {id}");
            }
            _productService.Remove(id);
            return Ok($"Product with id: {id} deleted");
        }
        
    }
}