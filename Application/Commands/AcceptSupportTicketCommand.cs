using Domain.Core.Result;
using MediatR;

namespace Application.Commands
{
    public record AcceptSupportTicketCommand(Guid ticketId, Guid agentId) : IRequest<Result>;

}
