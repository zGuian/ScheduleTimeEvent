namespace ScheduleTime.CrossCutting.DTOs.VOs
{
    public record HairVO
    {
        public bool Painting { get; set; }
        public string? Color { get; set; }
        public bool ThereChemistry { get; set; }
        public bool AnotherService { get; set; }
        public string? AnotherServiceText { get; set; }

        private HairVO() { }

        public HairVO(bool painting, string? color, bool thereChemistry, bool anotherService, string? anotherServiceText)
        {
            Painting = painting;
            Color = color;
            ThereChemistry = thereChemistry;
            AnotherService = anotherService;
            AnotherServiceText = anotherServiceText;
        }
    }
}
