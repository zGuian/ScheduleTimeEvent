namespace ScheduleTime.CrossCutting.DTOs.VOs
{
    public record NailVO
    {
        public string? Method { get; init; }

        private NailVO() { }

        public NailVO(string method)
        {
            Method = method;
        }
    }
}
