namespace ScheduleTime.CrossCutting.DTOs.VOs
{
    public record LashVO
    {
        public string? Model { get; init; }

        private LashVO() { }

        public LashVO(string? model)
        {
            Model = model;
        }
    }
}
