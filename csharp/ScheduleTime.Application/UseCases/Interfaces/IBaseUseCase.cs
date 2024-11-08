namespace ScheduleTime.Application.UseCases.Interfaces
{
    public interface IBaseUseCase<T, U> where T : class
        where U : class
    {
        abstract Task<T> ValidDataAndConvertDTOInEntity(U dto);
    }
}
