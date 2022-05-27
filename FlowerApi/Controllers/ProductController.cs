using System;
using System.Collections.Generic;
using FlowerApi.Entities;
using Microsoft.AspNetCore.Mvc;
using FlowerApi.Services.Interfaces;
using FlowerApi.DTO;
using AutoMapper;

namespace FlowerApi.Controllers
{
    [ApiController]
    [Route("api/product")] 
    public class ProductController : Controller
    {
        
        private readonly IProductService _productService;    // TODO DI in program.cs
        private readonly IMapper _mapper;
        
        public ProductController(IProductService service, IMapper mapper)
        {
            _productService = service;
            _mapper = mapper;
        }
        
        // /api/product/{id}
        // nzn ar visu getu cia reikia, tai jei ka, istrint
        
        [HttpGet]
        public ActionResult<IEnumerable<ProductDTO>> GetProducts()
        {
            return Ok(_mapper.Map<List<ProductDTO>>(this._productService.GetProducts()));
        }
        
        [HttpGet]
        [Route("findById/{id}")]
        public ActionResult<ProductDTO> GetProductById(Guid id)
        {
            var product = _productService.GetProductById(id);
            if (product != null)
            {

                return Ok(_mapper.Map<ProductDTO>(product));
            }

            return NotFound();
        }
        
        [HttpGet]
        [Route("findByCategory/{categoryName}")]
        public ActionResult<List<Product>> GetProductsByCategory(String categoryName)
        {
            var products = _productService.GetProductsByCategory(categoryName);
            if (products != null)
            {
                return Ok(products);
            }
            return NotFound();
        }
        
        [HttpGet]
        [Route("findByName/{name}")]
        public ActionResult<Product> GetProductByName()
        {
            throw new NotImplementedException();
        }
        
        [HttpPost]
        [Route("add")]
        public ActionResult<Product> AddProduct(ProductDTO productDTO)
        {
            Product product = new Product { Name = productDTO.Name, Amount = productDTO.Amount, Price = productDTO.Price };
            _productService.CreateProduct(product);

            return Ok(product);
        }
        
        [HttpPut]
        [Route("{id}")]
        public ActionResult Update(Guid id)    // TODO import productdto when db done
        {
            try
            {
               var product = _productService.UpdateProduct(id);
                return Ok(product);
            }
            catch (Exception) { return NotFound("Failed to update"); }
        }
        
        [HttpDelete]
        [Route("{id}")]
        public ActionResult Delete(Guid id)
        {
            if (_productService.DeleteProduct(id))
                return Ok("Deleted");
            else
                return NotFound("Failed to delete");
        }
        
    }
}