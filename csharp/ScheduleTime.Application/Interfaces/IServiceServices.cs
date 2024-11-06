using ScheduleTime.Domain.Entities;

namespace ScheduleTime.Application.Interfaces
{
    public interface IServiceServices
    {
        Task RegisterScheduleInDbAsync(Schedule schedule);
    }
}
