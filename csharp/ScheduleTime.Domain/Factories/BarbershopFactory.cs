using ScheduleTime.Domain.Entities;
using ScheduleTime.Domain.Factories.Interfaces;

namespace ScheduleTime.Domain.Factories
{
    public class BarbershopFactory : IScheduleFactory
    {
        public Schedule CreateSchedule(DateTime date, Customer customer)
        {
            var barberShop = new BarberShop(customer, date);
            return new Schedule(date, customer, barberShop, null);
        }
    }
}
