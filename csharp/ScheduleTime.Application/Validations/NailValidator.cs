using FluentValidation;
using ScheduleTime.Domain.Entities.ServiceType;

namespace ScheduleTime.Application.Validations
{
    public class NailValidator : AbstractValidator<Nail>
    {
        public NailValidator()
        {
            When(n => n.Method != null, () =>
            {
                RuleFor(n => n.Method)
                    .NotEmpty().WithMessage("Informe um metodo");
            });
        }
    }
}
