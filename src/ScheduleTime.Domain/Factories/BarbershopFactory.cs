using ScheduleTime.Domain.Entities;
using ScheduleTime.Domain.Factories.Interfaces;

namespace ScheduleTime.Domain.Factories
{
    public class BarbershopFactory : IHairServiceFactory
    {
        public HairService CreateServiceHair(Customer customer, DateTime date)
        {
            return new BarberShop(customer, date);
        }
    }
}
