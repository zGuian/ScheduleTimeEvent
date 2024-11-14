using System.Text.Json.Serialization;

namespace ScheduleTime.Domain.Responses;

public class ViewResponse<T>
{
    [JsonPropertyOrder(1)]
    public int TotalCount { get; private set; }
    
    [JsonPropertyOrder(2)]
    public string? Message { get; private set; }
    
    [JsonPropertyOrder(3)]
    public T Obj { get; init; }
    
    [JsonIgnore] 
    public bool IsValid { get; private set; }

    private ViewResponse()
    {
        if (Obj == null) throw new ArgumentNullException(nameof(Obj));
    }

    [JsonConstructor]
    public ViewResponse(bool isValid, T obj, int totalCount = 1, string? message = null)
    {
        IsValid = isValid;
        TotalCount = totalCount;
        Message = isValid switch
        {
            false => "HORARIO_VAGO!",
            true => "AGENDAMENTO_OK"
        };
        Obj = obj;
    }
}