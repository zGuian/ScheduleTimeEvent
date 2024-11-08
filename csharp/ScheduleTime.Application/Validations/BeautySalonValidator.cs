using FluentValidation;
using ScheduleTime.Domain.Entities;

#pragma warning disable CS8620

namespace ScheduleTime.Application.Validations
{
    public class BeautySalonValidator : AbstractValidator<BeautySalon>
    {
        public BeautySalonValidator()
        {
            When(bs => bs.Hair != null, () =>
            {
                RuleFor(bs => bs.Hair)
                    .SetValidator(new HairValidator());
            });

            When(bs => bs.Nail != null, () =>
            {
                RuleFor(bs => bs.Nail)
                    .SetValidator(new NailValidator());
            });

            When(bs => bs.Lash != null, () =>
            {
                RuleFor(bs => bs.Lash)
                .SetValidator(new LashValidator());
            });

            When(bs => bs.AnotherProcedure != null, () =>
            {
                RuleFor(bs => bs.AnotherProcedure)
                    .SetValidator(new AnotheProcedureValidator()); // TERMINAR DE CRIAR A VALIDAÇÃO
            });

            When(bs => bs.Schedule != null, ()  => 
            {
                RuleFor(bs => bs.Schedule)
                    .SetValidator(new ScheduleValidator()); // TERMINAR DE CRIAR A VALIDAÇÃO
            });
        }
    }
}
