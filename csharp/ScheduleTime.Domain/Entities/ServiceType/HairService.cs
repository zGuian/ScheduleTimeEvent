namespace ScheduleTime.Domain.Entities.ServiceType
{
    public abstract class HairService
    {
        public bool Painting { get; set; }
        public string? Color { get; set; }
        public bool AnotherService { get; set; }
        public string? AnotherServiceText { get; set; }
        public DateTime CurrentDay { get; set; }
    }
}
