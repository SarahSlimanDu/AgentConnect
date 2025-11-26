using Domain.Core.Result;
using MediatR;

namespace Application.Commands
{
    public record AcceptSupportTicketCommand(Guid ticketId) : IRequest<Result>;

}
