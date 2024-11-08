namespace ScheduleTime.Application.Exceptions
{
    public class ValidationBusinessException : Exception
    {
        public IEnumerable<string> Erros { get; }

        private ValidationBusinessException()
        {
            if (Erros == null) throw new ArgumentNullException(nameof(Erros));
        }

        public ValidationBusinessException(IEnumerable<string> message) : base(string.Join(", ", message))
        {
            Erros = message;
        }
    }
}
