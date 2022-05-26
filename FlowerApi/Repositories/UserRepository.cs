using System;
using FlowerApi.Data;
using FlowerApi.Entities;
using FlowerApi.Repositories.Interfaces;

namespace FlowerApi.Repositories
{
	public class UserRepository : IUserRepository
	{
		FlowersContext _context;
		public UserRepository(FlowersContext context)
		{
			_context = context;

		}

        public bool DeleteUser(User user)
        {
            throw new NotImplementedException();
        }

        public User GetUserById(Guid id)
        {
            var user = _context.Users.ToList().FirstOrDefault(us => us.Id == id);
            return user;
        }

        public IEnumerable<User> GetUsers()
        {
            var users = _context.Users.ToList();
            return users;
        }
    }
}

