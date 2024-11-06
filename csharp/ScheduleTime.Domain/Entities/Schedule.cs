using ScheduleTime.Domain.Entities.Enums;

namespace ScheduleTime.Domain.Entities
{
    public class Schedule
    {
        public long Id { get; private set; }
        public DateTime ScheduledTime { get; private set; }
        public Customer Customer { get; private set; } = null!;
        public BarberShop? BarberShop { get; private set; }
        public BeautySalon? BeautySalon { get; private set; }

        private Schedule() { }

        public Schedule(DateTime date, Customer customer, BarberShop? barberShop = null, BeautySalon? beautySalon = null)
        {
            ScheduledTime = date;
            Customer = customer;
            BarberShop = barberShop;
            BeautySalon = beautySalon;
        }
    }
}
