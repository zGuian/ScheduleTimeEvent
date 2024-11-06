using FluentValidation;
using ScheduleTime.Domain.Entities;

namespace ScheduleTime.Application.Validations
{
    public class CustomerValidator : AbstractValidator<Customer>
    {
        public CustomerValidator()
        {
            RuleFor(c => c.FirstName)
                .NotEmpty().WithMessage("Primeiro nome não pode ser vazio!")
                .NotNull().WithMessage("Primeiro nome não pode ser nulo!")
                .MaximumLength(12).WithMessage("Maximo de 12 caracteres")
                .WithSeverity(Severity.Warning);

            RuleFor(c => c.LastName)
                .NotEmpty().WithMessage("Segundo nome não pode ser vazio!")
                .NotNull().WithMessage("Segundo nome não pode ser nulo!")
                .MaximumLength(12).WithMessage("Maximo de 12 caracteres")
                .WithSeverity(Severity.Warning);

            RuleFor(c => c.FullName)
                .NotEmpty().WithMessage("Nome completo não pode ser vazio!")
                .NotNull().WithMessage("Nome completo não pode ser nulo!")
                .MaximumLength(25).WithMessage("Maximo de 25 caracteres")
                .WithSeverity(Severity.Warning);

            RuleFor(c => c.Email)
                .NotEmpty().WithMessage("Email não pode ser vazio!")
                .NotNull().WithMessage("Email não pode ser nulo!")
                .EmailAddress().WithName("Informe um email válido!")
                .WithSeverity(Severity.Warning);

            RuleFor(c => c.Phone)
                .NotEmpty().WithMessage("Numero de telefone não pode ser vazio!")
                .NotNull().WithMessage("Numero de telefone não pode ser nulo!")
                .Matches(@"^\([1-9]{2}\) [9]{1}[6-9]{1}[0-9]{7}$|^[1-9]{2} [9]{1}[6-9]{1}[0-9]{7}$").WithMessage("Telefone inválido")
                .WithSeverity(Severity.Warning);
        }
    }
}
