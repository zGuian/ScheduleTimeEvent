using ScheduleTime.Domain.Entities;

namespace ScheduleTime.Application.Handlers.Interfaces
{
    public interface IBarberShopHandler
    {
        Task ScheduleTime(Schedule schedule, Customer customer);
    }
}
