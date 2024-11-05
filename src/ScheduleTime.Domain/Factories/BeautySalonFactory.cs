using ScheduleTime.Domain.Entities;
using ScheduleTime.Domain.Factories.Interfaces;

namespace ScheduleTime.Domain.Factories
{
    internal class BeautySalonFactory : IHairServiceFactory
    {
        public HairService CreateServiceHair(Customer customer, DateTime date)
        {
            return new BeautySalon();
        }
    }
}
