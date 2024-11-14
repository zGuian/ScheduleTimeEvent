namespace ScheduleTime.Domain.Responses;

public class ObjectResponse<T> where T : class
{
    public T Obj { get; private set; }
    public bool IsValid { get; private set; }
    
    public ObjectResponse(bool isValid, T obj )
    {
        Obj = obj;
        IsValid = isValid;
    }
}