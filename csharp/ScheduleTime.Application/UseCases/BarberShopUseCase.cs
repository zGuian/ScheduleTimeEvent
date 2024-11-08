using ScheduleTime.Application.Interfaces;
using ScheduleTime.Application.UseCases.Interfaces;
using ScheduleTime.CrossCutting.DTOs.V1;
using ScheduleTime.Domain.Entities;

namespace ScheduleTime.Application.UseCases
{
    public class BarberShopUseCase : IBaseUseCase<BarberShop, BarberShopDTO>, IBarberShopUseCase
    {
        public Task<BarberShop> ValidDataAndConvertDTOInEntity(BarberShopDTO dto)
        {
            throw new NotImplementedException();
        }
    }
}
