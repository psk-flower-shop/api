using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using FlowerApi.Services.Interfaces;
using FlowerApi.Entities;


namespace FlowerApi.Services
{
    public class RegisterService : IRegisterService
    {
        private readonly IHashPasswordService _hashPasswordService;
        private readonly ILoginService _loginService;

        public RegisterService(ILoginService loginService, IHashPasswordService hashPasswordService)
        {
            _loginService = loginService;
            _hashPasswordService = hashPasswordService;
        }

        public void RegisterUser(User user)
        {

            string email = user.Email;
            Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            Match match = regex.Match(email);
            if (!match.Success)
            {
                throw new Exception();
            }

            IEnumerable<User> users = _loginService.GetUsers();
            if (users.Any(users => users.Email == user.Email))
            {
                throw new DuplicateNameException();
            }                                                        // when user is registering, hashes password with 
                                                                     //hardcoded salt(line xx) and auto salts(line xx)
            string hashedPassword = _hashPasswordService.PasswordHash(_hashPasswordService.SaltPasswordHardcoded(user.Password));
            user.Password = hashedPassword;

            _loginService.AddUser(user);
        }
    }
}