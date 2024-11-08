using FluentValidation;
using ScheduleTime.Domain.Entities.ServiceType;

namespace ScheduleTime.Application.Validations
{
    public class HairValidator : AbstractValidator<Hair>
    {
        public HairValidator()
        {
            When(h => h.Painting == true, () =>
            {
                RuleFor(h => h.Color)
                    .NotNull().WithMessage("Informe a cor que deseja pintar o cabelo");
            });

            When(h => h.ThereChemistry == true, () =>
            {
                RuleFor(h => h.ThereChemistryText)
                    .NotNull().WithMessage("Informe os procedimentos quimicos desejados");
            });

            When(h => h.AnotherService == true, () =>
            {
                RuleFor(h => h.AnotherServiceText)
                    .NotNull().WithMessage("Informe os serviços que deseja fazer");
            });
        }
    }
}
