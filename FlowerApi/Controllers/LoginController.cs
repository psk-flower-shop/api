using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Microsoft.AspNetCore.Mvc;
using FlowerApi.Entities;
using FlowerApi.Services;
using FlowerApi.Services.Interfaces;

namespace FlowerApi.Controllers
{
    [ApiController]
    [Route("api/login")] 
    public class LoginUserController : ControllerBase
    {
        private readonly ILoginService _loginService;

        public LoginUserController(ILoginService loginService)
        {
            _loginService = loginService;
        }
        [HttpPost]
        [Route("check")]
        public ActionResult<User> VerifyUser(User user)
        {
            try{
                IEnumerable<User> users = _loginService.GetUsers();
                User goodUser = users.Single(users => users.Email == user.Email);

                if(goodUser == null){
                    throw new KeyNotFoundException();
                }
                
                if(_loginService.CheckUserLoginInformation(user, goodUser))
                {
                    return Ok(goodUser);
                }
                throw new System.Exception();

            }catch(KeyNotFoundException){
                return NotFound("No existing user");
            }catch(Exception){
                return NotFound("Bad username or password");
            }
        }
    }
}