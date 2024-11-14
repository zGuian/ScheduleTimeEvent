using ScheduleTime.Application.Interfaces;
using ScheduleTime.Application.Services.Contracts;
using ScheduleTime.Domain.Entities;

namespace ScheduleTime.Application.Services
{
    public class BarberShopService : IBaseService<BarberShop>, IBarberShopService
    {
        public Task<BarberShop> VerifyAvailability(BarberShop entity)
        {
            throw new NotImplementedException();
        }
    }
}
