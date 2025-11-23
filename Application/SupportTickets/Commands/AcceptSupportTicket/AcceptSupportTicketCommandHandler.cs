using Domain.Core.Result;
using MediatR;

namespace Application.SupportTickets.Commands.AcceptSupportTicket
{
    public class AcceptSupportTicketCommandHandler : IRequestHandler<AcceptSupportTicketCommand, Result>
    {
        public Task<Result> Handle(AcceptSupportTicketCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
