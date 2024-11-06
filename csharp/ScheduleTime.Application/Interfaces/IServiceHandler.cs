using ScheduleTime.CrossCutting.DTOs;

namespace ScheduleTime.Application.Interfaces
{
    public interface IServiceHandler
    {
        Task ScheduleATimeBarberShopAsync(ScheduleDTO scheduleDTO);
        Task ScheduleATimeBeuatySalonAsync(ScheduleDTO scheduleDTO);
    }
}
