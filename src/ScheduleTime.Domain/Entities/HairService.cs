namespace ScheduleTime.Domain.Entities
{
    public abstract class HairService
    {
        public long Id { get; set; }
        public Customer Customer { get; set; } = null!;
        public bool Painting { get; set; }
        public string? Color { get; set; }
        public bool AnotherService { get; set; }
        public string? AnotherServiceText { get; set; }
        public DateTime CurrentDay { get; set; }
    }
}
