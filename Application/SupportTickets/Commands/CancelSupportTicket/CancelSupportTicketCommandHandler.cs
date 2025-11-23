using Domain.Core.Result;
using MediatR;

namespace Application.SupportTickets.Commands.CancelSupportTicket
{
    public class CancelSupportTicketCommandHandler : IRequestHandler<CancelSupportTicketCommand, Result>
    {
        public Task<Result> Handle(CancelSupportTicketCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
