using System;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using MediatR;
using MockGateway.Domain.ValueObjects;

namespace MockGateway.Application.Features.GetExternalUserInfo
{
    public class GetExternalUserInfoQueryHandler : IRequestHandler<GetExternalUserInfoQuery, ExternalUserDto>
    {
        private IMapper Mapper { get; }

        public GetExternalUserInfoQueryHandler(IMapper mapper)
        {
            Mapper = mapper;
        }

        public async Task<ExternalUserDto> Handle(GetExternalUserInfoQuery request, CancellationToken cancellationToken)
        {
            var externalUser = new ExternalUser
            {
                Surname = "Ivanov",
                Name = "Ivan",
                Patronymic = "Ivanovich",
                Position = "Software Engineer",
                ManagerFullName = "Petrov Petr Petrovich",
                Salary = 30000,
                RecruitmentDate = new DateTime(2021, 9, 29)
            };
            return Mapper.Map<ExternalUser, ExternalUserDto>(externalUser);
        }
    }
}