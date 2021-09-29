using MediatR;

namespace MockGateway.Application.Features.GetExternalUserInfo
{
    public class GetExternalUserInfoQuery : IRequest<ExternalUserDto>
    {
    }
}