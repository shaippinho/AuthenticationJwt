namespace Auth.Domain.Interfaces.Services
{
    public interface IAuthenticationService
    {
        public Task<string> Authentication(string userName, string password);
    }
}
