namespace ScheduleTime.Application.Handlers.Interfaces
{
    public interface IBaseHandler<T> where T : class
    {
        public abstract Task ScheduleTime(T entity);
    }
}
