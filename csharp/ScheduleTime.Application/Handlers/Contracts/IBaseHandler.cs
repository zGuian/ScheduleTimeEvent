namespace ScheduleTime.Application.Handlers.Contracts
{
    public interface IBaseHandler<T> where T : class
    {
        public abstract Task ScheduleTime(T entity);
    }
}
