﻿using System;
using System.Collections.Generic;
using FlowerApi.Entities;
using Microsoft.AspNetCore.Mvc;
using FlowerApi.Services.Interfaces;
using FlowerApi.DTO;
using AutoMapper;

namespace FlowerApi.Controllers
{
    [ApiController]
    [Route("api/category")]
    public class CategoryController : Controller
    {

        private readonly ICategoryService _categoryService;
        private readonly IMapper _mapper;

        public CategoryController(ICategoryService service)
        {
            _categoryService = service;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Category>> GetCategories()
        {
            return Ok(this._categoryService.GetCategories());
        }

        [HttpGet]
        [Route("findById/{id}")]
        public ActionResult<Category> GetCategoryById(Guid id)
        {
            var category = _categoryService.GetCategoryById(id);
            if (category != null)
            {
                return Ok(category);
            }

            return NotFound();
        }

        [HttpPost]
        [Route("add")]
        public ActionResult<Category> AddCategory(CategoryDTO categoryCreateDTO)
        {
            Category category = new Category { Name = categoryCreateDTO.Name };

            _categoryService.AddCategory(category);

            return Ok(category);
        }

        [HttpPut]
        [Route("{id}")]
        public ActionResult UpdateCategory()    // TODO import productdto when db done
        {
            throw new NotImplementedException();
        }

        [HttpDelete]
        [Route("{id}")]
        public ActionResult DeleteCategory(Guid id)
        {
            throw new NotImplementedException();
        }

    }
}