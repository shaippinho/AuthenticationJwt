using Auth.Domain.Interfaces.Repositories;
using Auth.Domain.Interfaces.Services;
using AutoMapper;

namespace Auth.Domain.Services
{
    public class AuthenticationService: IAuthenticationService
    {
        private readonly IUserRepository _userRepository;
        private readonly IMapper _mapper;
        private readonly ITokenService _tokenService;

        public AuthenticationService(IUserRepository userRepository,
            IMapper mapper,
            ITokenService tokenService)
        {
            _userRepository = userRepository;
            _mapper = mapper;
            _tokenService = tokenService;
        }
        public async Task<string?> Authentication(string userName, string password)
        {
            var user = await _userRepository.Get(userName, password);
            if(user == null)
                return null;

            return await _tokenService.GenerateToken(user);

            //var userModel = _mapper.Map<Entities.User, Models.User>(user);
        }
    }
}
