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
        public ActionResult<IEnumerable<Product>> GetProducts()
        {
            return Ok(this._productService.GetProducts());
        }
        
        [HttpGet]
        [Route("findById/{id}")]
        public ActionResult<Product> GetProductById(Guid id)
        {
            var product = _productService.GetProductById(id);
            if (product != null)
            {
                return Ok(product);
            }

            return NotFound();
        }
        
        [HttpGet]
        [Route("findByCatgory/{category}")]
        public ActionResult<Product> GetProductsByCategory()
        {
            throw new NotImplementedException();
        }
        
        [HttpGet]
        [Route("findByName/{name}")]
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