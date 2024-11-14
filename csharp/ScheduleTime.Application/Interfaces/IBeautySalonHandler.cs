using ScheduleTime.CrossCutting.DTOs.V1;
using ScheduleTime.Domain.Responses;

namespace ScheduleTime.Application.Interfaces
{
    public interface IBeautySalonHandler
    {
        Task<ViewResponse<ScheduleDTO>> ScheduleTime(BeautySalonDTO beautySalonDTO);
    }
}
