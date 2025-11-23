using Domain.Core.Result;
using MediatR;

namespace Application.SupportTickets.Commands.AcceptSupportTicket
{
    public record AcceptSupportTicketCommand(Guid ticketId) : IRequest<Result>;
    
}
