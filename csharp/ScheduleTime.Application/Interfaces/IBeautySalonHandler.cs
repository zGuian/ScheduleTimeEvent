using ScheduleTime.CrossCutting.DTOs.V1;

namespace ScheduleTime.Application.Interfaces
{
    public interface IBeautySalonHandler
    {
        Task ScheduleTime(BeautySalonDTO beautySalonDTO);
    }
}
