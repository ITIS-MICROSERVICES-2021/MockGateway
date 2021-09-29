using System;
using System.Threading.Tasks;
using MockGateway.DTOs;
using MockGateway.Interfaces;

namespace MockGateway.Services
{
    public class ExternalUserService : IExternalUserService
    {
        public async Task<ExternalUserDTO> GetExternalUser()
        {
            return new ExternalUserDTO
            {
                Surname = "Иванов",
                Name = "Иван",
                Patronymic = "Иванович",
                Position = "Программист",
                ManagerFullName = "Петров Петр Петрович",
                CompanyFullName = "Предприятие",
                Salary = 30000,
                RecruitmentDate = DateTime.Now
            };
        }
    }
};