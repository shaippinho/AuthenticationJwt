using Auth.Domain.Entities;

namespace Auth.Domain.Interfaces.Services
{
    public interface ITokenService
    {
        public Task<string> GenerateToken(User user);
    }
}
