using Auth.Data.Repositories;
using Auth.Domain.Interfaces.Repositories;
using Auth.Domain.Interfaces.Services;
using Auth.Domain.Services;

namespace Auth.Configuration
{
    public static class DependencyInjectionConfig
    {
        public static void RegisterServices(this IServiceCollection services)
        {
            //- Repositories
            services.AddSingleton<IUserRepository, UserRepository>();
            //- Services
            services.AddSingleton<IAuthenticationService, AuthenticationService>();
            services.AddSingleton<ITokenService, TokenService>();
        }
    }
}
