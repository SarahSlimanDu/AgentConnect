using Application.Commands;
using FluentValidation;

namespace Application.Validators
{
    internal class CreateSupportTicketValidator : AbstractValidator<CreateSupportTicketCommand>
    {
        public CreateSupportTicketValidator()
        {
            RuleFor(x => x.userId)
       .NotEmpty().WithMessage("user Id Should not be empty. ");

            RuleFor(x => x.subject)
       .NotEmpty().WithMessage("Ticket should has subject ");
        }
    }
}
