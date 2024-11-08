using FluentValidation;
using ScheduleTime.Domain.Entities;

namespace ScheduleTime.Application.Validations
{
    public class ScheduleValidator : AbstractValidator<Schedule>
    {
        public ScheduleValidator()
        {
            RuleFor(s => s.ScheduledTime)
                .GreaterThan(DateTime.Now).WithMessage("Data do agendamento deve ser uma data futura").NotEmpty();
        }
    }
}
