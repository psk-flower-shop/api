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
    [Route("api/user")]
    public class UserController : Controller
    {

        private readonly IUserService _userService;
        private readonly IMapper _mapper;

        public UserController(IUserService service, IMapper mapper)
        {
            _mapper = mapper;
            _userService = service;
        }

        // /api/product/{id}
        // nzn ar visu getu cia reikia, tai jei ka, istrint

        [HttpGet]
        public ActionResult<IEnumerable<User>> GetUsers()
        {
            return Ok(this._userService.GetUsers());
        }

        [HttpGet]
        [Route("findById/{id}")]
        public ActionResult<User> GetProductById(Guid id)
        {
            var user = _userService.GetUserById(id);
            if (user != null)
            {
                return Ok(user);
            }

            return NotFound();
        }

        [HttpGet]
        [Route("cart/{id}")]
        public ActionResult<List<CartItemDTO>> GetUserCartItemsList(Guid id)
        {
            var items = _userService.getUsersCartItems(id);
            if (items != null) {
                var dtos = _mapper.Map<List<CartItemDTO>>(items);
                return Ok(dtos);
            }

            return NotFound("something went wrong");
        }

        [HttpPost]
        [Route("add")]
        public ActionResult AddUser()
        {
            throw new NotImplementedException();
        }

        [HttpPost]
        [Route("favorite/{userId}/{productId}")]
        public ActionResult AddProductToWishlist(Guid userId, Guid productId)
        {
            if(_userService.AddProductToWishlist(userId, productId))
            {
                return Ok("Product added to wishlist successfully");
            }

            return Ok("Something went wrong");
        }

        [HttpGet]
        [Route("favourite/{userid}")]
        public ActionResult<List<Product>> GetWishList(Guid userid) {
            
            return Ok(_userService.GetWishList(userid));
        }

        [HttpPut]
        [Route("{id}")]
        public ActionResult UpdateUser()    // TODO import productdto when db done
        {
            throw new NotImplementedException();
        }

        [HttpDelete]
        [Route("{id}")]
        public ActionResult DeleteUser(Guid id)
        {
            throw new NotImplementedException();
        }

    }
}