using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Microsoft.AspNetCore.Mvc;
using FlowerApi.Entities;
using FlowerApi.Services;
using FlowerApi.Services.Interfaces;
using FlowerApi.Repositories.Interfaces;

namespace FlowerApi.Controllers
{
    [ApiController]
    [Route("api/login")] 
    public class LoginUserController : ControllerBase
    {
        private readonly IUserRepository _userRepository;
        private readonly ILoginService _loginService;

        public LoginUserController(ILoginService loginService, IUserRepository repo)
        {
            _loginService = loginService;
            _userRepository = repo;
        }
        [HttpPost]
        [Route("check")]
        public ActionResult<String> VerifyUser([FromBody] HtmlBody body)
        {

            string email = body.Email;
            string password = body.Password;

            try{
                IEnumerable<User> users = _loginService.GetUsers();
                User goodUser = users.Single(users => users.Email == email);

                if(goodUser == null){
                    throw new KeyNotFoundException();
                }
                User user = new User(new Guid(), "s", email, password, null, null);
                if(_loginService.CheckUserLoginInformation(user, goodUser))
                {
                    string token = Convert.ToBase64String(goodUser.Id.ToByteArray());
                    return Ok(token);
                }
                throw new System.Exception();

            }catch(KeyNotFoundException){
                return NotFound("No existing user");
            }catch(Exception){
                return NotFound("Bad username or password");
            }
        }

        [HttpGet]
        [Route("users")]
        public ActionResult<List<User>> GetUsers()
        {
            return Ok(_userRepository.GetUsers());
        }

        [HttpGet]
        [Route("user")]
        public ActionResult<User> GetUserByToken(string token)
        {
            byte[] data = Convert.FromBase64String(token);
            Guid guid = new Guid(data);

            return Ok(_loginService.GetUserByGuid(guid));
        }
    }
}