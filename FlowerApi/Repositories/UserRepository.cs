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

        public User GetUserById(Guid id) => _context.Users.ToList().FirstOrDefault(us => us.Id == id);

        public IEnumerable<User> GetUsers() => _context.Users.ToList();
    }
}

