using Auth.Domain.Entities;

namespace Auth.Domain.Interfaces.Repositories
{
    public interface IUserRepository
    {
        public Task<User> Get(string username, string password);
    }
}
