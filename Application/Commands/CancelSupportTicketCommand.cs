using Domain.Core.Result;
using MediatR;

namespace Application.Commands
{
    public record CancelSupportTicketCommand(Guid userId, Guid ticketId, string reason) : IRequest<Result>;
}
