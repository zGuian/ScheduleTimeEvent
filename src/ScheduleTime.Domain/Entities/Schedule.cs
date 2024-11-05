namespace ScheduleTime.Domain.Entities
{
    public class Schedule
    {
        public long Id { get; private set; }
        public DateTime Date { get; private set; }
        public BarberShop? BarberShop { get; private set; }
        public BeautySalon? BeautySalon { get; private set; }
    }
}
