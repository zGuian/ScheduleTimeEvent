using ScheduleTime.Domain.Entities;
using ScheduleTime.Domain.Factories.Interfaces;

namespace ScheduleTime.Domain.Factories
{
    public class BeautySalonFactory : IScheduleFactory
    {
        public Schedule CreateSchedule(DateTime date, Customer customer)
        {
            var beautySalon = new BeautySalon();
            return new Schedule(date, customer, null, beautySalon);
        }
    }
}
