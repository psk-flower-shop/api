using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FlowerApi.Entities;
using FlowerApi.Services;
using FlowerApi.Services.Interfaces;

namespace FlowerApi.Controllers
{
    [ApiController]
    [Route("api/register")] 
    public class RegisterUserController : ControllerBase
    {
        private readonly IRegisterService _registerService;
        private readonly ILoginService _loginService;

        public RegisterUserController(IRegisterService registerService, ILoginService loginService)
        {
            _loginService = loginService;
            _registerService = registerService;
        }
        
        [HttpPost]
        [Route("add")]
        public ActionResult<IEnumerable<User>> RegisterUser(User user)
        {
            try
            {
                if (user == null)
                {
                    throw new Exception();
                }
                _registerService.RegisterUser(user);
                return Ok(_loginService.GetUsers());
            }
            catch(DuplicateNameException)
            {
                return Problem("User email already in use!");
            }
            catch (Exception)
            {
                return Problem("Registration failed");
            }
        }
    }
}