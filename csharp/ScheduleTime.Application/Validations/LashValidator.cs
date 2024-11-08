using FluentValidation;
using ScheduleTime.Domain.Entities.ServiceType;

namespace ScheduleTime.Application.Validations
{
    public class LashValidator : AbstractValidator<Lash>
    {
        public LashValidator()
        {
            When(l => l.Model != null, () =>
            {
                RuleFor(n => n.Model)
                    .NotEmpty().WithMessage("Informe um modelo!");
            });
        }
    }
}
