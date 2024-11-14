using ScheduleTime.CrossCutting.DTOs.V1;
using ScheduleTime.Domain.Entities;
using ScheduleTime.Domain.Responses;

namespace ScheduleTime.Application.Interfaces
{
    public interface IBeautySalonService
    {
        Task<ObjectResponse<Schedule>> VerifyAvailability(BeautySalon beautySalon);
    }
}
