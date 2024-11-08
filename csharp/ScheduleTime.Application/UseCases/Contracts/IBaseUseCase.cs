namespace ScheduleTime.Application.UseCases.Contracts
{
    public interface IBaseUseCase<T, U> where T : class
        where U : class
    {
        abstract T ValidDataAndConvertDTOInEntity(U dto);
    }
}
