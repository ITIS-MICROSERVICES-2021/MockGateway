using AutoMapper;
using MockGateway.Application.Features.GetExternalUserInfo;
using MockGateway.Domain.ValueObjects;

namespace MockGateway.Application
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<ExternalUser, ExternalUserDto>();
        }
    }
}