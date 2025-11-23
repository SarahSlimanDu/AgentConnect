
using Domain.Core.Result;
using MediatR;

namespace Application.SupportTickets.Commands.CancelSupportTicket
{
    public record CancelSupportTicketCommand(Guid userId , Guid ticketId, string reason) : IRequest<Result>;
}
