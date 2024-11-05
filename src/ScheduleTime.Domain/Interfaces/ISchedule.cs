namespace ScheduleTime.Domain.Interfaces
{
    public interface ISchedule<T>
    {
        void ScheduleService(T entity);
    }
}
