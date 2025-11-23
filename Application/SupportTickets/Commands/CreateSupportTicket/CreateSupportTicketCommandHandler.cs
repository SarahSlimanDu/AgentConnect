using Domain.Core.Result;
using MediatR;

namespace Application.SupportTickets.Commands.CreateSupportTicket
{
    public class CreateSupportTicketCommandHandler : IRequestHandler<CreateSupportTicketCommand, Result>
    {
        public Task<Result> Handle(CreateSupportTicketCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
