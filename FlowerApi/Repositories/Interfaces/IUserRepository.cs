using System;
using System.Collections.Generic;
using FlowerApi.Entities;

namespace FlowerApi.Repositories.Interfaces
{
    public interface IUserRepository
    { 
            public IEnumerable<User> GetUsers();
            public User GetUserById(Guid id);
            public bool AddUser(User user);
        
    }
}
