using Application.Commands;
using FluentValidation;

namespace Application.Validators
{
    internal class AcceptSupportTicketValidator : AbstractValidator<AcceptSupportTicketCommand>
    {
        public AcceptSupportTicketValidator()
        {
            RuleFor(x => x.ticketId)
          .NotEmpty().WithMessage("ticket Id Should not be empty. ");
        }
    }
}
