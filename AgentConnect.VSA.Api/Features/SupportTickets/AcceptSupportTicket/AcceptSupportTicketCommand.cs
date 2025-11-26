using Domain.VSA.Core.Result;
using MediatR;

namespace AgentConnect.VSA.Api
{
    public record AcceptSupportTicketCommand(Guid ticketId) : IRequest<Result>;

}
