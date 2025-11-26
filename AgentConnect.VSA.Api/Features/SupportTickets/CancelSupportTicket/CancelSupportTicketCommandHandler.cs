using Application.Commands;
using Domain.VSA.Core.Result;
using MediatR;

namespace Application.CommandHandlers
{
    public class CancelSupportTicketCommandHandler : IRequestHandler<CancelSupportTicketCommand, Result>
    {
        public Task<Result> Handle(CancelSupportTicketCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
