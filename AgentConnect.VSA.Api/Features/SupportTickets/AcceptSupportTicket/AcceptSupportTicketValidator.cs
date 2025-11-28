using FluentValidation;

 namespace AgentConnect.VSA.Api
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
