using ScheduleTime.Application.Handlers.Interfaces;
using ScheduleTime.Domain.Entities;
using ScheduleTime.Domain.Factories.Interfaces;

namespace ScheduleTime.Application.Handlers
{
    public class BarberShopHandler : IBarberShopHandler
    {
        private readonly IScheduleFactory _factory;

        public BarberShopHandler(IScheduleFactory factory)
        {
            _factory = factory;
        }

        public Task ScheduleTime(Schedule schedule, Customer customer)
        {
            var newSchedule = _factory.CreateSchedule(schedule.ScheduledTime, customer);


            throw new NotImplementedException();
        }
    }
}
