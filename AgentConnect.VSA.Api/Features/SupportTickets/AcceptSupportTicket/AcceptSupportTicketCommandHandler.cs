using Application.Commands;
using Domain.VSA.Core.Result;
using MediatR;

namespace AgentConnect.VSA.Api
{
    public class AcceptSupportTicketCommandHandler : IRequestHandler<AcceptSupportTicketCommand, Result>
    {
        public Task<Result> Handle(AcceptSupportTicketCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
