using Application.Commands;
using Domain.Core.Result;
using MediatR;

namespace Application.CommandHandlers
{
    public class AcceptSupportTicketCommandHandler : IRequestHandler<AcceptSupportTicketCommand, Result>
    {
        public Task<Result> Handle(AcceptSupportTicketCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
