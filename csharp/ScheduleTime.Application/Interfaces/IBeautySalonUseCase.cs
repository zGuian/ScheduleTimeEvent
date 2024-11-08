using ScheduleTime.CrossCutting.DTOs.V1;
using ScheduleTime.Domain.Entities;

namespace ScheduleTime.Application.Interfaces
{
    public interface IBeautySalonUseCase
    {
        BeautySalon ValidDataAndConvertDTOInEntity(BeautySalonDTO beautySalonDTO);
    }
}
