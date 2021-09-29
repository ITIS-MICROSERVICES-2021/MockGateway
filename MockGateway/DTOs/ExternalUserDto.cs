using System;

namespace MockGateway.DTOs
{
    public record ExternalUserDto
    {
        public string Surname { get; init; }
        public string Name { get; init; }
        public string Patronymic { get; init; }
        public string Position { get; init; }
        public string ManagerFullName { get; init; }
        public string CompanyFullName { get; init; }
        public long Salary { get; init; }
        public DateTime RecruitmentDate { get; init; }
    }
}