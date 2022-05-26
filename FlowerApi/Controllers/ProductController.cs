using System;
using System.Collections.Generic;
using FlowerApi.Entities;
using Microsoft.AspNetCore.Mvc;
using FlowerApi.Services.Interfaces;

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
        public ActionResult<IEnumerable<Product>> GetAllProducts(Guid userId)
        {
            throw new NotImplementedException();
        }
        
        [HttpGet]
        [Route("{id}")]
        public ActionResult<Product> GetProductById()
        {
            throw new NotImplementedException();
        }
        
        [HttpGet]
        [Route("{category}")]
        public ActionResult<Product> GetProductsByCategory()
        {
            throw new NotImplementedException();
        }
        
        [HttpGet]
        [Route("{name}")]
        public ActionResult<Product> GetProductByName()
        {
            throw new NotImplementedException();
        }
        
        [HttpPost]
        [Route("add")]
        public ActionResult AddProduct()
        {
            throw new NotImplementedException();
        }
        
        [HttpPut]
        [Route("{id}")]
        public ActionResult Update()    // TODO import productdto when db done
        {
            throw new NotImplementedException();
        }
        
        [HttpDelete]
        [Route("{id}")]
        public ActionResult Delete(Guid id)
        {
            throw new NotImplementedException();
        }
        
    }
}