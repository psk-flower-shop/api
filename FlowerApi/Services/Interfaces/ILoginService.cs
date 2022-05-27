using System.Collections.Generic;
using System.Threading.Tasks;
using FlowerApi.Entities;


namespace FlowerApi.Services.Interfaces
{
    public interface ILoginService
    {
        bool CheckUserLoginInformation(User tryUser, User loginUser);
        void AddUser(User user);
        IEnumerable<User> GetUsers();
    }

}