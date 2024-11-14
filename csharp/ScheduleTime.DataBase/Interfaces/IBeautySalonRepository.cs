using ScheduleTime.Domain.Entities;
using ScheduleTime.Domain.Responses;

namespace ScheduleTime.DataBase.Interfaces
{
    public interface IBeautySalonRepository
    {
        Task<ObjectResponse<Schedule>> CheckIfTimeIsAvailableAsync(DateTime dateTime);
    }
}
