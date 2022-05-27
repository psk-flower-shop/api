using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlowerApi.Services.Interfaces;
using FlowerApi.Entities;


namespace FlowerApi.Services
{
    public class LoginService : ILoginService
    {
        private readonly IHashPasswordService _hashPasswordService;

        private List<User> users = new List<User>();    // TODO get users from db

        public LoginService(IHashPasswordService hashPasswordService)
        {
            _hashPasswordService = hashPasswordService;
        }

        public bool CheckUserLoginInformation(User tryUser, User loginUser)
        {

            if (!String.IsNullOrEmpty(loginUser.Email) && _hashPasswordService.ValidatePassword(_hashPasswordService.SaltPasswordHardcoded(tryUser.Password), loginUser.Password))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void AddUser(User user)
        {
            users.Add(user); // adds a seller to a list from Register class, TODO: when DB is all set and running, change so it adds to the DB, and not the list
        }
        public IEnumerable<User> GetUsers()
        {
            return users;
        }
    }
}