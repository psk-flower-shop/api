using FlowerApi.Entities;

namespace FlowerApi.Repositories
{
    public class MockUserRepository
    {
        private readonly List<User> users = new()
        {
            new User { Id = Guid.NewGuid(), Name = "John", Email = "john@gmail.com", Password = "password"},
            new User { Id = Guid.NewGuid(), Name = "Mark", Email = "mark@gmail.com", Password = "mark123"},
            new User { Id = Guid.NewGuid(), Name = "Chris", Email = "chris@gmail.com", Password = "chris123"}
        };

        public IEnumerable<User> GetUsers()
        {
            return users;
        }

        public User GetUserById(Guid id)
        {
            return users.Where(user => user.Id == id).SingleOrDefault();
        }
    }
}