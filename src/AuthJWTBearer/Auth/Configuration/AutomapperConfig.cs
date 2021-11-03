using AutoMapper;

namespace Auth.Configuration
{
    public class AutomapperConfig : Profile
    {
        public AutomapperConfig()
        {
            CreateMap<Domain.Entities.User,Domain.Models.User>();
        }
    }
}
