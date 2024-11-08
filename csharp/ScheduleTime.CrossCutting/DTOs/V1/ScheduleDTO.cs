namespace ScheduleTime.CrossCutting.DTOs.V1
{
    public record ScheduleDTO
    {
        public long Id { get; private set; }
        public DateTime ScheduledTime { get; private set; }
        public CustomerDTO Customer { get; private set; } = null!;
        public BarberShopDTO? BarberShop { get; private set; }
        public BeautySalonDTO? BeautySalon { get; private set; }
    }
}
