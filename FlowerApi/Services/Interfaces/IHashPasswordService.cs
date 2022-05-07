using System.Collections.Generic;
using FlowerApi.Entities;

namespace FlowerApi.Services.Interfaces
{

    public interface IHashPasswordService
    {
        string GetRandomSalt();
        string PasswordHash(string password);
        bool ValidatePassword(string password, string correctHash);
        string SaltPasswordHardcoded(string password);
    }

}