using ScheduleTime.Domain.Entities;

namespace ScheduleTime.Domain.Factories.Interfaces
{
    public interface IHairServiceFactory
    {
        HairService CreateServiceHair(Customer customer, DateTime date);
    }
}
