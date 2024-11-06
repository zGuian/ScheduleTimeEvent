using FluentValidation;
using ScheduleTime.Domain.Entities;

namespace ScheduleTime.Application.Validations
{
    public class BeautySalonValidator : AbstractValidator<BeautySalon>
    {
        public BeautySalonValidator()
        {
            RuleFor(bs => bs.Nail);

            RuleFor(bs => bs.Lash);
        }
    }
}
