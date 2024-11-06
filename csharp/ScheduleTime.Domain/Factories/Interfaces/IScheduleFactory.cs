using ScheduleTime.Domain.Entities;

namespace ScheduleTime.Domain.Factories.Interfaces
{
    public interface IScheduleFactory
    {
        Schedule CreateSchedule(DateTime date, Customer customer);
    }
}
