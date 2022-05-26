using System;
using System.Collections.Generic;
using FlowerApi.Entities;
using Microsoft.AspNetCore.Mvc;
using FlowerApi.Services.Interfaces;

namespace FlowerApi.Controllers
{
    [ApiController]
    [Route("api/user")]
    public class UserController : Controller
    {

        private readonly IUserService _userService;    // TODO DI in program.cs

        public UserController(IUserService service)
        {
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

        [HttpPost]
        [Route("add")]
        public ActionResult AddUser()
        {
            throw new NotImplementedException();
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