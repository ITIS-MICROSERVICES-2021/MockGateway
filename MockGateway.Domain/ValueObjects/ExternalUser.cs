using System;

namespace MockGateway.Domain.ValueObjects
{
    public record ExternalUser
    {
        public string Surname { get; init; }
        public string Name { get; init; }
        public string Patronymic { get; init; }
        public string Position { get; init; }
        public string ManagerFullName { get; init; }
        public long Salary { get; init; }
        public DateTime RecruitmentDate { get; init; }
    }
}